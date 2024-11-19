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
            this.soyadBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soyadBox
            // 
            this.soyadBox.Location = new System.Drawing.Point(168, 59);
            this.soyadBox.Name = "soyadBox";
            this.soyadBox.Size = new System.Drawing.Size(100, 22);
            this.soyadBox.TabIndex = 0;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(42, 59);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(100, 22);
            this.adBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // mainform
            // 
            this.ClientSize = new System.Drawing.Size(1093, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.soyadBox);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.Click += new System.EventHandler(this.mainform_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox soyadBox;
        public System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.Button button1;
    }
}

