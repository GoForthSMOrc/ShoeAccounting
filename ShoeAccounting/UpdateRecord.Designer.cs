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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRecord));
            this.labelUpdateRec = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeWinButton = new System.Windows.Forms.Button();
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
            this.updateButton.Location = new System.Drawing.Point(184, 351);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(294, 41);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Обновить запись";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // closeWinButton
            // 
            this.closeWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeWinButton.ForeColor = System.Drawing.Color.White;
            this.closeWinButton.Location = new System.Drawing.Point(184, 398);
            this.closeWinButton.Name = "closeWinButton";
            this.closeWinButton.Size = new System.Drawing.Size(294, 41);
            this.closeWinButton.TabIndex = 15;
            this.closeWinButton.Text = "Закрыть окно";
            this.closeWinButton.UseVisualStyleBackColor = false;
            this.closeWinButton.Click += new System.EventHandler(this.closeWinButton_Click);
            // 
            // UpdateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.closeWinButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.labelUpdateRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRecord";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateRecord_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateRecord_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateRec;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeWinButton;
    }
}