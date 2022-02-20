namespace ShoeAccounting
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.adduserButton = new System.Windows.Forms.Button();
            this.labelAddUser = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.patronBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelPatron = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.closeWinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adduserButton
            // 
            this.adduserButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.adduserButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adduserButton.ForeColor = System.Drawing.Color.White;
            this.adduserButton.Location = new System.Drawing.Point(144, 438);
            this.adduserButton.Name = "adduserButton";
            this.adduserButton.Size = new System.Drawing.Size(294, 41);
            this.adduserButton.TabIndex = 14;
            this.adduserButton.Text = "Добавить пользователя";
            this.adduserButton.UseVisualStyleBackColor = false;
            this.adduserButton.Click += new System.EventHandler(this.adduserButton_Click);
            // 
            // labelAddUser
            // 
            this.labelAddUser.AutoSize = true;
            this.labelAddUser.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddUser.ForeColor = System.Drawing.Color.White;
            this.labelAddUser.Location = new System.Drawing.Point(12, 9);
            this.labelAddUser.Name = "labelAddUser";
            this.labelAddUser.Size = new System.Drawing.Size(292, 29);
            this.labelAddUser.TabIndex = 15;
            this.labelAddUser.Text = "Добавление пользователя";
            this.labelAddUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAddUser_MouseDown);
            this.labelAddUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAddUser_MouseMove);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(144, 52);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(421, 37);
            this.logBox.TabIndex = 16;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(144, 95);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(421, 37);
            this.passBox.TabIndex = 17;
            // 
            // lnameBox
            // 
            this.lnameBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnameBox.Location = new System.Drawing.Point(144, 138);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(421, 37);
            this.lnameBox.TabIndex = 18;
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fnameBox.Location = new System.Drawing.Point(144, 181);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(421, 37);
            this.fnameBox.TabIndex = 19;
            // 
            // patronBox
            // 
            this.patronBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patronBox.Location = new System.Drawing.Point(144, 224);
            this.patronBox.Name = "patronBox";
            this.patronBox.Size = new System.Drawing.Size(421, 37);
            this.patronBox.TabIndex = 20;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneBox.Location = new System.Drawing.Point(144, 267);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(421, 37);
            this.phoneBox.TabIndex = 21;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailBox.Location = new System.Drawing.Point(144, 310);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(421, 37);
            this.emailBox.TabIndex = 22;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Администратор",
            "Мастер",
            "Клиент"});
            this.statusBox.Location = new System.Drawing.Point(144, 353);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(421, 37);
            this.statusBox.TabIndex = 23;
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLog.ForeColor = System.Drawing.Color.White;
            this.labelLog.Location = new System.Drawing.Point(12, 60);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(77, 29);
            this.labelLog.TabIndex = 24;
            this.labelLog.Text = "Логин";
            this.labelLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLog_MouseDown);
            this.labelLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLog_MouseMove);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(12, 103);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(90, 29);
            this.labelPass.TabIndex = 25;
            this.labelPass.Text = "Пароль";
            this.labelPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPass_MouseDown);
            this.labelPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPass_MouseMove);
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLName.ForeColor = System.Drawing.Color.White;
            this.labelLName.Location = new System.Drawing.Point(12, 146);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(109, 29);
            this.labelLName.TabIndex = 26;
            this.labelLName.Text = "Фамилия";
            this.labelLName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLName_MouseDown);
            this.labelLName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLName_MouseMove);
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFname.ForeColor = System.Drawing.Color.White;
            this.labelFname.Location = new System.Drawing.Point(12, 189);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(58, 29);
            this.labelFname.TabIndex = 27;
            this.labelFname.Text = "Имя";
            this.labelFname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFname_MouseDown);
            this.labelFname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFname_MouseMove);
            // 
            // labelPatron
            // 
            this.labelPatron.AutoSize = true;
            this.labelPatron.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatron.ForeColor = System.Drawing.Color.White;
            this.labelPatron.Location = new System.Drawing.Point(12, 232);
            this.labelPatron.Name = "labelPatron";
            this.labelPatron.Size = new System.Drawing.Size(112, 29);
            this.labelPatron.TabIndex = 28;
            this.labelPatron.Text = "Отчество";
            this.labelPatron.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPatron_MouseDown);
            this.labelPatron.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPatron_MouseMove);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(12, 275);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(103, 29);
            this.labelPhone.TabIndex = 29;
            this.labelPhone.Text = "Телефон";
            this.labelPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPhone_MouseDown);
            this.labelPhone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPhone_MouseMove);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(12, 318);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(76, 29);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Почта";
            this.labelEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelEmail_MouseDown);
            this.labelEmail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelEmail_MouseMove);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(12, 361);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(83, 29);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Статус";
            this.labelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelStatus_MouseDown);
            this.labelStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelStatus_MouseMove);
            // 
            // closeWinButton
            // 
            this.closeWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeWinButton.ForeColor = System.Drawing.Color.White;
            this.closeWinButton.Location = new System.Drawing.Point(144, 485);
            this.closeWinButton.Name = "closeWinButton";
            this.closeWinButton.Size = new System.Drawing.Size(294, 41);
            this.closeWinButton.TabIndex = 32;
            this.closeWinButton.Text = "Закрыть окно";
            this.closeWinButton.UseVisualStyleBackColor = false;
            this.closeWinButton.Click += new System.EventHandler(this.closeWinButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(583, 543);
            this.Controls.Add(this.closeWinButton);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPatron);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.patronBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.labelAddUser);
            this.Controls.Add(this.adduserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddUser_MouseDown);
            this.MouseHover += new System.EventHandler(this.AddUser_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddUser_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adduserButton;
        private System.Windows.Forms.Label labelAddUser;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox patronBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelPatron;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button closeWinButton;
    }
}