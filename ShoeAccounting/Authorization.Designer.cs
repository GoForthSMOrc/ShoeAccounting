namespace ShoeAccounting
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panelAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelAuthorization.Controls.Add(this.panelLine);
            this.panelAuthorization.Controls.Add(this.labelAuthorization);
            this.panelAuthorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(366, 73);
            this.panelAuthorization.TabIndex = 0;
            this.panelAuthorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAuthorization_MouseDown);
            this.panelAuthorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAuthorization_MouseMove);
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLine.Location = new System.Drawing.Point(0, 70);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(366, 3);
            this.panelLine.TabIndex = 6;
            this.panelLine.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLine_Paint);
            this.panelLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLine_MouseDown);
            this.panelLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLine_MouseMove);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuthorization.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAuthorization.Location = new System.Drawing.Point(105, 22);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(152, 29);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "Авторизация";
            this.labelAuthorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAuthorization_MouseDown);
            this.labelAuthorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAuthorization_MouseMove);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelLogin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLogin.Location = new System.Drawing.Point(13, 106);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(77, 29);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            this.labelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLogin_MouseDown);
            this.labelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLogin_MouseMove);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPassword.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPassword.Location = new System.Drawing.Point(12, 149);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 29);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            this.labelPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPassword_MouseDown);
            this.labelPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPassword_MouseMove);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(113, 98);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(241, 37);
            this.logBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(113, 141);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(241, 37);
            this.passBox.TabIndex = 5;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.enterButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(219, 197);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(135, 41);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(219, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 41);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(366, 321);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelAuthorization);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseMove);
            this.panelAuthorization.ResumeLayout(false);
            this.panelAuthorization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button exitButton;
    }
}