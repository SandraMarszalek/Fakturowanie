using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;





namespace Invoice
{

    public partial class Invoice : Form
    {
        
        public Invoice()
        {
            InitializeComponent();
            ShowSellerTextBoxInfo();
            addRowsToFinalValues();
            Main.RowHeadersWidth = 50;
            PopulateListBoxClients();
            SetSellerInfoTextbox();
        }

        
        private void ShowSellerTextBoxInfo()
        {
            //sellerTextBox.Text = 
        }
        private void additionalInvoiceInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (AdditionalInvoiceInfo.Checked)
            {
                TextBoxAdditionalInvoiceInfo.Visible = true;
            }
            else
            {
                TextBoxAdditionalInvoiceInfo.Visible = false;
            }
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            Main.Rows.Add();
            foreach (DataGridViewRow row in Main.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();  
            }
            int sum = this.Main.ColumnHeadersHeight;
            foreach(DataGridViewRow row in this.Main.Rows)
            {
                sum += row.Height + 1; // +1 because of the cell border
            }


            selectLastRow();

        }

        private void selectLastRow()
        {
            Main.MultiSelect = false;
            Main.SelectionMode = DataGridViewSelectionMode.CellSelect;
            int rows = Main.RowCount - 1;
            Main.Rows[rows].Selected = true;
            Main.Rows[rows].Cells[0].Selected = true;
            
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                Main.MultiSelect = false;
                Main.SelectionMode = DataGridViewSelectionMode.CellSelect;
                int rows = Main.RowCount - 1;
                Main.Rows[rows].Selected = true;
                Main.Rows[rows].Cells[0].Selected = true;
                int row = Main.CurrentCell.RowIndex;
                Main.Rows.RemoveAt(row);
            }
            catch (ArgumentOutOfRangeException)
            { 
            }       
        }

        private void addRowsToFinalValues()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(FinalValuesDataGV);
            row.Cells[0].Value = "";
            FinalValuesDataGV.Rows.Insert(0, 2);
            HiddenFinalValues();
        }

        
        private void finalValues(double fullPriceWithTaxfinal, double tax2)
        {
            FinalValuesDataGV.Rows[0].Cells[3].Value = fullPriceWithTaxfinal;
            FinalValuesDataGV.Rows[1].Cells[3].Value = fullPriceWithTaxfinal;

             FinalValuesDataGVshow/*_CellEndEdit*/(fullPriceWithTaxfinal, tax2);
        }

   

        public void Main_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double fullPriceWithTaxfinal = 0;
            double tax2 = 0;
            foreach (DataGridViewRow row in Main.Rows)
            {
               Convert.ToDouble(row.Cells[Main.Columns["priceWithTax"].Index].Value = (Convert.ToDouble(row.Cells[Main.Columns["quantity"].Index].Value) * (Convert.ToDouble(row.Cells[Main.Columns["pricePerArtWithVat"].Index].Value))));
                tax2 = Convert.ToDouble(row.Cells[Main.Columns["taxRate"].Index].Value);
                // fullPriceWithTaxfinal = Convert.ToDouble(row.Cells[Main.Columns["priceWithTax"].Index].Value = (Convert.ToDouble(row.Cells[Main.Columns["quantity"].Index].Value) * (Convert.ToDouble(row.Cells[Main.Columns["pricePerArtWithVat"].Index].Value))));
            }
            for (int i = 0; i <= Main.Rows.Count-1; i++)
            {
                fullPriceWithTaxfinal = fullPriceWithTaxfinal + Convert.ToDouble(Main.Rows[i].Cells[5].Value.ToString());
            } 
            finalValues(fullPriceWithTaxfinal,tax2);
        }

      /*  private bool nonNumberEntered = false;
        private void MainCell_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)

                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        private void MainCell_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }*/

        public void ChangeFromDot()
        {
           // if 
        }

        public void HiddenFinalValues()
        {
            foreach (DataGridViewRow row in FinalValuesDataGV.Rows)
            {
                row.Visible = false;
            }
        }
        public void FinalValuesCount_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in FinalValuesDataGV.Rows)
            {
                row.Visible = true;
            }
        }

        private void FinalValuesDataGVshow/*_CellEndEdit*/(double fullPriceWithTaxfinal, double tax2) 
        {
            
                double net = 0;
                double tax = 0;
                if (tax2 == 23)
                {
                    tax = 0.23;
                }
                else
                {
                    tax = 0.08;
                }

                foreach (DataGridViewRow row in FinalValuesDataGV.Rows)
                {
                    Convert.ToDouble(row.Cells[FinalValuesDataGV.Columns["TaxRate2"].Index].Value = tax2);
                    net = (Convert.ToDouble(row.Cells[FinalValuesDataGV.Columns["ValueWithoutTax"].Index].Value = Math.Round((fullPriceWithTaxfinal / 1.23), 2)));
                    Convert.ToDouble(row.Cells[FinalValuesDataGV.Columns["Tax"].Index].Value = Math.Round((net * tax), 2));
                }
        }



        private void Main_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*if (Main.Columns[e.ColumnIndex].Name == "Nazwa towaru/usługi")
                if(e.FormattedValue == null && String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    Main.Rows[e.RowIndex].ErrorText = "Nazwa towaru/usługi nie może być pusta!";
                    e.Cancel = true;
                }*/
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void PopulateListBoxClients()
        {
            string connstr = "datasource = localhost;port=3306;username=root;password=;database=invoice";
            string query = "SELECT * FROM clients ;";
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmdClients = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmdClients.ExecuteReader();

                while (reader.Read())
                {
                    string K1 = reader.GetString("name");
                    Clients.Items.Add(K1);  
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            conn.Close();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'invoiceClientsData.clients' . Możesz go przenieść lub usunąć.
        }

        private void Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstr = "datasource = localhost;port=3306;username=root;password=;database=invoice";
            string query = "SELECT * FROM clients WHERE name ='"+Clients.Text+"'";
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmdClients = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                cmdClients.ExecuteNonQuery();
                reader = cmdClients.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    string adress = reader.GetString("adress");
                    string postalcode = reader.GetString("postalcode");
                    string city = reader.GetString("city");
                    string NIP = reader.GetString("NIP");

                    clientTextBox.Text = name + Environment.NewLine + adress + Environment.NewLine + postalcode + " " + city + Environment.NewLine + "NIP: " + NIP;
                         
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void SetSellerInfoTextbox()
        {
            sellerTextBox.Text = Environment.NewLine + "Sprzedający" + Environment.NewLine + "Ulica 500 lok. AB" + Environment.NewLine + "00-000 Miasto" + Environment.NewLine + "NIP: 000 000 00 00";
        }

        private void additionalMainInfoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (additionalMainInfoCheckbox.Checked)
            {
                AdditionalInfoTextbox.Visible = true;
            }
            else
            {
                AdditionalInfoTextbox.Visible = false;
            }
        }

       


        private void PDF_Click(object sender, EventArgs e)
        {
            Document invoice = new Document();
            pdfname name = new pdfname();
            name.Show();
            System.Windows.Forms.Form pdfname = System.Windows.Forms.Application.OpenForms["pdfname"];
            string pdfName = ((pdfname)pdfname).textBoxPdfName.Text;
            PdfWriter.GetInstance(invoice, new FileStream("K:/pdfName"/*"K:/invoice.pdf"*/, FileMode.Create));
            invoice.Open();
            var polishFontSize = 10f;
            var polishFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, polishFontSize);
            var fontSize = 9f;
            var mainPolishFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, fontSize);
            Paragraph placeOfSaleTB = new Paragraph("Miejsce wystawienia: " + PlaceofsaleTextbox.Text, polishFont);
            placeOfSaleTB.Alignment = Element.ALIGN_RIGHT;
            invoice.Add(placeOfSaleTB);
            Paragraph date = new Paragraph("Data wystawienia: " + DateTimeInvoiceIssuing.Text, polishFont);
            date.Alignment = Element.ALIGN_RIGHT;
            invoice.Add(date);
            Paragraph dateOfSale = new Paragraph("Data sprzedaży: " + DateTimeSaleDate.Text, polishFont);
            date.Alignment = Element.ALIGN_RIGHT;
            invoice.Add(date);
            var titleFont = FontFactory.GetFont(BaseFont.HELVETICA, 13);
            Paragraph title = new Paragraph("Faktura VAT nr: " + TextBoxInvoiceNr.Text + Environment.NewLine, titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            invoice.Add(title);
            if (AdditionalInvoiceInfo.Checked)
            {
                Paragraph addInfo = new Paragraph(AdditionalInvoiceInfo.Text, mainPolishFont);
                addInfo.Alignment = Element.ALIGN_CENTER;
                invoice.Add(addInfo);
            }
            Paragraph seller = new Paragraph("Sprzedawca: " + sellerTextBox.Text, polishFont);
            Paragraph client = new Paragraph("Nabywca: " + Environment.NewLine + clientTextBox.Text, polishFont);
            // seller.SetLeading(100,0); to nie działa. Znaleźć sposób żeby działało
            PdfPTable sellbuyinfo = new PdfPTable(6);
            PdfPCell cellSeller;
            PdfPCell cellClient;
            PdfPCell glue;
            sellbuyinfo.SpacingBefore = 10f;
            cellSeller = new PdfPCell(new Phrase(seller));
            cellSeller.BorderWidth = 0f;
            cellSeller.Colspan = 2;
            sellbuyinfo.AddCell(cellSeller);
            cellSeller.Rowspan = 1;
            glue = new PdfPCell();
            glue.BorderWidth = 0f;
            glue.Colspan = 2;
            sellbuyinfo.AddCell(glue);
            cellClient = new PdfPCell(new Phrase(client));
            cellClient.BorderWidth = 0f;
            cellClient.Colspan = 2;
            sellbuyinfo.AddCell(cellClient);
            cellClient.Rowspan = 1;
            sellbuyinfo.AddCell(cellClient);
            invoice.Add(sellbuyinfo);
            PdfPTable main = new PdfPTable(Main.ColumnCount);
            main.SpacingBefore = 25f;
            main.WidthPercentage = 100;
            foreach (DataGridViewColumn column in Main.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, mainPolishFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                main.AddCell(cell);
            }
            foreach (DataGridViewRow row in Main.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Paragraph nrow = new Paragraph(cell.Value.ToString(), mainPolishFont);
                    PdfPCell cells = new PdfPCell(nrow);
                    cells.HorizontalAlignment = Element.ALIGN_CENTER;
                    cells.VerticalAlignment = Element.ALIGN_CENTER;
                    main.AddCell(cells);
                }
            }

            if (additionalMainInfoCheckbox.Checked)
            {
                Paragraph addInfo = new Paragraph(AdditionalInfoTextbox.Text, mainPolishFont);
                addInfo.Alignment = Element.ALIGN_CENTER;
                invoice.Add(addInfo);
            }

            PdfPTable final = new PdfPTable(FinalValuesDataGV.ColumnCount);
            final.SpacingBefore = 40f;
            final.WidthPercentage = 60;
            final.HorizontalAlignment = Element.ALIGN_RIGHT;
            foreach (DataGridViewColumn column in FinalValuesDataGV.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, mainPolishFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                final.AddCell(cell);
            }
            foreach (DataGridViewRow row in FinalValuesDataGV.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    Paragraph nrow = new Paragraph(cell.Value.ToString(), mainPolishFont);
                    PdfPCell cells = new PdfPCell(nrow);
                    cells.HorizontalAlignment = Element.ALIGN_CENTER;
                    cells.VerticalAlignment = Element.ALIGN_CENTER;
                    final.AddCell(cells);
                }
            }

            invoice.Add(main);
            invoice.Add(final);

            invoice.Close();
            MessageBox.Show("PDF created sucessfully!");

            //obsłużyć wyjątek pliku używanego przez inny zasób

        }
    }
    }

