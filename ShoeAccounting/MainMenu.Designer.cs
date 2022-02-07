namespace ShoeAccounting
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.labelFName = new System.Windows.Forms.Label();
            this.panelForMainMenu = new System.Windows.Forms.Panel();
            this.panelWithButtons = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenNewUserWinButton = new System.Windows.Forms.Button();
            this.OpenUpdateWinButton = new System.Windows.Forms.Button();
            this.OpenDeleteWinButton = new System.Windows.Forms.Button();
            this.OpenInsertWinButton = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.flowLayoutPanelShoeAccounting = new System.Windows.Forms.FlowLayoutPanel();
            this.labelForAdmin = new System.Windows.Forms.Label();
            this.shoeField1 = new ShoeAccounting.ShoeField();
            this.panelForMainMenu.SuspendLayout();
            this.panelWithButtons.SuspendLayout();
            this.flowLayoutPanelShoeAccounting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFName.ForeColor = System.Drawing.Color.White;
            this.labelFName.Location = new System.Drawing.Point(365, 9);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(299, 29);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "Приветствие пользователя";
            this.labelFName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFName_MouseDown);
            this.labelFName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFName_MouseMove);
            // 
            // panelForMainMenu
            // 
            this.panelForMainMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelForMainMenu.Controls.Add(this.panelWithButtons);
            this.panelForMainMenu.Controls.Add(this.labelMainMenu);
            this.panelForMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelForMainMenu.Name = "panelForMainMenu";
            this.panelForMainMenu.Size = new System.Drawing.Size(359, 667);
            this.panelForMainMenu.TabIndex = 1;
            this.panelForMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForMainMenu_MouseDown);
            this.panelForMainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelForMainMenu_MouseMove);
            // 
            // panelWithButtons
            // 
            this.panelWithButtons.Controls.Add(this.ExitButton);
            this.panelWithButtons.Controls.Add(this.OpenNewUserWinButton);
            this.panelWithButtons.Controls.Add(this.OpenUpdateWinButton);
            this.panelWithButtons.Controls.Add(this.OpenDeleteWinButton);
            this.panelWithButtons.Controls.Add(this.OpenInsertWinButton);
            this.panelWithButtons.Location = new System.Drawing.Point(12, 68);
            this.panelWithButtons.Name = "panelWithButtons";
            this.panelWithButtons.Size = new System.Drawing.Size(331, 587);
            this.panelWithButtons.TabIndex = 3;
            this.panelWithButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWithButtons_MouseDown);
            this.panelWithButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelWithButtons_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 544);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(331, 41);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход из приложения";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenNewUserWinButton
            // 
            this.OpenNewUserWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenNewUserWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenNewUserWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenNewUserWinButton.Location = new System.Drawing.Point(0, 141);
            this.OpenNewUserWinButton.Name = "OpenNewUserWinButton";
            this.OpenNewUserWinButton.Size = new System.Drawing.Size(331, 41);
            this.OpenNewUserWinButton.TabIndex = 10;
            this.OpenNewUserWinButton.Text = "Добавить пользователя";
            this.OpenNewUserWinButton.UseVisualStyleBackColor = false;
            this.OpenNewUserWinButton.Click += new System.EventHandler(this.OpenNewUserWinButton_Click);
            // 
            // OpenUpdateWinButton
            // 
            this.OpenUpdateWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenUpdateWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenUpdateWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenUpdateWinButton.Location = new System.Drawing.Point(0, 94);
            this.OpenUpdateWinButton.Name = "OpenUpdateWinButton";
            this.OpenUpdateWinButton.Size = new System.Drawing.Size(331, 41);
            this.OpenUpdateWinButton.TabIndex = 9;
            this.OpenUpdateWinButton.Text = "Обновить запись";
            this.OpenUpdateWinButton.UseVisualStyleBackColor = false;
            this.OpenUpdateWinButton.Click += new System.EventHandler(this.OpenUpdateWinButton_Click);
            // 
            // OpenDeleteWinButton
            // 
            this.OpenDeleteWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenDeleteWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenDeleteWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenDeleteWinButton.Location = new System.Drawing.Point(0, 47);
            this.OpenDeleteWinButton.Name = "OpenDeleteWinButton";
            this.OpenDeleteWinButton.Size = new System.Drawing.Size(331, 41);
            this.OpenDeleteWinButton.TabIndex = 8;
            this.OpenDeleteWinButton.Text = "Удалить запись";
            this.OpenDeleteWinButton.UseVisualStyleBackColor = false;
            this.OpenDeleteWinButton.Click += new System.EventHandler(this.OpenDeleteWinButton_Click);
            // 
            // OpenInsertWinButton
            // 
            this.OpenInsertWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenInsertWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenInsertWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenInsertWinButton.Location = new System.Drawing.Point(0, 0);
            this.OpenInsertWinButton.Name = "OpenInsertWinButton";
            this.OpenInsertWinButton.Size = new System.Drawing.Size(331, 41);
            this.OpenInsertWinButton.TabIndex = 7;
            this.OpenInsertWinButton.Text = "Добавить запись";
            this.OpenInsertWinButton.UseVisualStyleBackColor = false;
            this.OpenInsertWinButton.Click += new System.EventHandler(this.OpenInsertWinButton_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMainMenu.ForeColor = System.Drawing.Color.White;
            this.labelMainMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(161, 29);
            this.labelMainMenu.TabIndex = 2;
            this.labelMainMenu.Text = "Главное меню";
            this.labelMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMainMenu_MouseDown);
            this.labelMainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMainMenu_MouseMove);
            // 
            // flowLayoutPanelShoeAccounting
            // 
            this.flowLayoutPanelShoeAccounting.Controls.Add(this.shoeField1);
            this.flowLayoutPanelShoeAccounting.Location = new System.Drawing.Point(365, 115);
            this.flowLayoutPanelShoeAccounting.Name = "flowLayoutPanelShoeAccounting";
            this.flowLayoutPanelShoeAccounting.Size = new System.Drawing.Size(972, 540);
            this.flowLayoutPanelShoeAccounting.TabIndex = 2;
            // 
            // labelForAdmin
            // 
            this.labelForAdmin.AutoSize = true;
            this.labelForAdmin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForAdmin.ForeColor = System.Drawing.Color.White;
            this.labelForAdmin.Location = new System.Drawing.Point(1157, 9);
            this.labelForAdmin.Name = "labelForAdmin";
            this.labelForAdmin.Size = new System.Drawing.Size(180, 29);
            this.labelForAdmin.TabIndex = 3;
            this.labelForAdmin.Text = "Администратор";
            this.labelForAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelForAdmin_MouseDown);
            this.labelForAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelForAdmin_MouseMove);
            // 
            // shoeField1
            // 
            this.shoeField1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.shoeField1.DATECOMPLETION = null;
            this.shoeField1.DATEREGISTRATION = null;
            this.shoeField1.Location = new System.Drawing.Point(3, 3);
            this.shoeField1.Name = "shoeField1";
            this.shoeField1.NUMBER = null;
            this.shoeField1.Size = new System.Drawing.Size(950, 245);
            this.shoeField1.STATUSSHOE = null;
            this.shoeField1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1349, 667);
            this.Controls.Add(this.labelForAdmin);
            this.Controls.Add(this.flowLayoutPanelShoeAccounting);
            this.Controls.Add(this.panelForMainMenu);
            this.Controls.Add(this.labelFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.panelForMainMenu.ResumeLayout(false);
            this.panelForMainMenu.PerformLayout();
            this.panelWithButtons.ResumeLayout(false);
            this.flowLayoutPanelShoeAccounting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Panel panelForMainMenu;
        private System.Windows.Forms.Panel panelWithButtons;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenNewUserWinButton;
        private System.Windows.Forms.Button OpenUpdateWinButton;
        private System.Windows.Forms.Button OpenDeleteWinButton;
        private System.Windows.Forms.Button OpenInsertWinButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShoeAccounting;
        private System.Windows.Forms.Label labelForAdmin;
        private ShoeField shoeField1;
    }
}