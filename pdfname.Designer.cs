namespace Invoice
{
    partial class pdfname
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
            this.textBoxPdfName = new System.Windows.Forms.TextBox();
            this.labelNamePdf = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.Label();
            this.savePdfName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPdfName
            // 
            this.textBoxPdfName.Location = new System.Drawing.Point(58, 37);
            this.textBoxPdfName.MaximumSize = new System.Drawing.Size(200, 200);
            this.textBoxPdfName.MinimumSize = new System.Drawing.Size(150, 30);
            this.textBoxPdfName.Name = "textBoxPdfName";
            this.textBoxPdfName.Size = new System.Drawing.Size(200, 30);
            this.textBoxPdfName.TabIndex = 0;
            // 
            // labelNamePdf
            // 
            this.labelNamePdf.AutoSize = true;
            this.labelNamePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNamePdf.Location = new System.Drawing.Point(102, 9);
            this.labelNamePdf.Name = "labelNamePdf";
            this.labelNamePdf.Size = new System.Drawing.Size(128, 25);
            this.labelNamePdf.TabIndex = 1;
            this.labelNamePdf.Text = "Zapisz jako:";
            // 
            // pdf
            // 
            this.pdf.AutoSize = true;
            this.pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdf.Location = new System.Drawing.Point(264, 39);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(48, 25);
            this.pdf.TabIndex = 2;
            this.pdf.Text = ".pdf";
            // 
            // savePdfName
            // 
            this.savePdfName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.savePdfName.Location = new System.Drawing.Point(131, 73);
            this.savePdfName.Name = "savePdfName";
            this.savePdfName.Size = new System.Drawing.Size(75, 23);
            this.savePdfName.TabIndex = 3;
            this.savePdfName.Text = "Zapisz";
            this.savePdfName.UseVisualStyleBackColor = true;
          /*  this.savePdfName.Click += new System.EventHandler(this.savePdfName_Click);*/
            // 
            // pdfname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 107);
            this.Controls.Add(this.savePdfName);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.labelNamePdf);
            this.Controls.Add(this.textBoxPdfName);
            this.Name = "pdfname";
            this.Text = "pdfname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNamePdf;
        private System.Windows.Forms.Label pdf;
        public System.Windows.Forms.TextBox textBoxPdfName;
        private System.Windows.Forms.Button savePdfName;
    }
}