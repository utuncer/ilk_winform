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
            this.SuspendLayout();
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(1093, 416);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.Click += new System.EventHandler(this.mainform_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstbutton;
    }
}

