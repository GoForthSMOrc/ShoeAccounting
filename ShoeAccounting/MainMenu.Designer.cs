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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenUpdateWinButton = new System.Windows.Forms.Button();
            this.OpenDeleteWinButton = new System.Windows.Forms.Button();
            this.OpenNewUserWinButton = new System.Windows.Forms.Button();
            this.OpenInsertWinButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelShoeAccounting = new System.Windows.Forms.FlowLayoutPanel();
            this.shoeField1 = new ShoeAccounting.ShoeField();
            this.labelForAdmin = new System.Windows.Forms.Label();
            this.findBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForMainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanelShoeAccounting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFName.ForeColor = System.Drawing.Color.White;
            this.labelFName.Location = new System.Drawing.Point(0, 40);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(990, 29);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "Приветствие пользователя";
            this.labelFName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFName_MouseDown);
            // 
            // panelForMainMenu
            // 
            this.panelForMainMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelForMainMenu.Controls.Add(this.panel2);
            this.panelForMainMenu.Controls.Add(this.RefreshListButton);
            this.panelForMainMenu.Controls.Add(this.ExitButton);
            this.panelForMainMenu.Controls.Add(this.OpenUpdateWinButton);
            this.panelForMainMenu.Controls.Add(this.OpenDeleteWinButton);
            this.panelForMainMenu.Controls.Add(this.OpenNewUserWinButton);
            this.panelForMainMenu.Controls.Add(this.OpenInsertWinButton);
            this.panelForMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelForMainMenu.Name = "panelForMainMenu";
            this.panelForMainMenu.Size = new System.Drawing.Size(359, 667);
            this.panelForMainMenu.TabIndex = 1;
            this.panelForMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForMainMenu_MouseDown);
            this.panelForMainMenu.MouseEnter += new System.EventHandler(this.panelForMainMenu_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMainMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 132);
            this.panel2.TabIndex = 13;
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMainMenu.ForeColor = System.Drawing.Color.White;
            this.labelMainMenu.Location = new System.Drawing.Point(3, 9);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(161, 29);
            this.labelMainMenu.TabIndex = 2;
            this.labelMainMenu.Text = "Главное меню";
            this.labelMainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMainMenu_MouseDown);
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RefreshListButton.FlatAppearance.BorderSize = 0;
            this.RefreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshListButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshListButton.ForeColor = System.Drawing.Color.White;
            this.RefreshListButton.Location = new System.Drawing.Point(0, 138);
            this.RefreshListButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.RefreshListButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(359, 60);
            this.RefreshListButton.TabIndex = 12;
            this.RefreshListButton.Text = "Обновить список";
            this.RefreshListButton.UseVisualStyleBackColor = false;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 607);
            this.ExitButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.ExitButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(359, 60);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход из приложения";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenUpdateWinButton
            // 
            this.OpenUpdateWinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenUpdateWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenUpdateWinButton.FlatAppearance.BorderSize = 0;
            this.OpenUpdateWinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenUpdateWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenUpdateWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenUpdateWinButton.Location = new System.Drawing.Point(0, 330);
            this.OpenUpdateWinButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.OpenUpdateWinButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.OpenUpdateWinButton.Name = "OpenUpdateWinButton";
            this.OpenUpdateWinButton.Size = new System.Drawing.Size(359, 60);
            this.OpenUpdateWinButton.TabIndex = 9;
            this.OpenUpdateWinButton.Text = "Обновить запись";
            this.OpenUpdateWinButton.UseVisualStyleBackColor = false;
            this.OpenUpdateWinButton.Click += new System.EventHandler(this.OpenUpdateWinButton_Click);
            // 
            // OpenDeleteWinButton
            // 
            this.OpenDeleteWinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDeleteWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenDeleteWinButton.FlatAppearance.BorderSize = 0;
            this.OpenDeleteWinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDeleteWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenDeleteWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenDeleteWinButton.Location = new System.Drawing.Point(0, 270);
            this.OpenDeleteWinButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.OpenDeleteWinButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.OpenDeleteWinButton.Name = "OpenDeleteWinButton";
            this.OpenDeleteWinButton.Size = new System.Drawing.Size(359, 60);
            this.OpenDeleteWinButton.TabIndex = 8;
            this.OpenDeleteWinButton.Text = "Удалить запись";
            this.OpenDeleteWinButton.UseVisualStyleBackColor = false;
            this.OpenDeleteWinButton.Click += new System.EventHandler(this.OpenDeleteWinButton_Click);
            // 
            // OpenNewUserWinButton
            // 
            this.OpenNewUserWinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenNewUserWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenNewUserWinButton.FlatAppearance.BorderSize = 0;
            this.OpenNewUserWinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenNewUserWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenNewUserWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenNewUserWinButton.Location = new System.Drawing.Point(0, 396);
            this.OpenNewUserWinButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.OpenNewUserWinButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.OpenNewUserWinButton.Name = "OpenNewUserWinButton";
            this.OpenNewUserWinButton.Size = new System.Drawing.Size(359, 60);
            this.OpenNewUserWinButton.TabIndex = 10;
            this.OpenNewUserWinButton.Text = "Добавить пользователя";
            this.OpenNewUserWinButton.UseVisualStyleBackColor = false;
            this.OpenNewUserWinButton.Click += new System.EventHandler(this.OpenNewUserWinButton_Click);
            // 
            // OpenInsertWinButton
            // 
            this.OpenInsertWinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenInsertWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpenInsertWinButton.FlatAppearance.BorderSize = 0;
            this.OpenInsertWinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenInsertWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenInsertWinButton.ForeColor = System.Drawing.Color.White;
            this.OpenInsertWinButton.Location = new System.Drawing.Point(0, 204);
            this.OpenInsertWinButton.MaximumSize = new System.Drawing.Size(359, 60);
            this.OpenInsertWinButton.MinimumSize = new System.Drawing.Size(359, 60);
            this.OpenInsertWinButton.Name = "OpenInsertWinButton";
            this.OpenInsertWinButton.Size = new System.Drawing.Size(359, 60);
            this.OpenInsertWinButton.TabIndex = 7;
            this.OpenInsertWinButton.Text = "Добавить запись";
            this.OpenInsertWinButton.UseVisualStyleBackColor = false;
            this.OpenInsertWinButton.Click += new System.EventHandler(this.OpenInsertWinButton_Click);
            // 
            // flowLayoutPanelShoeAccounting
            // 
            this.flowLayoutPanelShoeAccounting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelShoeAccounting.AutoScroll = true;
            this.flowLayoutPanelShoeAccounting.Controls.Add(this.shoeField1);
            this.flowLayoutPanelShoeAccounting.Location = new System.Drawing.Point(365, 115);
            this.flowLayoutPanelShoeAccounting.Name = "flowLayoutPanelShoeAccounting";
            this.flowLayoutPanelShoeAccounting.Size = new System.Drawing.Size(972, 540);
            this.flowLayoutPanelShoeAccounting.TabIndex = 2;
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
            this.shoeField1.Load += new System.EventHandler(this.shoeField1_Load);
            // 
            // labelForAdmin
            // 
            this.labelForAdmin.AutoSize = true;
            this.labelForAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelForAdmin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForAdmin.ForeColor = System.Drawing.Color.White;
            this.labelForAdmin.Location = new System.Drawing.Point(810, 0);
            this.labelForAdmin.Name = "labelForAdmin";
            this.labelForAdmin.Size = new System.Drawing.Size(180, 29);
            this.labelForAdmin.TabIndex = 3;
            this.labelForAdmin.Text = "Администратор";
            this.labelForAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelForAdmin_MouseDown);
            // 
            // findBox
            // 
            this.findBox.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findBox.Location = new System.Drawing.Point(3, 72);
            this.findBox.MaximumSize = new System.Drawing.Size(345, 37);
            this.findBox.MinimumSize = new System.Drawing.Size(345, 37);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(345, 37);
            this.findBox.TabIndex = 4;
            this.findBox.Text = " Поиск по номеру";
            this.findBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.findBox_MouseClick);
            this.findBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelForAdmin);
            this.panel1.Controls.Add(this.findBox);
            this.panel1.Controls.Add(this.labelFName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 112);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1349, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelShoeAccounting);
            this.Controls.Add(this.panelForMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.panelForMainMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanelShoeAccounting.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Panel panelForMainMenu;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenNewUserWinButton;
        private System.Windows.Forms.Button OpenUpdateWinButton;
        private System.Windows.Forms.Button OpenDeleteWinButton;
        private System.Windows.Forms.Button OpenInsertWinButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShoeAccounting;
        private System.Windows.Forms.Label labelForAdmin;
        private ShoeField shoeField1;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}