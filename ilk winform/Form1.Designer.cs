﻿namespace ilk_winform
{
    partial class mainform
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
            this.firstlabel = new System.Windows.Forms.Label();
            this.firstbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstlabel
            // 
            this.firstlabel.AutoSize = true;
            this.firstlabel.Location = new System.Drawing.Point(77, 106);
            this.firstlabel.Name = "firstlabel";
            this.firstlabel.Size = new System.Drawing.Size(44, 16);
            this.firstlabel.TabIndex = 0;
            this.firstlabel.Text = "label1";
            // 
            // firstbutton
            // 
            this.firstbutton.Location = new System.Drawing.Point(251, 89);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(75, 23);
            this.firstbutton.TabIndex = 1;
            this.firstbutton.Text = "button1";
            this.firstbutton.UseVisualStyleBackColor = true;
            this.firstbutton.Click += new System.EventHandler(this.firstbutton_Click);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(1093, 416);
            this.Controls.Add(this.firstbutton);
            this.Controls.Add(this.firstlabel);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.Click += new System.EventHandler(this.mainform_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstlabel;
        private System.Windows.Forms.Button firstbutton;
    }
}

