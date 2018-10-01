namespace AinaKeypad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ports = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ainaConnStatus = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.tA = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t9 = new System.Windows.Forms.TextBox();
            this.tC = new System.Windows.Forms.TextBox();
            this.tS = new System.Windows.Forms.TextBox();
            this.t0 = new System.Windows.Forms.TextBox();
            this.tH = new System.Windows.Forms.TextBox();
            this.tD = new System.Windows.Forms.TextBox();
            this.presetList = new System.Windows.Forms.ComboBox();
            this.presetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configData = new AinaKeypad.ConfigData();
            this.CreatePreset = new System.Windows.Forms.Button();
            this.NewPresetName = new System.Windows.Forms.TextBox();
            this.presetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ports
            // 
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(93, 14);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(121, 21);
            this.ports.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connSerial_Click);
            // 
            // ainaConnStatus
            // 
            this.ainaConnStatus.Location = new System.Drawing.Point(302, 17);
            this.ainaConnStatus.Name = "ainaConnStatus";
            this.ainaConnStatus.ReadOnly = true;
            this.ainaConnStatus.Size = new System.Drawing.Size(129, 20);
            this.ainaConnStatus.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.testAinaConn_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(12, 125);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 4;
            this.t1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(118, 125);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 5;
            this.t2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(224, 125);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 20);
            this.t3.TabIndex = 6;
            this.t3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tA
            // 
            this.tA.Location = new System.Drawing.Point(330, 125);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(100, 20);
            this.tA.TabIndex = 7;
            this.tA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(12, 151);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 20);
            this.t4.TabIndex = 8;
            this.t4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(118, 151);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 20);
            this.t5.TabIndex = 9;
            this.t5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(224, 151);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(100, 20);
            this.t6.TabIndex = 10;
            this.t6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(330, 151);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(100, 20);
            this.tB.TabIndex = 11;
            this.tB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(11, 177);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(100, 20);
            this.t7.TabIndex = 12;
            this.t7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(118, 177);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(100, 20);
            this.t8.TabIndex = 13;
            this.t8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(224, 177);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(100, 20);
            this.t9.TabIndex = 14;
            this.t9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tC
            // 
            this.tC.Location = new System.Drawing.Point(330, 177);
            this.tC.Name = "tC";
            this.tC.Size = new System.Drawing.Size(100, 20);
            this.tC.TabIndex = 15;
            this.tC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tS
            // 
            this.tS.Location = new System.Drawing.Point(12, 203);
            this.tS.Name = "tS";
            this.tS.Size = new System.Drawing.Size(100, 20);
            this.tS.TabIndex = 16;
            this.tS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // t0
            // 
            this.t0.Location = new System.Drawing.Point(118, 203);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(100, 20);
            this.t0.TabIndex = 17;
            this.t0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.t0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tH
            // 
            this.tH.Location = new System.Drawing.Point(224, 203);
            this.tH.Name = "tH";
            this.tH.Size = new System.Drawing.Size(100, 20);
            this.tH.TabIndex = 18;
            this.tH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // tD
            // 
            this.tD.Location = new System.Drawing.Point(330, 203);
            this.tD.Name = "tD";
            this.tD.Size = new System.Drawing.Size(100, 20);
            this.tD.TabIndex = 19;
            this.tD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.tD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfKeyPress);
            // 
            // presetList
            // 
            this.presetList.DataSource = this.presetBindingSource;
            this.presetList.DisplayMember = "Description";
            this.presetList.FormattingEnabled = true;
            this.presetList.Location = new System.Drawing.Point(12, 55);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(121, 21);
            this.presetList.TabIndex = 20;
            this.presetList.ValueMember = "Id";
            this.presetList.SelectedIndexChanged += new System.EventHandler(this.PresetChanged);
            // 
            // presetBindingSource
            // 
            this.presetBindingSource.DataMember = "Preset";
            this.presetBindingSource.DataSource = this.configData;
            // 
            // configData
            // 
            this.configData.DataSetName = "ConfigData";
            this.configData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreatePreset
            // 
            this.CreatePreset.Location = new System.Drawing.Point(356, 40);
            this.CreatePreset.Name = "CreatePreset";
            this.CreatePreset.Size = new System.Drawing.Size(75, 23);
            this.CreatePreset.TabIndex = 21;
            this.CreatePreset.Text = "Add";
            this.CreatePreset.UseVisualStyleBackColor = true;
            this.CreatePreset.Click += new System.EventHandler(this.AddPreset);
            // 
            // NewPresetName
            // 
            this.NewPresetName.Location = new System.Drawing.Point(250, 42);
            this.NewPresetName.Name = "NewPresetName";
            this.NewPresetName.Size = new System.Drawing.Size(100, 20);
            this.NewPresetName.TabIndex = 22;
            // 
            // presetBindingSource1
            // 
            this.presetBindingSource1.DataMember = "Preset";
            this.presetBindingSource1.DataSource = this.configData;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.toggleEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "New preset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Preset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bindings";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "stayOnTop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 259);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NewPresetName);
            this.Controls.Add(this.CreatePreset);
            this.Controls.Add(this.presetList);
            this.Controls.Add(this.tD);
            this.Controls.Add(this.tH);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.tS);
            this.Controls.Add(this.tC);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.tA);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ainaConnStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AinaMini";
            ((System.ComponentModel.ISupportInitialize)(this.presetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ainaConnStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.TextBox tC;
        private System.Windows.Forms.TextBox tS;
        private System.Windows.Forms.TextBox t0;
        private System.Windows.Forms.TextBox tH;
        private System.Windows.Forms.TextBox tD;
        private System.Windows.Forms.ComboBox presetList;
        private System.Windows.Forms.Button CreatePreset;
        private System.Windows.Forms.TextBox NewPresetName;
        private System.Windows.Forms.BindingSource presetBindingSource;
        private ConfigData configData;
        private System.Windows.Forms.BindingSource presetBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}

