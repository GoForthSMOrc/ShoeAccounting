namespace ShoeAccounting
{
    partial class ExitConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitConfirmation));
            this.panelExitConfirmation = new System.Windows.Forms.Panel();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.labelExitConfirmation = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.panelExitConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExitConfirmation
            // 
            this.panelExitConfirmation.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelExitConfirmation.Controls.Add(this.panelLine2);
            this.panelExitConfirmation.Controls.Add(this.labelExitConfirmation);
            this.panelExitConfirmation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExitConfirmation.Location = new System.Drawing.Point(0, 0);
            this.panelExitConfirmation.Name = "panelExitConfirmation";
            this.panelExitConfirmation.Size = new System.Drawing.Size(393, 82);
            this.panelExitConfirmation.TabIndex = 0;
            this.panelExitConfirmation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelExitConfirmation_Paint);
            this.panelExitConfirmation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelExitConfirmation_MouseDown);
            this.panelExitConfirmation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelExitConfirmation_MouseMove);
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLine2.Location = new System.Drawing.Point(0, 77);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(394, 5);
            this.panelLine2.TabIndex = 3;
            this.panelLine2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLine2_MouseDown);
            this.panelLine2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLine2_MouseMove);
            // 
            // labelExitConfirmation
            // 
            this.labelExitConfirmation.AutoSize = true;
            this.labelExitConfirmation.BackColor = System.Drawing.Color.DarkMagenta;
            this.labelExitConfirmation.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExitConfirmation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExitConfirmation.Location = new System.Drawing.Point(66, 26);
            this.labelExitConfirmation.Name = "labelExitConfirmation";
            this.labelExitConfirmation.Size = new System.Drawing.Size(265, 29);
            this.labelExitConfirmation.TabIndex = 1;
            this.labelExitConfirmation.Text = "Вы точно хотите выйти?";
            this.labelExitConfirmation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExitConfirmation_MouseDown);
            this.labelExitConfirmation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelExitConfirmation_MouseMove);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.yesButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesButton.ForeColor = System.Drawing.Color.White;
            this.yesButton.Location = new System.Drawing.Point(12, 93);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(115, 59);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // notButton
            // 
            this.notButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.notButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notButton.ForeColor = System.Drawing.Color.White;
            this.notButton.Location = new System.Drawing.Point(266, 93);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(115, 59);
            this.notButton.TabIndex = 2;
            this.notButton.Text = "Нет";
            this.notButton.UseVisualStyleBackColor = false;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // ExitConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(393, 164);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.panelExitConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitConfirmation";
            this.Load += new System.EventHandler(this.ExitConfirmation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitConfirmation_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitConfirmation_MouseMove);
            this.panelExitConfirmation.ResumeLayout(false);
            this.panelExitConfirmation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExitConfirmation;
        private System.Windows.Forms.Label labelExitConfirmation;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Panel panelLine2;
    }
}