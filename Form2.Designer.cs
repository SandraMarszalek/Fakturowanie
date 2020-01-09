namespace Invoice
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
            this.button1 = new System.Windows.Forms.Button();
            this.newClientName = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.postalCode = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.NIPtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newClientName
            // 
            this.newClientName.AutoSize = true;
            this.newClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newClientName.Location = new System.Drawing.Point(174, 60);
            this.newClientName.Name = "newClientName";
            this.newClientName.Size = new System.Drawing.Size(57, 20);
            this.newClientName.TabIndex = 1;
            this.newClientName.Text = "Nazwa";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adress.Location = new System.Drawing.Point(174, 133);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(51, 20);
            this.adress.TabIndex = 2;
            this.adress.Text = "Adres";
            // 
            // postalCode
            // 
            this.postalCode.AutoSize = true;
            this.postalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postalCode.Location = new System.Drawing.Point(174, 216);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(107, 20);
            this.postalCode.TabIndex = 3;
            this.postalCode.Text = "Kod pocztowy";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.City.Location = new System.Drawing.Point(175, 261);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(56, 20);
            this.City.TabIndex = 4;
            this.City.Text = "Miasto";
            // 
            // NIP
            // 
            this.NIP.AutoSize = true;
            this.NIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NIP.Location = new System.Drawing.Point(175, 304);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(35, 20);
            this.NIP.TabIndex = 5;
            this.NIP.Text = "NIP";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(343, 62);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameTextBox.Size = new System.Drawing.Size(200, 67);
            this.nameTextBox.TabIndex = 6;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(343, 135);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adressTextBox.Size = new System.Drawing.Size(200, 61);
            this.adressTextBox.TabIndex = 7;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(343, 218);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(343, 261);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 9;
            // 
            // NIPtextBox
            // 
            this.NIPtextBox.Location = new System.Drawing.Point(343, 304);
            this.NIPtextBox.Name = "NIPtextBox";
            this.NIPtextBox.Size = new System.Drawing.Size(200, 20);
            this.NIPtextBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NIPtextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.City);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.newClientName);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Dodaj nowego klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newClientName;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label postalCode;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label NIP;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox NIPtextBox;
    }
}