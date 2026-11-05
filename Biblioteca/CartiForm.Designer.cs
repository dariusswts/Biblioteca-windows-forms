namespace Biblioteca
{
    partial class CartiForm
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
            this.lstCarti = new System.Windows.Forms.ListBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lblStare = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCarti
            // 
            this.lstCarti.FormattingEnabled = true;
            this.lstCarti.Location = new System.Drawing.Point(307, 12);
            this.lstCarti.Name = "lstCarti";
            this.lstCarti.Size = new System.Drawing.Size(120, 95);
            this.lstCarti.TabIndex = 0;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(330, 113);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 1;
            this.btnAfiseaza.Text = "Afiseaza lista";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(466, 50);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(0, 13);
            this.lblStare.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CartiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lstCarti);
            this.Name = "CartiForm";
            this.Text = "CartiForm";
            this.Load += new System.EventHandler(this.CartiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarti;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.TextBox textBox1;
    }
}