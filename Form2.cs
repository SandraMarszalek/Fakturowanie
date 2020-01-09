using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Invoice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "datasource = localhost;port=3306;username=root;password=;database=invoice";
            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            var comand = con.CreateCommand();
            comand.CommandText = "INSERT INTO clients(name,adress,postalcode,city,NIP) VALUES (@name,@adress,@postalcode,@city,@NIP)";
            comand.Parameters.AddWithValue("@name", nameTextBox.Text);
            comand.Parameters.AddWithValue("@adress", adressTextBox.Text);
            comand.Parameters.AddWithValue("@postalcode", postalCodeTextBox.Text);
            comand.Parameters.AddWithValue("@city", cityTextBox.Text);
            comand.Parameters.AddWithValue("@NIP", NIPtextBox.Text);
            comand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dodano nowy rekord do bazy danych!");

            
        }
    }
}
