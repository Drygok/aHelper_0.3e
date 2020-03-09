namespace aHelper
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.vkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 103);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(430, 26);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.WordWrap = false;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(315, 135);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(127, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Проверить";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoBox.Location = new System.Drawing.Point(12, 8);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.infoBox.Size = new System.Drawing.Size(434, 85);
            this.infoBox.TabIndex = 3;
            this.infoBox.Text = "";
            // 
            // vkButton
            // 
            this.vkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vkButton.Location = new System.Drawing.Point(12, 135);
            this.vkButton.Name = "vkButton";
            this.vkButton.Size = new System.Drawing.Size(297, 32);
            this.vkButton.TabIndex = 4;
            this.vkButton.Text = "Открыть страницу разработчика";
            this.vkButton.UseVisualStyleBackColor = true;
            this.vkButton.Click += new System.EventHandler(this.vkButton_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(458, 177);
            this.Controls.Add(this.vkButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.Text = "Запуск программы";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vkButton;
    }
}

