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
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDivisibleTerm = new System.Windows.Forms.Label();
            this.cmBoxDivisibleTerm = new System.Windows.Forms.ComboBox();
            this.txtDivisibleNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ChItalic = new System.Windows.Forms.CheckBox();
            this.ChBold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            resources.ApplyResources(this.labelFrom, "labelFrom");
            this.labelFrom.Name = "labelFrom";
            // 
            // labelTo
            // 
            resources.ApplyResources(this.labelTo, "labelTo");
            this.labelTo.Name = "labelTo";
            // 
            // txtFrom
            // 
            resources.ApplyResources(this.txtFrom, "txtFrom");
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // txtTo
            // 
            resources.ApplyResources(this.txtTo, "txtTo");
            this.txtTo.Name = "txtTo";
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // buttonCount
            // 
            resources.ApplyResources(this.buttonCount, "buttonCount");
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDivisibleTerm
            // 
            resources.ApplyResources(this.labelDivisibleTerm, "labelDivisibleTerm");
            this.labelDivisibleTerm.Name = "labelDivisibleTerm";
            this.labelDivisibleTerm.Click += new System.EventHandler(this.labelDivisibleTerm_Click);
            // 
            // cmBoxDivisibleTerm
            // 
            this.cmBoxDivisibleTerm.FormattingEnabled = true;
            resources.ApplyResources(this.cmBoxDivisibleTerm, "cmBoxDivisibleTerm");
            this.cmBoxDivisibleTerm.Name = "cmBoxDivisibleTerm";
            this.cmBoxDivisibleTerm.SelectedIndexChanged += new System.EventHandler(this.cmBoxDivisibleTerm_SelectedIndexChanged);
            // 
            // txtDivisibleNumber
            // 
            resources.ApplyResources(this.txtDivisibleNumber, "txtDivisibleNumber");
            this.txtDivisibleNumber.Name = "txtDivisibleNumber";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // ChItalic
            // 
            resources.ApplyResources(this.ChItalic, "ChItalic");
            this.ChItalic.Name = "ChItalic";
            this.ChItalic.UseVisualStyleBackColor = true;
            this.ChItalic.CheckedChanged += new System.EventHandler(this.ChItalic_CheckedChanged);
            // 
            // ChBold
            // 
            resources.ApplyResources(this.ChBold, "ChBold");
            this.ChBold.Name = "ChBold";
            this.ChBold.UseVisualStyleBackColor = true;
            this.ChBold.CheckedChanged += new System.EventHandler(this.ChBold_CheckedChanged);
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ChBold);
            this.Controls.Add(this.ChItalic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDivisibleNumber);
            this.Controls.Add(this.cmBoxDivisibleTerm);
            this.Controls.Add(this.labelDivisibleTerm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDivisibleTerm;
        private System.Windows.Forms.ComboBox cmBoxDivisibleTerm;
        private System.Windows.Forms.TextBox txtDivisibleNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox ChBold;
        private System.Windows.Forms.CheckBox ChItalic;
    }
}

