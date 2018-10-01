using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
namespace AinaKeypad
{
    public partial class Form1 : Form
    {
        
        private SerialReader Serial;
        private ConfigData dsConfig = new ConfigData();
        private String XMLLocation = Application.StartupPath + @"\XMLConfig.xml";
        private Boolean loaded = false;
        public Form1()
        {
            InitializeComponent();
            Serial = new SerialReader(this);
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                this.ports.Items.Add(port);
            }

            try
            {
                dsConfig.ReadXml(XMLLocation);
            }
            catch (System.IO.FileNotFoundException e) {
                dsConfig.WriteXml(XMLLocation);
                dsConfig.ReadXml(XMLLocation);
            }
            DataTable dtPreset = dsConfig.Tables["Preset"];
            DataTable dtDefPreset = dsConfig.Tables["DefaultPreset"];
            DataRow drDefPreset = dtDefPreset.Rows.Count > 0 ? dtDefPreset.Rows[0] : null;
            this.presetList.DataSource = dtPreset;
            if (drDefPreset != null)
            {
                this.presetList.SelectedValue = drDefPreset["id"];
            }
            loaded = true;
            LoadPreset();
            toggleEdit(null, null);
            // this.presetList.DisplayMember = "Description";
            // this.presetList
        }

        public void processSerialInput(String input)
        {
            TextBox output;
          //  this.ainaConnStatus.Text = input;

            output = this.ainaConnStatus;
            if (output.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { input, output });
            }
            else
            {
                //output.Text = controll.getValue();
                SetText(input, output);
            }
        }

        delegate void SetTextCallback(string input, TextBox output);
        private void SetText(string input, TextBox output)
        {
            //output.Text = input;
            handleSerialButton(input);
        }

        private void connSerial_Click(object sender, EventArgs e)
        {
            bool connected = this.Serial.ConnectAinaBoard(this.ports.Text);
            this.ainaConnStatus.Text = connected ? "connected" : "disconnected";
        }

        private void testAinaConn_Click(object sender, EventArgs e)
        {
            this.ainaConnStatus.Text = this.Serial.isOpen() ? "connected" : "disconnected";
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = false;
            String output = (e.Shift ? "Shift+" : "") + (e.Control ? "Control+" : "") + (e.Alt ? "Alt+" : "");
            String code = (e.Shift ? "+" : "") + (e.Control ? "^" : "") + (e.Alt ? "%" : "");
            TextBox input = (TextBox)sender;
            input.Text = output + (e.KeyCode == Keys.Space ? e.KeyCode.ToString() : KeycodeToChar(e.KeyCode));
            

            //DataTable dtMapping = dsConfig.Tables["KeyMapping"];
            //DataRow drMapping = dtMapping.NewRow();
            //drMapping["KeyCode"] = e.KeyCode;
            //dtMapping.Rows.Add(drMapping);

            string currentPreset = this.presetList.SelectedValue.ToString();
            DataTable dtPresetConfig = dsConfig.Tables["PresetConfig"];
            DataRow[] drPresetConfigs;
            string expression = "presetId = '" + currentPreset + "' And InputName = '"+input.Name+"'";
            drPresetConfigs = dtPresetConfig.Select(expression);
            if (drPresetConfigs.Count() > 0) {
                drPresetConfigs[0]["KeysDesc"] = input.Text;
                drPresetConfigs[0]["KeysCode"] = code+ KeycodeToChar(e.KeyCode);
            }
            dsConfig.WriteXml(XMLLocation);
        }

        private void ConfKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddPreset(object sender, EventArgs e)
        {
            String newPreset = this.NewPresetName.Text;
            if (newPreset == "") {
                return;
            }
            DataTable dtPreset = dsConfig.Tables["Preset"];
            DataRow drPreset = dtPreset.NewRow();
            drPreset["id"] = dtPreset.Rows.Count;
            drPreset["Description"] = newPreset;
            dtPreset.Rows.Add(drPreset);

            DataTable dtPresetConfig = dsConfig.Tables["PresetConfig"];
            DataRow drPresetConfig;
            string inputName = "";
            string button = "";
            for (int i = 0; i<=15; i++) {
                switch (i) {
                    case 10:
                        button = "A";
                        inputName = "tA";
                        break;
                    case 11:
                        button = "B";
                        inputName = "tB";
                        break;
                    case 12:
                        button = "C";
                        inputName = "tC";
                        break;
                    case 13:
                        button = "D";
                        inputName = "tD";
                        break;
                    case 14:
                        button = "*";
                        inputName = "tS";
                        break;
                    case 15:
                        button = "#";
                        inputName = "tH";
                        break;
                    default:
                        button = i.ToString();
                        inputName = "t" + i.ToString();
                        break;
                }
                drPresetConfig = dtPresetConfig.NewRow();
                drPresetConfig["id"] = dtPresetConfig.Rows.Count;
                drPresetConfig["presetId"] = drPreset["id"];
                drPresetConfig["KeypadButton"] = button;
                drPresetConfig["KeysDesc"] = "";
                drPresetConfig["KeysCode"] = "";
                drPresetConfig["InputName"] = inputName;
                dtPresetConfig.Rows.Add(drPresetConfig);
            }

            dsConfig.WriteXml(XMLLocation);
            this.NewPresetName.Text = "";
        }

        private void PresetChanged(object sender, EventArgs e)
        {
            if (!loaded) {
                return;
            }
            this.ainaConnStatus.Text = this.presetList.SelectedValue.ToString();
            DataTable dtPreset = dsConfig.Tables["DefaultPreset"];
            DataRow drPreset = dtPreset.Rows.Count > 0 ? dtPreset.Rows[0] : dtPreset.NewRow();
            drPreset["id"] = this.presetList.SelectedValue.ToString();

            if (dtPreset.Rows.Count == 0) {
                dtPreset.Rows.Add(drPreset);
            }
            
            dsConfig.WriteXml(XMLLocation);
            LoadPreset();
        }

        private void LoadPreset() {
            if (this.presetList.SelectedValue == null)
                return;
            string currentPreset = this.presetList.SelectedValue.ToString();
            DataTable dtPresetConfig = dsConfig.Tables["PresetConfig"];
            DataRow[] drPresetConfigs;
            string expression = "presetId = '" + currentPreset + "'";
            drPresetConfigs = dtPresetConfig.Select(expression);
            foreach (DataRow drPresetConfig in drPresetConfigs) {
                TextBox input = (TextBox)this.Controls[drPresetConfig["InputName"].ToString()];
                input.Text = drPresetConfig["KeysDesc"].ToString();
            }
        }

        public String KeycodeToChar(Keys keyCode)
        {
            Keys key = (Keys)keyCode;
            if (key >= Keys.F1 && key <= Keys.F19) {
                return "{" + key.ToString() + "}";
            }
            switch (key)
            {
                case Keys.Add:
                    return "{ADD}";
                case Keys.Decimal:
                    return ".";
                case Keys.Divide:
                    return "{DIVIDE}";
                case Keys.Multiply:
                    return "{MULTIPLY}";
                case Keys.OemBackslash:
                    return "\\";
                case Keys.OemCloseBrackets:
                    return "]";
                case Keys.OemMinus:
                    return "{SUBTRACT}";
                case Keys.OemOpenBrackets:
                    return "[";
                case Keys.OemPeriod:
                    return ".";
                case Keys.OemPipe:
                    return "|";
                case Keys.OemQuestion:
                    return "{DIVIDE}";
                case Keys.OemQuotes:
                    return "\"";
                case Keys.OemSemicolon:
                    return ";";
                case Keys.Oemcomma:
                    return ",";
                case Keys.Oemplus:
                    return "=";
                case Keys.Oemtilde:
                    return "`";
                case Keys.Separator:
                    return "{SUBTRACT}";
                case Keys.Subtract:
                    return "{SUBTRACT}";
                case Keys.D0:
                    return "0";
                case Keys.D1:
                    return "1";
                case Keys.D2:
                    return "2";
                case Keys.D3:
                    return "3";
                case Keys.D4:
                    return "4";
                case Keys.D5:
                    return "5";
                case Keys.D6:
                    return "6";
                case Keys.D7:
                    return "7";
                case Keys.D8:
                    return "8";
                case Keys.D9:
                    return "9";
                case Keys.Space:
                    return " ";
                case Keys.Back:
                    return "{BACKSPACE}";
                case Keys.Delete:
                    return "{DELETE}";
                case Keys.Down:
                    return "{DOWN}";
                case Keys.Up:
                    return "{UP}";
                case Keys.Left:
                    return "{LEFT}";
                case Keys.Right:
                    return "{RIGHT}";
                case Keys.PageUp:
                    return "{PGUP}";
                case Keys.PageDown:
                    return "{PGDN}";
                case Keys.Enter:
                    return "{ENTER}";
                case Keys.Home:
                    return "{HOME}";
                case Keys.End:
                    return "{END}";
                case Keys.Tab:
                    return "{TAB}";
                default:
                    return key.ToString().ToLower();
            }
        }

        public void handleSerialButton(string input) {
            if (this.presetList.SelectedValue == null)
                return;
            string currentPreset = this.presetList.SelectedValue.ToString();
            DataTable dtPresetConfig = dsConfig.Tables["PresetConfig"];
            DataRow[] drPresetConfigs;
            string expression = "presetId = '" + currentPreset + "' And KeypadButton = '"+input.Replace("\r","")+"'";
            drPresetConfigs = dtPresetConfig.Select(expression);
            if (drPresetConfigs.Count() > 0) {
                this.ainaConnStatus.Text = drPresetConfigs[0]["KeysCode"].ToString();
                System.Windows.Forms.SendKeys.SendWait(drPresetConfigs[0]["KeysCode"].ToString());
            }
        }

        public void toggleEdit(object sender, EventArgs e)
        {
            string inputName = "";
            for (int i = 0; i <= 15; i++)
            {
                switch (i)
                {
                    case 10:
                        inputName = "tA";
                        break;
                    case 11:
                        inputName = "tB";
                        break;
                    case 12:
                        inputName = "tC";
                        break;
                    case 13:
                        inputName = "tD";
                        break;
                    case 14:
                        inputName = "tS";
                        break;
                    case 15:
                        inputName = "tH";
                        break;
                    default:
                        inputName = "t" + i.ToString();
                        break;
                }
                this.Controls[inputName].Enabled = !this.Controls[inputName].Enabled;
            }
            this.NewPresetName.Enabled = !this.NewPresetName.Enabled;
            this.CreatePreset.Enabled = !this.CreatePreset.Enabled;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.Opacity = 0.3;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else {
                this.TopMost = false;
                this.Opacity = 1;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }

                    return;
            }

            base.WndProc(ref m);
        }
    }
}
