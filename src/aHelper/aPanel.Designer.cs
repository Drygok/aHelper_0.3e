namespace aHelper
{
    partial class aPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aPanel));
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.whButton = new System.Windows.Forms.Button();
            this.whTrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tpmapCheckBox = new System.Windows.Forms.CheckBox();
            this.hpCheckBox = new System.Windows.Forms.CheckBox();
            this.nofallButton = new System.Windows.Forms.Button();
            this.nocrashButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fastconnectCheckBox = new System.Windows.Forms.CheckBox();
            this.flyButton = new System.Windows.Forms.CheckBox();
            this.setposButton = new System.Windows.Forms.Button();
            this.xposText = new System.Windows.Forms.TextBox();
            this.updateposButton = new System.Windows.Forms.Button();
            this.zposText = new System.Windows.Forms.TextBox();
            this.yposText = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorTimer
            // 
            this.colorTimer.Enabled = true;
            this.colorTimer.Interval = 1;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.whButton);
            this.panel1.Controls.Add(this.whTrackBar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автор: vk.com/idDrygok";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // whButton
            // 
            this.whButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whButton.Location = new System.Drawing.Point(3, 54);
            this.whButton.Name = "whButton";
            this.whButton.Size = new System.Drawing.Size(350, 61);
            this.whButton.TabIndex = 1;
            this.whButton.Text = "Установить дальность ников: 15";
            this.whButton.UseVisualStyleBackColor = true;
            this.whButton.Click += new System.EventHandler(this.whButton_Click);
            // 
            // whTrackBar
            // 
            this.whTrackBar.Location = new System.Drawing.Point(3, 3);
            this.whTrackBar.Maximum = 512;
            this.whTrackBar.Name = "whTrackBar";
            this.whTrackBar.Size = new System.Drawing.Size(350, 45);
            this.whTrackBar.TabIndex = 0;
            this.whTrackBar.Value = 15;
            this.whTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.tpmapCheckBox);
            this.panel2.Controls.Add(this.hpCheckBox);
            this.panel2.Controls.Add(this.nofallButton);
            this.panel2.Controls.Add(this.nocrashButton);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 138);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Не изменять состояние двигателя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tpmapCheckBox
            // 
            this.tpmapCheckBox.AutoSize = true;
            this.tpmapCheckBox.Enabled = false;
            this.tpmapCheckBox.Location = new System.Drawing.Point(2, 72);
            this.tpmapCheckBox.Name = "tpmapCheckBox";
            this.tpmapCheckBox.Size = new System.Drawing.Size(280, 23);
            this.tpmapCheckBox.TabIndex = 4;
            this.tpmapCheckBox.Text = "Телепорт по маркеру на карте";
            this.tpmapCheckBox.UseVisualStyleBackColor = true;
            this.tpmapCheckBox.CheckedChanged += new System.EventHandler(this.tpmapCheckBox_CheckedChanged);
            // 
            // hpCheckBox
            // 
            this.hpCheckBox.AutoSize = true;
            this.hpCheckBox.Location = new System.Drawing.Point(2, 43);
            this.hpCheckBox.Name = "hpCheckBox";
            this.hpCheckBox.Size = new System.Drawing.Size(352, 23);
            this.hpCheckBox.TabIndex = 3;
            this.hpCheckBox.Text = "Восстановление здоровья (авто/игрок)";
            this.hpCheckBox.UseVisualStyleBackColor = true;
            this.hpCheckBox.CheckedChanged += new System.EventHandler(this.hpCheckBox_CheckedChanged);
            // 
            // nofallButton
            // 
            this.nofallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nofallButton.Location = new System.Drawing.Point(135, 3);
            this.nofallButton.Name = "nofallButton";
            this.nofallButton.Size = new System.Drawing.Size(218, 34);
            this.nofallButton.TabIndex = 2;
            this.nofallButton.Text = "Не падать с байка";
            this.nofallButton.UseVisualStyleBackColor = true;
            this.nofallButton.Click += new System.EventHandler(this.nofallButton_Click);
            // 
            // nocrashButton
            // 
            this.nocrashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nocrashButton.Location = new System.Drawing.Point(3, 3);
            this.nocrashButton.Name = "nocrashButton";
            this.nocrashButton.Size = new System.Drawing.Size(126, 34);
            this.nocrashButton.TabIndex = 1;
            this.nocrashButton.Text = "Антикрашер";
            this.nocrashButton.UseVisualStyleBackColor = true;
            this.nocrashButton.Click += new System.EventHandler(this.nocrashButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.fastconnectCheckBox);
            this.panel3.Controls.Add(this.flyButton);
            this.panel3.Controls.Add(this.setposButton);
            this.panel3.Controls.Add(this.xposText);
            this.panel3.Controls.Add(this.updateposButton);
            this.panel3.Controls.Add(this.zposText);
            this.panel3.Controls.Add(this.yposText);
            this.panel3.Location = new System.Drawing.Point(12, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 123);
            this.panel3.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(40, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "HUD";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fastconnectCheckBox
            // 
            this.fastconnectCheckBox.AutoSize = true;
            this.fastconnectCheckBox.Enabled = false;
            this.fastconnectCheckBox.Location = new System.Drawing.Point(226, 75);
            this.fastconnectCheckBox.Name = "fastconnectCheckBox";
            this.fastconnectCheckBox.Size = new System.Drawing.Size(127, 23);
            this.fastconnectCheckBox.TabIndex = 10;
            this.fastconnectCheckBox.Text = "FastConnect";
            this.fastconnectCheckBox.UseVisualStyleBackColor = true;
            this.fastconnectCheckBox.CheckedChanged += new System.EventHandler(this.fastconnectCheckBox_CheckedChanged);
            // 
            // flyButton
            // 
            this.flyButton.AutoSize = true;
            this.flyButton.Location = new System.Drawing.Point(3, 75);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(136, 23);
            this.flyButton.TabIndex = 9;
            this.flyButton.Text = "Fly (пешком)";
            this.flyButton.UseVisualStyleBackColor = true;
            this.flyButton.CheckedChanged += new System.EventHandler(this.flyButton_CheckedChanged);
            // 
            // setposButton
            // 
            this.setposButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setposButton.Location = new System.Drawing.Point(168, 35);
            this.setposButton.Name = "setposButton";
            this.setposButton.Size = new System.Drawing.Size(182, 34);
            this.setposButton.TabIndex = 8;
            this.setposButton.Text = "Установить";
            this.setposButton.UseVisualStyleBackColor = true;
            this.setposButton.Click += new System.EventHandler(this.setposButton_Click);
            // 
            // xposText
            // 
            this.xposText.Location = new System.Drawing.Point(3, 3);
            this.xposText.Name = "xposText";
            this.xposText.Size = new System.Drawing.Size(120, 26);
            this.xposText.TabIndex = 7;
            // 
            // updateposButton
            // 
            this.updateposButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateposButton.Location = new System.Drawing.Point(3, 35);
            this.updateposButton.Name = "updateposButton";
            this.updateposButton.Size = new System.Drawing.Size(159, 34);
            this.updateposButton.TabIndex = 6;
            this.updateposButton.Text = "Обновить";
            this.updateposButton.UseVisualStyleBackColor = true;
            this.updateposButton.Click += new System.EventHandler(this.updateposButton_Click);
            // 
            // zposText
            // 
            this.zposText.Location = new System.Drawing.Point(253, 3);
            this.zposText.Name = "zposText";
            this.zposText.Size = new System.Drawing.Size(100, 26);
            this.zposText.TabIndex = 2;
            // 
            // yposText
            // 
            this.yposText.Location = new System.Drawing.Point(127, 3);
            this.yposText.Name = "yposText";
            this.yposText.Size = new System.Drawing.Size(120, 26);
            this.yposText.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 403);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(356, 71);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // globalTimer
            // 
            this.globalTimer.Interval = 75;
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(124, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(226, 23);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Не изменять координаты";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(12, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 67);
            this.panel4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(380, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(396, 593);
            this.Name = "aPanel";
            this.Text = "aHelper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aPanel_FormClosed);
            this.Load += new System.EventHandler(this.aPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer colorTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button whButton;
        private System.Windows.Forms.TrackBar whTrackBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox tpmapCheckBox;
        private System.Windows.Forms.CheckBox hpCheckBox;
        private System.Windows.Forms.Button nofallButton;
        private System.Windows.Forms.Button nocrashButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox flyButton;
        private System.Windows.Forms.Button setposButton;
        private System.Windows.Forms.TextBox xposText;
        private System.Windows.Forms.Button updateposButton;
        private System.Windows.Forms.TextBox zposText;
        private System.Windows.Forms.TextBox yposText;
        private System.Windows.Forms.CheckBox fastconnectCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}