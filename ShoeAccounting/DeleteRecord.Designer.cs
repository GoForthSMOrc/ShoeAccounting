namespace ShoeAccounting
{
    partial class DeleteRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecord));
            this.labelDeleteRec = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeWinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeleteRec
            // 
            this.labelDeleteRec.AutoSize = true;
            this.labelDeleteRec.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeleteRec.ForeColor = System.Drawing.Color.White;
            this.labelDeleteRec.Location = new System.Drawing.Point(12, 9);
            this.labelDeleteRec.Name = "labelDeleteRec";
            this.labelDeleteRec.Size = new System.Drawing.Size(190, 29);
            this.labelDeleteRec.TabIndex = 0;
            this.labelDeleteRec.Text = "Удаление записи";
            this.labelDeleteRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDeleteRec_MouseDown);
            this.labelDeleteRec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelDeleteRec_MouseMove);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(188, 329);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(294, 41);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // closeWinButton
            // 
            this.closeWinButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeWinButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeWinButton.ForeColor = System.Drawing.Color.White;
            this.closeWinButton.Location = new System.Drawing.Point(188, 376);
            this.closeWinButton.Name = "closeWinButton";
            this.closeWinButton.Size = new System.Drawing.Size(294, 41);
            this.closeWinButton.TabIndex = 14;
            this.closeWinButton.Text = "Закрыть окно";
            this.closeWinButton.UseVisualStyleBackColor = false;
            this.closeWinButton.Click += new System.EventHandler(this.closeWinButton_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(653, 421);
            this.Controls.Add(this.closeWinButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelDeleteRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteRecord_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteRecord_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteRec;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeWinButton;
    }
}