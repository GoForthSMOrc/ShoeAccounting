namespace ShoeAccounting
{
    partial class ShoeField
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.showproblemButton = new System.Windows.Forms.Button();
            this.showCommsButton = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelDateReg = new System.Windows.Forms.Label();
            this.labelDateComp = new System.Windows.Forms.Label();
            this.userinfoButton = new System.Windows.Forms.Button();
            this.masterinfoButton = new System.Windows.Forms.Button();
            this.labelStat = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelDateRegistration = new System.Windows.Forms.Label();
            this.labelDateCompletion = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // showproblemButton
            // 
            this.showproblemButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.showproblemButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showproblemButton.ForeColor = System.Drawing.Color.White;
            this.showproblemButton.Location = new System.Drawing.Point(641, 109);
            this.showproblemButton.Name = "showproblemButton";
            this.showproblemButton.Size = new System.Drawing.Size(294, 41);
            this.showproblemButton.TabIndex = 14;
            this.showproblemButton.Text = "Описание проблемы";
            this.showproblemButton.UseVisualStyleBackColor = false;
            this.showproblemButton.Click += new System.EventHandler(this.showproblemButton_Click);
            // 
            // showCommsButton
            // 
            this.showCommsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.showCommsButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showCommsButton.ForeColor = System.Drawing.Color.White;
            this.showCommsButton.Location = new System.Drawing.Point(641, 156);
            this.showCommsButton.Name = "showCommsButton";
            this.showCommsButton.Size = new System.Drawing.Size(294, 41);
            this.showCommsButton.TabIndex = 15;
            this.showCommsButton.Text = "Комментарии";
            this.showCommsButton.UseVisualStyleBackColor = false;
            this.showCommsButton.Click += new System.EventHandler(this.showCommsButton_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNum.ForeColor = System.Drawing.Color.White;
            this.labelNum.Location = new System.Drawing.Point(15, 27);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(94, 29);
            this.labelNum.TabIndex = 16;
            this.labelNum.Text = "Номер :";
            // 
            // labelDateReg
            // 
            this.labelDateReg.AutoSize = true;
            this.labelDateReg.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateReg.ForeColor = System.Drawing.Color.White;
            this.labelDateReg.Location = new System.Drawing.Point(15, 83);
            this.labelDateReg.Name = "labelDateReg";
            this.labelDateReg.Size = new System.Drawing.Size(214, 29);
            this.labelDateReg.TabIndex = 17;
            this.labelDateReg.Text = "Дата регистрации :";
            // 
            // labelDateComp
            // 
            this.labelDateComp.AutoSize = true;
            this.labelDateComp.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateComp.ForeColor = System.Drawing.Color.White;
            this.labelDateComp.Location = new System.Drawing.Point(15, 140);
            this.labelDateComp.Name = "labelDateComp";
            this.labelDateComp.Size = new System.Drawing.Size(194, 29);
            this.labelDateComp.TabIndex = 18;
            this.labelDateComp.Text = "Дата окончания :";
            // 
            // userinfoButton
            // 
            this.userinfoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.userinfoButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userinfoButton.ForeColor = System.Drawing.Color.White;
            this.userinfoButton.Location = new System.Drawing.Point(641, 62);
            this.userinfoButton.Name = "userinfoButton";
            this.userinfoButton.Size = new System.Drawing.Size(294, 41);
            this.userinfoButton.TabIndex = 19;
            this.userinfoButton.Text = "Пользователь";
            this.userinfoButton.UseVisualStyleBackColor = false;
            this.userinfoButton.Click += new System.EventHandler(this.userinfoButton_Click);
            // 
            // masterinfoButton
            // 
            this.masterinfoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.masterinfoButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masterinfoButton.ForeColor = System.Drawing.Color.White;
            this.masterinfoButton.Location = new System.Drawing.Point(641, 15);
            this.masterinfoButton.Name = "masterinfoButton";
            this.masterinfoButton.Size = new System.Drawing.Size(294, 41);
            this.masterinfoButton.TabIndex = 20;
            this.masterinfoButton.Text = "Мастер";
            this.masterinfoButton.UseVisualStyleBackColor = false;
            this.masterinfoButton.Click += new System.EventHandler(this.masterinfoButton_Click);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStat.ForeColor = System.Drawing.Color.White;
            this.labelStat.Location = new System.Drawing.Point(15, 199);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(94, 29);
            this.labelStat.TabIndex = 21;
            this.labelStat.Text = "Статус :";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumber.ForeColor = System.Drawing.Color.White;
            this.labelNumber.Location = new System.Drawing.Point(106, 27);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(83, 29);
            this.labelNumber.TabIndex = 22;
            this.labelNumber.Text = "Номер";
            // 
            // labelDateRegistration
            // 
            this.labelDateRegistration.AutoSize = true;
            this.labelDateRegistration.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateRegistration.ForeColor = System.Drawing.Color.White;
            this.labelDateRegistration.Location = new System.Drawing.Point(235, 83);
            this.labelDateRegistration.Name = "labelDateRegistration";
            this.labelDateRegistration.Size = new System.Drawing.Size(203, 29);
            this.labelDateRegistration.TabIndex = 23;
            this.labelDateRegistration.Text = "Дата регистрации";
            // 
            // labelDateCompletion
            // 
            this.labelDateCompletion.AutoSize = true;
            this.labelDateCompletion.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateCompletion.ForeColor = System.Drawing.Color.White;
            this.labelDateCompletion.Location = new System.Drawing.Point(215, 140);
            this.labelDateCompletion.Name = "labelDateCompletion";
            this.labelDateCompletion.Size = new System.Drawing.Size(183, 29);
            this.labelDateCompletion.TabIndex = 24;
            this.labelDateCompletion.Text = "Дата окончания";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(106, 199);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(83, 29);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "Статус";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLine.Location = new System.Drawing.Point(0, 240);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(950, 5);
            this.panelLine.TabIndex = 26;
            // 
            // ShoeField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelDateCompletion);
            this.Controls.Add(this.labelDateRegistration);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.masterinfoButton);
            this.Controls.Add(this.userinfoButton);
            this.Controls.Add(this.labelDateComp);
            this.Controls.Add(this.labelDateReg);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.showCommsButton);
            this.Controls.Add(this.showproblemButton);
            this.Name = "ShoeField";
            this.Size = new System.Drawing.Size(945, 245);
            this.Click += new System.EventHandler(this.ShoeField_Click);
            this.MouseEnter += new System.EventHandler(this.ShoeField_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showproblemButton;
        private System.Windows.Forms.Button showCommsButton;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDateReg;
        private System.Windows.Forms.Label labelDateComp;
        private System.Windows.Forms.Button userinfoButton;
        private System.Windows.Forms.Button masterinfoButton;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDateRegistration;
        private System.Windows.Forms.Label labelDateCompletion;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelLine;
    }
}
