﻿namespace SchoolSystem
{
    partial class PanelTestForm
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
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(284, 261);
            this.pnlTeacher.TabIndex = 0;
            // 
            // PanelTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlTeacher);
            this.Name = "PanelTestForm";
            this.Text = "PanelTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeacher;
    }
}