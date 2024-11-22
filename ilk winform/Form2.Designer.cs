namespace ilk_winform
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId2
            // 
            this.txtId2.Enabled = false;
            this.txtId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId2.Location = new System.Drawing.Point(115, 30);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(123, 36);
            this.txtId2.TabIndex = 1;
            // 
            // txtName2
            // 
            this.txtName2.Enabled = false;
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName2.Location = new System.Drawing.Point(115, 115);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(123, 36);
            this.txtName2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtAge2
            // 
            this.txtAge2.Enabled = false;
            this.txtAge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAge2.Location = new System.Drawing.Point(115, 200);
            this.txtAge2.Name = "txtAge2";
            this.txtAge2.Size = new System.Drawing.Size(123, 36);
            this.txtAge2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 416);
            this.Controls.Add(this.txtAge2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge2;
        private System.Windows.Forms.Label label3;
    }
}