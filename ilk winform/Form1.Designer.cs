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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.btnFillList = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillList
            // 
            resources.ApplyResources(this.btnFillList, "btnFillList");
            this.btnFillList.Name = "btnFillList";
            this.btnFillList.UseVisualStyleBackColor = true;
            this.btnFillList.Click += new System.EventHandler(this.btnFillList_Click);
            // 
            // txtList
            // 
            resources.ApplyResources(this.txtList, "txtList");
            this.txtList.Name = "txtList";
            // 
            // cmbDays
            // 
            resources.ApplyResources(this.cmbDays, "cmbDays");
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnFillList);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillList;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

