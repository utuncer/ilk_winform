namespace ilk_winform
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
            this.firstbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstbutton
            // 
            this.firstbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.firstbutton.Location = new System.Drawing.Point(65, 55);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(130, 49);
            this.firstbutton.TabIndex = 1;
            this.firstbutton.Text = "First";
            this.firstbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.firstbutton.UseVisualStyleBackColor = true;
            this.firstbutton.Click += new System.EventHandler(this.firstbutton_Click);
            this.firstbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstbutton_KeyDown);
            this.firstbutton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.firstbutton_PreviewKeyDown);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.firstbutton);
            this.DoubleBuffered = true;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainform_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstbutton;
    }
}

