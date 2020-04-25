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
    public partial class Form2 : Form
    {
        Medici m;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT MAX(CodMedic) FROM Medici", conexiune);

            if (textBox1.Text == "") errorProvider1.SetError(textBox1, " Nume:   ");
            else
            if (textBox2.Text == "") errorProvider1.SetError(textBox2, " Prenume: ");

            else
            if (textBox3.Text == "") errorProvider1.SetError(textBox3, " Varsta:  ");
            else
            if (textBox4.Text == "") errorProvider1.SetError(textBox4, "Sex:  ");
            else
            if (textBox5.Text == "") errorProvider1.SetError(textBox5, " Specializare:  ");
            else
            if (textBox6.Text == "") errorProvider1.SetError(textBox6, " PretConsultatie:  ");
            else
             if (textBox7.Text == "") errorProvider1.SetError(textBox7, "CodPacienti: ");
                try
                {
                    errorProvider1.Clear();
                    conexiune.Open();
                    int CodMedic = Convert.ToInt32(comanda.ExecuteScalar());


                    comanda.CommandText = "INSERT INTO Medici VALUES(?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("CodMedic", OleDbType.Integer).Value = CodMedic + 1;
                    comanda.Parameters.Add("Nume", OleDbType.Char, textBox1.Text.Length).Value = textBox1.Text;
                    comanda.Parameters.Add("Prenume", OleDbType.Char, textBox2.Text.Length).Value = textBox2.Text;
                    comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = Convert.ToInt32(textBox3.Text);
                    comanda.Parameters.Add("Sex", OleDbType.Char, textBox6.Text.Length).Value = textBox4.Text;
                    comanda.Parameters.Add("Specializare", OleDbType.Char, textBox2.Text.Length).Value = textBox5.Text;
                comanda.Parameters.Add("PretConsultatie", OleDbType.Double).Value = (float)Convert.ToDouble(textBox6.Text);
                comanda.Parameters.Add("CodPacienti", OleDbType.Char,textBox7.Text.Length).Value = textBox7.Text;


               comanda.ExecuteNonQuery();
                    MessageBox.Show("Medic adaugat ");
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
                    textBox5.Clear();
                    textBox6.Clear();
                textBox7.Clear();

            }
            }

      
    }
    }

