using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        private object errorProvider1;
      

        public Form3()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT MAX(CodPacient) FROM Pacienti", conexiune);

            if (textBox1.Text == "")
            {
                errorProvider2.SetError(textBox1, " Nume:   ");
            }
            else
            if (textBox2.Text == "") errorProvider2.SetError(textBox2, " Prenume: ");

            else
            if (textBox3.Text == "") errorProvider2.SetError(textBox3, " Varsta:  ");
            else
            if (textBox4.Text == "") errorProvider2.SetError(textBox4, "Sex:  ");
            else
                
            try
                {
                    NewMethod();
                    conexiune.Open();
                    int CodPacient = Convert.ToInt32(comanda.ExecuteScalar());


                    comanda.CommandText = "INSERT INTO Pacienti VALUES(?,?,?,?,?,?)";
                    comanda.Parameters.Add("CodPacient", OleDbType.Integer).Value = CodPacient + 1;
                    comanda.Parameters.Add("Nume", OleDbType.Char, textBox1.Text.Length).Value = textBox1.Text;
                    comanda.Parameters.Add("Prenume", OleDbType.Char, textBox2.Text.Length).Value = textBox2.Text;
                    comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = Convert.ToInt32(textBox3.Text);
                    comanda.Parameters.Add("Sex", OleDbType.Char, textBox4.Text.Length).Value = textBox4.Text;
                    comanda.Parameters.Add("Categorie_asigurat", OleDbType.Char, groupBox1.Text.Length).Value = groupBox1.Text;

                   comanda.ExecuteNonQuery();
                    MessageBox.Show("Pacient adaugat ");
                }
                catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conexiune.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                
               
            }
        }

        private void NewMethod()
        {
            errorProvider2.Clear();
        }
    }
}