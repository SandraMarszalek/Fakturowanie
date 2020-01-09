namespace Invoice
{
    partial class Invoice
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Placeofsale = new System.Windows.Forms.Label();
            this.InvoiceIssuing = new System.Windows.Forms.Label();
            this.SaleDate = new System.Windows.Forms.Label();
            this.PlaceofsaleTextbox = new System.Windows.Forms.TextBox();
            this.DateTimeInvoiceIssuing = new System.Windows.Forms.DateTimePicker();
            this.DateTimeSaleDate = new System.Windows.Forms.DateTimePicker();
            this.InvoiceNr = new System.Windows.Forms.Label();
            this.TextBoxInvoiceNr = new System.Windows.Forms.TextBox();
            this.AdditionalInvoiceInfo = new System.Windows.Forms.CheckBox();
            this.TextBoxAdditionalInvoiceInfo = new System.Windows.Forms.TextBox();
            this.Seller = new System.Windows.Forms.Label();
            this.Buyer = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.ListBox();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CheckBoxOrderedBy = new System.Windows.Forms.CheckBox();
            this.TextBoxOrderedBy = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasure = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerArtWithVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceWithTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.FinalValuesDataGV = new System.Windows.Forms.DataGridView();
            this.ValueWithoutTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxRate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueWithTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDF = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.sellerTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDataSetOkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalMainInfoCheckbox = new System.Windows.Forms.CheckBox();
            this.AdditionalInfoTextbox = new System.Windows.Forms.TextBox();
            this.FinalValuesCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalValuesDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSetOkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet13BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Placeofsale
            // 
            this.Placeofsale.AutoSize = true;
            this.Placeofsale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Placeofsale.Location = new System.Drawing.Point(13, 32);
            this.Placeofsale.Name = "Placeofsale";
            this.Placeofsale.Size = new System.Drawing.Size(114, 15);
            this.Placeofsale.TabIndex = 0;
            this.Placeofsale.Text = "Miejsce wystawienia";
            // 
            // InvoiceIssuing
            // 
            this.InvoiceIssuing.AutoSize = true;
            this.InvoiceIssuing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvoiceIssuing.Location = new System.Drawing.Point(13, 61);
            this.InvoiceIssuing.Name = "InvoiceIssuing";
            this.InvoiceIssuing.Size = new System.Drawing.Size(98, 15);
            this.InvoiceIssuing.TabIndex = 1;
            this.InvoiceIssuing.Text = "Data wystawienia";
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSize = true;
            this.SaleDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaleDate.Location = new System.Drawing.Point(13, 90);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(85, 15);
            this.SaleDate.TabIndex = 2;
            this.SaleDate.Text = "Data sprzedaży";
            // 
            // PlaceofsaleTextbox
            // 
            this.PlaceofsaleTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlaceofsaleTextbox.Location = new System.Drawing.Point(132, 30);
            this.PlaceofsaleTextbox.Name = "PlaceofsaleTextbox";
            this.PlaceofsaleTextbox.Size = new System.Drawing.Size(150, 23);
            this.PlaceofsaleTextbox.TabIndex = 3;
            // 
            // DateTimeInvoiceIssuing
            // 
            this.DateTimeInvoiceIssuing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimeInvoiceIssuing.Location = new System.Drawing.Point(132, 59);
            this.DateTimeInvoiceIssuing.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimeInvoiceIssuing.Name = "DateTimeInvoiceIssuing";
            this.DateTimeInvoiceIssuing.Size = new System.Drawing.Size(150, 23);
            this.DateTimeInvoiceIssuing.TabIndex = 4;
            // 
            // DateTimeSaleDate
            // 
            this.DateTimeSaleDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimeSaleDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateTimeSaleDate.Location = new System.Drawing.Point(132, 88);
            this.DateTimeSaleDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimeSaleDate.Name = "DateTimeSaleDate";
            this.DateTimeSaleDate.Size = new System.Drawing.Size(150, 23);
            this.DateTimeSaleDate.TabIndex = 5;
            // 
            // InvoiceNr
            // 
            this.InvoiceNr.AutoSize = true;
            this.InvoiceNr.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvoiceNr.Location = new System.Drawing.Point(141, 132);
            this.InvoiceNr.Name = "InvoiceNr";
            this.InvoiceNr.Size = new System.Drawing.Size(196, 37);
            this.InvoiceNr.TabIndex = 6;
            this.InvoiceNr.Text = "Faktura VAT nr:";
            // 
            // TextBoxInvoiceNr
            // 
            this.TextBoxInvoiceNr.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxInvoiceNr.Location = new System.Drawing.Point(368, 134);
            this.TextBoxInvoiceNr.MaximumSize = new System.Drawing.Size(80, 40);
            this.TextBoxInvoiceNr.MinimumSize = new System.Drawing.Size(180, 40);
            this.TextBoxInvoiceNr.Name = "TextBoxInvoiceNr";
            this.TextBoxInvoiceNr.Size = new System.Drawing.Size(180, 40);
            this.TextBoxInvoiceNr.TabIndex = 7;
            // 
            // AdditionalInvoiceInfo
            // 
            this.AdditionalInvoiceInfo.AutoSize = true;
            this.AdditionalInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdditionalInvoiceInfo.Location = new System.Drawing.Point(148, 184);
            this.AdditionalInvoiceInfo.Name = "AdditionalInvoiceInfo";
            this.AdditionalInvoiceInfo.Size = new System.Drawing.Size(199, 21);
            this.AdditionalInvoiceInfo.TabIndex = 8;
            this.AdditionalInvoiceInfo.Text = "Na podstawie zamówienia nr:";
            this.AdditionalInvoiceInfo.UseVisualStyleBackColor = true;
            this.AdditionalInvoiceInfo.CheckedChanged += new System.EventHandler(this.additionalInvoiceInfo_CheckedChanged);
            // 
            // TextBoxAdditionalInvoiceInfo
            // 
            this.TextBoxAdditionalInvoiceInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxAdditionalInvoiceInfo.Location = new System.Drawing.Point(368, 184);
            this.TextBoxAdditionalInvoiceInfo.MaximumSize = new System.Drawing.Size(180, 25);
            this.TextBoxAdditionalInvoiceInfo.MinimumSize = new System.Drawing.Size(180, 25);
            this.TextBoxAdditionalInvoiceInfo.Name = "TextBoxAdditionalInvoiceInfo";
            this.TextBoxAdditionalInvoiceInfo.Size = new System.Drawing.Size(180, 25);
            this.TextBoxAdditionalInvoiceInfo.TabIndex = 9;
            this.TextBoxAdditionalInvoiceInfo.Visible = false;
            // 
            // Seller
            // 
            this.Seller.AutoSize = true;
            this.Seller.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Seller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Seller.Location = new System.Drawing.Point(118, 244);
            this.Seller.Name = "Seller";
            this.Seller.Size = new System.Drawing.Size(93, 21);
            this.Seller.TabIndex = 10;
            this.Seller.Text = "Sprzedawca";
            // 
            // Buyer
            // 
            this.Buyer.AutoSize = true;
            this.Buyer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buyer.Location = new System.Drawing.Point(364, 244);
            this.Buyer.Name = "Buyer";
            this.Buyer.Size = new System.Drawing.Size(74, 21);
            this.Buyer.TabIndex = 11;
            this.Buyer.Text = "Nabywca";
            // 
            // Clients
            // 
            this.Clients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clients.FormattingEnabled = true;
            this.Clients.ItemHeight = 17;
            this.Clients.Location = new System.Drawing.Point(624, 277);
            this.Clients.Name = "Clients";
            this.Clients.ScrollAlwaysVisible = true;
            this.Clients.Size = new System.Drawing.Size(100, 21);
            this.Clients.TabIndex = 12;
            this.Clients.SelectedIndexChanged += new System.EventHandler(this.Clients_SelectedIndexChanged);
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "clients";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            // 
            // CheckBoxOrderedBy
            // 
            this.CheckBoxOrderedBy.AutoSize = true;
            this.CheckBoxOrderedBy.Location = new System.Drawing.Point(247, 456);
            this.CheckBoxOrderedBy.Name = "CheckBoxOrderedBy";
            this.CheckBoxOrderedBy.Size = new System.Drawing.Size(205, 17);
            this.CheckBoxOrderedBy.TabIndex = 13;
            this.CheckBoxOrderedBy.Text = "Osoba odpowiedzialna za zamówienie";
            this.CheckBoxOrderedBy.UseVisualStyleBackColor = true;
            // 
            // TextBoxOrderedBy
            // 
            this.TextBoxOrderedBy.Location = new System.Drawing.Point(454, 453);
            this.TextBoxOrderedBy.Name = "TextBoxOrderedBy";
            this.TextBoxOrderedBy.Size = new System.Drawing.Size(100, 20);
            this.TextBoxOrderedBy.TabIndex = 14;
            // 
            // Main
            // 
            this.Main.AllowUserToAddRows = false;
            this.Main.AllowUserToDeleteRows = false;
            this.Main.AllowUserToResizeColumns = false;
            this.Main.AllowUserToResizeRows = false;
            this.Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Main.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.unitOfMeasure,
            this.quantity,
            this.pricePerArtWithVat,
            this.taxRate,
            this.priceWithTax});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main.DefaultCellStyle = dataGridViewCellStyle6;
            this.Main.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Main.Location = new System.Drawing.Point(46, 450);
            this.Main.MaximumSize = new System.Drawing.Size(635, 3000);
            this.Main.MinimumSize = new System.Drawing.Size(600, 200);
            this.Main.Name = "Main";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Main.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Main.Size = new System.Drawing.Size(635, 200);
            this.Main.TabIndex = 15;
            this.Main.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_CellEndEdit);
            this.Main.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Main_CellValidating);
            // 
            // name
            // 
            this.name.FillWeight = 117.6446F;
            this.name.HeaderText = "Nazwa towaru/usługi";
            this.name.MinimumWidth = 30;
            this.name.Name = "name";
            // 
            // unitOfMeasure
            // 
            this.unitOfMeasure.FillWeight = 57.53173F;
            this.unitOfMeasure.HeaderText = "j.m.";
            this.unitOfMeasure.Items.AddRange(new object[] {
            "szt",
            "mb",
            "kmp"});
            this.unitOfMeasure.Name = "unitOfMeasure";
            this.unitOfMeasure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitOfMeasure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 62.5303F;
            this.quantity.HeaderText = "Ilość";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            // 
            // pricePerArtWithVat
            // 
            this.pricePerArtWithVat.FillWeight = 126.6784F;
            this.pricePerArtWithVat.HeaderText = "Cena jednostkowa z podatkiem VAT";
            this.pricePerArtWithVat.MinimumWidth = 10;
            this.pricePerArtWithVat.Name = "pricePerArtWithVat";
            // 
            // taxRate
            // 
            this.taxRate.FillWeight = 99.58408F;
            this.taxRate.HeaderText = "Stawka podatku [%]";
            this.taxRate.Items.AddRange(new object[] {
            "8",
            "23"});
            this.taxRate.MaxDropDownItems = 2;
            this.taxRate.MinimumWidth = 10;
            this.taxRate.Name = "taxRate";
            this.taxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.taxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // priceWithTax
            // 
            this.priceWithTax.FillWeight = 177.665F;
            this.priceWithTax.HeaderText = "Wartość towaru/usługi wraz z podatkiem";
            this.priceWithTax.MinimumWidth = 10;
            this.priceWithTax.Name = "priceWithTax";
            this.priceWithTax.ReadOnly = true;
            // 
            // DeleteRow
            // 
            this.DeleteRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRow.Location = new System.Drawing.Point(687, 563);
            this.DeleteRow.MaximumSize = new System.Drawing.Size(65, 45);
            this.DeleteRow.MinimumSize = new System.Drawing.Size(55, 35);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(55, 35);
            this.DeleteRow.TabIndex = 17;
            this.DeleteRow.Text = "-";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // AddRow
            // 
            this.AddRow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRow.Location = new System.Drawing.Point(687, 512);
            this.AddRow.MaximumSize = new System.Drawing.Size(65, 45);
            this.AddRow.MinimumSize = new System.Drawing.Size(55, 35);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(55, 35);
            this.AddRow.TabIndex = 18;
            this.AddRow.Text = "+";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // FinalValuesDataGV
            // 
            this.FinalValuesDataGV.AllowUserToAddRows = false;
            this.FinalValuesDataGV.AllowUserToDeleteRows = false;
            this.FinalValuesDataGV.AllowUserToResizeColumns = false;
            this.FinalValuesDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FinalValuesDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.FinalValuesDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinalValuesDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueWithoutTax,
            this.Tax,
            this.TaxRate2,
            this.ValueWithTax});
            this.FinalValuesDataGV.Location = new System.Drawing.Point(240, 675);
            this.FinalValuesDataGV.Name = "FinalValuesDataGV";
            this.FinalValuesDataGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FinalValuesDataGV.Size = new System.Drawing.Size(441, 81);
            this.FinalValuesDataGV.TabIndex = 19;
            // 
            // ValueWithoutTax
            // 
            this.ValueWithoutTax.HeaderText = "Wartość bez podatku";
            this.ValueWithoutTax.Name = "ValueWithoutTax";
            this.ValueWithoutTax.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Podatek";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // TaxRate2
            // 
            this.TaxRate2.HeaderText = "Stawka podatku [%]";
            this.TaxRate2.Name = "TaxRate2";
            this.TaxRate2.ReadOnly = true;
            this.TaxRate2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ValueWithTax
            // 
            this.ValueWithTax.HeaderText = "Wartość z podatkiem";
            this.ValueWithTax.Name = "ValueWithTax";
            this.ValueWithTax.ReadOnly = true;
            // 
            // PDF
            // 
            this.PDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PDF.Location = new System.Drawing.Point(581, 774);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(100, 30);
            this.PDF.TabIndex = 20;
            this.PDF.Text = "PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // addClient
            // 
            this.addClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addClient.Location = new System.Drawing.Point(443, 241);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(100, 30);
            this.addClient.TabIndex = 21;
            this.addClient.Text = "Dodaj";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientTextBox
            // 
            this.clientTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTextBox.Location = new System.Drawing.Point(368, 276);
            this.clientTextBox.MaximumSize = new System.Drawing.Size(250, 135);
            this.clientTextBox.MinimumSize = new System.Drawing.Size(250, 100);
            this.clientTextBox.Multiline = true;
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(250, 100);
            this.clientTextBox.TabIndex = 22;
            // 
            // sellerTextBox
            // 
            this.sellerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellerTextBox.Location = new System.Drawing.Point(112, 276);
            this.sellerTextBox.MaximumSize = new System.Drawing.Size(250, 135);
            this.sellerTextBox.MinimumSize = new System.Drawing.Size(250, 100);
            this.sellerTextBox.Multiline = true;
            this.sellerTextBox.Name = "sellerTextBox";
            this.sellerTextBox.ReadOnly = true;
            this.sellerTextBox.Size = new System.Drawing.Size(250, 100);
            this.sellerTextBox.TabIndex = 23;
            // 
            // additionalMainInfoCheckbox
            // 
            this.additionalMainInfoCheckbox.AutoSize = true;
            this.additionalMainInfoCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.additionalMainInfoCheckbox.Location = new System.Drawing.Point(204, 412);
            this.additionalMainInfoCheckbox.Name = "additionalMainInfoCheckbox";
            this.additionalMainInfoCheckbox.Size = new System.Drawing.Size(158, 21);
            this.additionalMainInfoCheckbox.TabIndex = 24;
            this.additionalMainInfoCheckbox.Text = "Dodatkowe informacje";
            this.additionalMainInfoCheckbox.UseVisualStyleBackColor = true;
            this.additionalMainInfoCheckbox.CheckedChanged += new System.EventHandler(this.additionalMainInfoCheckbox_CheckedChanged);
            // 
            // AdditionalInfoTextbox
            // 
            this.AdditionalInfoTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdditionalInfoTextbox.Location = new System.Drawing.Point(368, 412);
            this.AdditionalInfoTextbox.Name = "AdditionalInfoTextbox";
            this.AdditionalInfoTextbox.Size = new System.Drawing.Size(113, 25);
            this.AdditionalInfoTextbox.TabIndex = 25;
            this.AdditionalInfoTextbox.Visible = false;
            // 
            // FinalValuesCount
            // 
            this.FinalValuesCount.BackColor = System.Drawing.Color.Transparent;
            this.FinalValuesCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FinalValuesCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FinalValuesCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinalValuesCount.Location = new System.Drawing.Point(475, 774);
            this.FinalValuesCount.Name = "FinalValuesCount";
            this.FinalValuesCount.Size = new System.Drawing.Size(100, 30);
            this.FinalValuesCount.TabIndex = 26;
            this.FinalValuesCount.Text = "Przelicz";
            this.FinalValuesCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FinalValuesCount.UseVisualStyleBackColor = false;
            this.FinalValuesCount.Click += new System.EventHandler(this.FinalValuesCount_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 861);
            this.Controls.Add(this.FinalValuesCount);
            this.Controls.Add(this.AdditionalInfoTextbox);
            this.Controls.Add(this.additionalMainInfoCheckbox);
            this.Controls.Add(this.sellerTextBox);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.FinalValuesDataGV);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.TextBoxOrderedBy);
            this.Controls.Add(this.CheckBoxOrderedBy);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Buyer);
            this.Controls.Add(this.Seller);
            this.Controls.Add(this.TextBoxAdditionalInvoiceInfo);
            this.Controls.Add(this.AdditionalInvoiceInfo);
            this.Controls.Add(this.TextBoxInvoiceNr);
            this.Controls.Add(this.InvoiceNr);
            this.Controls.Add(this.DateTimeSaleDate);
            this.Controls.Add(this.DateTimeInvoiceIssuing);
            this.Controls.Add(this.PlaceofsaleTextbox);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.InvoiceIssuing);
            this.Controls.Add(this.Placeofsale);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Invoice";
            this.Text = "Fakturowanie";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalValuesDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSetOkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataSet13BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Placeofsale;
        private System.Windows.Forms.Label InvoiceIssuing;
        private System.Windows.Forms.Label SaleDate;
        private System.Windows.Forms.TextBox PlaceofsaleTextbox;
        private System.Windows.Forms.DateTimePicker DateTimeInvoiceIssuing;
        private System.Windows.Forms.DateTimePicker DateTimeSaleDate;
        private System.Windows.Forms.Label InvoiceNr;
        private System.Windows.Forms.TextBox TextBoxInvoiceNr;
        private System.Windows.Forms.CheckBox AdditionalInvoiceInfo;
        private System.Windows.Forms.TextBox TextBoxAdditionalInvoiceInfo;
        private System.Windows.Forms.Label Seller;
        private System.Windows.Forms.Label Buyer;
        private System.Windows.Forms.ListBox Clients;
        private System.Windows.Forms.CheckBox CheckBoxOrderedBy;
        private System.Windows.Forms.TextBox TextBoxOrderedBy;
        private System.Windows.Forms.DataGridView Main;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.DataGridView FinalValuesDataGV;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox sellerTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerArtWithVat;
        private System.Windows.Forms.DataGridViewComboBoxColumn taxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceWithTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueWithoutTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxRate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueWithTax;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource invoiceDataSetOkBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.BindingSource invoiceDataSet13BindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private System.Windows.Forms.CheckBox additionalMainInfoCheckbox;
        private System.Windows.Forms.TextBox AdditionalInfoTextbox;
        private System.Windows.Forms.Button FinalValuesCount;
    }
}

