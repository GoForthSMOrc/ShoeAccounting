﻿namespace ShoeAccounting
{
    partial class DescriptionProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriptionProblem));
            this.labelExit = new System.Windows.Forms.Label();
            this.descrBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExit.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelExit.Location = new System.Drawing.Point(770, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(27, 29);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            this.labelExit.MouseHover += new System.EventHandler(this.labelExit_MouseHover);
            // 
            // descrBox
            // 
            this.descrBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.descrBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descrBox.ForeColor = System.Drawing.SystemColors.Window;
            this.descrBox.Location = new System.Drawing.Point(12, 9);
            this.descrBox.Multiline = true;
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(743, 429);
            this.descrBox.TabIndex = 2;
            // 
            // DescriptionProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descrBox);
            this.Controls.Add(this.labelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DescriptionProblem";
            this.Text = "DescriptionProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.TextBox descrBox;
    }
}