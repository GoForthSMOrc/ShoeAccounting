namespace ShoeAccounting
{
    partial class UpdateRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRecord));
            this.labelUpdateRec = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeWinButton = new System.Windows.Forms.Button();
            this.descprobBox = new System.Windows.Forms.TextBox();
            this.labelShoeStatus = new System.Windows.Forms.Label();
            this.numuserBox = new System.Windows.Forms.TextBox();
            this.mastercomBox = new System.Windows.Forms.TextBox();
            this.labelDateReg = new System.Windows.Forms.Label();
            this.labelDateComp = new System.Windows.Forms.Label();
            this.labelNumUser = new System.Windows.Forms.Label();
            this.labelDescProb = new System.Windows.Forms.Label();
            this.labelMasterCom = new System.Windows.Forms.Label();
            this.masterBox = new System.Windows.Forms.ComboBox();
            this.labelMaster = new System.Windows.Forms.Label();
            this.shoestatBox = new System.Windows.Forms.ComboBox();
            this.dateregBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTipDateCheck = new System.Windows.Forms.ToolTip(this.components);
            this.datecompBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelUpdateRec
            // 
            this.labelUpdateRec.AutoSize = true;
            this.labelUpdateRec.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateRec.ForeColor = System.Drawing.Color.White;
            this.labelUpdateRec.Location = new System.Drawing.Point(12, 9);
            this.labelUpdateRec.Name = "labelUpdateRec";
            this.labelUpdateRec.Size = new System.Drawing.Size(221, 29);
            this.labelUpdateRec.TabIndex = 1;
            this.labelUpdateRec.Text = "Обновление записи";
            this.labelUpdateRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelUpdateRec_MouseDown);
            this.labelUpdateRec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelUpdateRec_MouseMove);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(13, 598);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(294, 41);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Обновить запись";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeWinButton
            // 
            this.closeWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeWinButton.ForeColor = System.Drawing.Color.White;
            this.closeWinButton.Location = new System.Drawing.Point(13, 645);
            this.closeWinButton.Name = "closeWinButton";
            this.closeWinButton.Size = new System.Drawing.Size(294, 41);
            this.closeWinButton.TabIndex = 15;
            this.closeWinButton.Text = "Закрыть окно";
            this.closeWinButton.UseVisualStyleBackColor = false;
            this.closeWinButton.Click += new System.EventHandler(this.closeWinButton_Click);
            // 
            // descprobBox
            // 
            this.descprobBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descprobBox.Location = new System.Drawing.Point(343, 101);
            this.descprobBox.Multiline = true;
            this.descprobBox.Name = "descprobBox";
            this.descprobBox.Size = new System.Drawing.Size(332, 585);
            this.descprobBox.TabIndex = 31;
            // 
            // labelShoeStatus
            // 
            this.labelShoeStatus.AutoSize = true;
            this.labelShoeStatus.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShoeStatus.ForeColor = System.Drawing.Color.White;
            this.labelShoeStatus.Location = new System.Drawing.Point(12, 357);
            this.labelShoeStatus.Name = "labelShoeStatus";
            this.labelShoeStatus.Size = new System.Drawing.Size(151, 29);
            this.labelShoeStatus.TabIndex = 43;
            this.labelShoeStatus.Text = "Статус обуви";
            // 
            // numuserBox
            // 
            this.numuserBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numuserBox.Location = new System.Drawing.Point(12, 245);
            this.numuserBox.Name = "numuserBox";
            this.numuserBox.Size = new System.Drawing.Size(294, 37);
            this.numuserBox.TabIndex = 32;
            // 
            // mastercomBox
            // 
            this.mastercomBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mastercomBox.Location = new System.Drawing.Point(712, 101);
            this.mastercomBox.Multiline = true;
            this.mastercomBox.Name = "mastercomBox";
            this.mastercomBox.Size = new System.Drawing.Size(332, 585);
            this.mastercomBox.TabIndex = 33;
            // 
            // labelDateReg
            // 
            this.labelDateReg.AutoSize = true;
            this.labelDateReg.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateReg.ForeColor = System.Drawing.Color.White;
            this.labelDateReg.Location = new System.Drawing.Point(13, 69);
            this.labelDateReg.Name = "labelDateReg";
            this.labelDateReg.Size = new System.Drawing.Size(203, 29);
            this.labelDateReg.TabIndex = 34;
            this.labelDateReg.Text = "Дата регистрации";
            // 
            // labelDateComp
            // 
            this.labelDateComp.AutoSize = true;
            this.labelDateComp.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDateComp.ForeColor = System.Drawing.Color.White;
            this.labelDateComp.Location = new System.Drawing.Point(12, 141);
            this.labelDateComp.Name = "labelDateComp";
            this.labelDateComp.Size = new System.Drawing.Size(183, 29);
            this.labelDateComp.TabIndex = 35;
            this.labelDateComp.Text = "Дата окончания";
            // 
            // labelNumUser
            // 
            this.labelNumUser.AutoSize = true;
            this.labelNumUser.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumUser.ForeColor = System.Drawing.Color.White;
            this.labelNumUser.Location = new System.Drawing.Point(12, 213);
            this.labelNumUser.Name = "labelNumUser";
            this.labelNumUser.Size = new System.Drawing.Size(234, 29);
            this.labelNumUser.TabIndex = 36;
            this.labelNumUser.Text = "Номер пользователя";
            // 
            // labelDescProb
            // 
            this.labelDescProb.AutoSize = true;
            this.labelDescProb.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescProb.ForeColor = System.Drawing.Color.White;
            this.labelDescProb.Location = new System.Drawing.Point(343, 69);
            this.labelDescProb.Name = "labelDescProb";
            this.labelDescProb.Size = new System.Drawing.Size(230, 29);
            this.labelDescProb.TabIndex = 37;
            this.labelDescProb.Text = "Описание проблемы";
            // 
            // labelMasterCom
            // 
            this.labelMasterCom.AutoSize = true;
            this.labelMasterCom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMasterCom.ForeColor = System.Drawing.Color.White;
            this.labelMasterCom.Location = new System.Drawing.Point(712, 69);
            this.labelMasterCom.Name = "labelMasterCom";
            this.labelMasterCom.Size = new System.Drawing.Size(194, 29);
            this.labelMasterCom.TabIndex = 38;
            this.labelMasterCom.Text = "Заметки мастера";
            // 
            // masterBox
            // 
            this.masterBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masterBox.FormattingEnabled = true;
            this.masterBox.Items.AddRange(new object[] {
            "Горцев И.И",
            "Голубев В.И"});
            this.masterBox.Location = new System.Drawing.Point(12, 317);
            this.masterBox.Name = "masterBox";
            this.masterBox.Size = new System.Drawing.Size(294, 37);
            this.masterBox.TabIndex = 40;
            this.masterBox.SelectedIndexChanged += new System.EventHandler(this.masterBox_SelectedIndexChanged);
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaster.ForeColor = System.Drawing.Color.White;
            this.labelMaster.Location = new System.Drawing.Point(12, 285);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(93, 29);
            this.labelMaster.TabIndex = 41;
            this.labelMaster.Text = "Мастер";
            // 
            // shoestatBox
            // 
            this.shoestatBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoestatBox.FormattingEnabled = true;
            this.shoestatBox.Items.AddRange(new object[] {
            "Осмотр",
            "На ремонте",
            "Ремонт окончен"});
            this.shoestatBox.Location = new System.Drawing.Point(12, 389);
            this.shoestatBox.Name = "shoestatBox";
            this.shoestatBox.Size = new System.Drawing.Size(294, 37);
            this.shoestatBox.TabIndex = 42;
            this.shoestatBox.SelectedIndexChanged += new System.EventHandler(this.shoestatBox_SelectedIndexChanged);
            // 
            // dateregBox
            // 
            this.dateregBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateregBox.Location = new System.Drawing.Point(12, 104);
            this.dateregBox.Mask = "0000-00-00";
            this.dateregBox.Name = "dateregBox";
            this.dateregBox.Size = new System.Drawing.Size(117, 37);
            this.dateregBox.TabIndex = 45;
            // 
            // datecompBox
            // 
            this.datecompBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.datecompBox.Location = new System.Drawing.Point(13, 173);
            this.datecompBox.Mask = "0000-00-00";
            this.datecompBox.Name = "datecompBox";
            this.datecompBox.Size = new System.Drawing.Size(117, 37);
            this.datecompBox.TabIndex = 46;
            // 
            // UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1072, 698);
            this.Controls.Add(this.datecompBox);
            this.Controls.Add(this.dateregBox);
            this.Controls.Add(this.labelShoeStatus);
            this.Controls.Add(this.shoestatBox);
            this.Controls.Add(this.labelMaster);
            this.Controls.Add(this.masterBox);
            this.Controls.Add(this.labelMasterCom);
            this.Controls.Add(this.labelDescProb);
            this.Controls.Add(this.labelNumUser);
            this.Controls.Add(this.labelDateComp);
            this.Controls.Add(this.labelDateReg);
            this.Controls.Add(this.mastercomBox);
            this.Controls.Add(this.numuserBox);
            this.Controls.Add(this.descprobBox);
            this.Controls.Add(this.closeWinButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.labelUpdateRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRecord";
            this.Load += new System.EventHandler(this.UpdateRecord_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateRecord_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateRecord_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateRec;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeWinButton;
        private System.Windows.Forms.TextBox descprobBox;
        private System.Windows.Forms.Label labelShoeStatus;
        private System.Windows.Forms.TextBox numuserBox;
        private System.Windows.Forms.TextBox mastercomBox;
        private System.Windows.Forms.Label labelDateReg;
        private System.Windows.Forms.Label labelDateComp;
        private System.Windows.Forms.Label labelNumUser;
        private System.Windows.Forms.Label labelDescProb;
        private System.Windows.Forms.Label labelMasterCom;
        private System.Windows.Forms.ComboBox masterBox;
        private System.Windows.Forms.Label labelMaster;
        private System.Windows.Forms.ComboBox shoestatBox;
        private System.Windows.Forms.MaskedTextBox dateregBox;
        private System.Windows.Forms.ToolTip toolTipDateCheck;
        private System.Windows.Forms.MaskedTextBox datecompBox;
    }
}