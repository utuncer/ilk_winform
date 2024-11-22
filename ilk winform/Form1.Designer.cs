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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayiKaresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayiKup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sayi,
            this.sayiKaresi,
            this.sayiKup});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // sayi
            // 
            resources.ApplyResources(this.sayi, "sayi");
            this.sayi.Name = "sayi";
            // 
            // sayiKaresi
            // 
            resources.ApplyResources(this.sayiKaresi, "sayiKaresi");
            this.sayiKaresi.Name = "sayiKaresi";
            // 
            // sayiKup
            // 
            resources.ApplyResources(this.sayiKup, "sayiKup");
            this.sayiKup.Name = "sayiKup";
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "mainform";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayiKaresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayiKup;
        private System.Windows.Forms.Button button1;
    }
}

