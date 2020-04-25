using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        ArrayList listaPacienti = new ArrayList();
        ArrayList listaMedici = new ArrayList();
        List<Persoana> listaPersoane = new List<Persoana>();
        public Form1()
        {

            InitializeComponent();
        }
       

        private void adaugăMedicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void afișeazăMediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM Medici", conexiune);


            try
            {
                listView1.Clear();
                listView1.View = View.Details;
                listView1.Columns.Add("CodMedic", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Nume", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Prenume", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Varsta", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Sex", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Specializare", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("PretConsultatie", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("CodPacienti", 120, HorizontalAlignment.Left);

                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();



                while (reader.Read())
                {
                    ListViewItem medici = new ListViewItem(reader["CodMedic"].ToString());
                    medici.SubItems.Add(reader["Nume"].ToString());
                    medici.SubItems.Add(reader["Prenume"].ToString());
                    medici.SubItems.Add(reader["Varsta"].ToString());
                    medici.SubItems.Add(reader["Sex"].ToString());
                    medici.SubItems.Add(reader["Specializare"].ToString());
                    medici.SubItems.Add(reader["PretConsultatie"].ToString());
                    medici.SubItems.Add(reader["CodPacienti"].ToString());

                    listView1.Items.Add(medici);


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void pretMediuConsultatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT AVG(PretConsultatie)  FROM Medici", conexiune);

            try
            {
                conexiune.Open();

                float avg = (float)Convert.ToDouble(comanda.ExecuteScalar());
                MessageBox.Show("Pretul mediu pentru o consultatie: " + avg + " lei ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        
        private void varstaMaximaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT MAX(Varsta) FROM Medici", conexiune);

            try
            {
                conexiune.Open();

                int max = Convert.ToInt32(comanda.ExecuteScalar());
                MessageBox.Show("Varsta maxima:   " + max);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void adaugaPacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void afiseazaPacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM Pacienti", conexiune);


            try
            {
                listView1.Clear();
                listView1.View = View.Details;
                listView1.Columns.Add("CodPacient", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Nume", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Prenume", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Varsta", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Sex", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("Categorie_asigurat", 120, HorizontalAlignment.Left);
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();



                while (reader.Read())
                {
                    ListViewItem pacienti = new ListViewItem(reader["CodPacient"].ToString());
                    pacienti.SubItems.Add(reader["Nume"].ToString());
                    pacienti.SubItems.Add(reader["Prenume"].ToString());
                    pacienti.SubItems.Add(reader["Varsta"].ToString());
                    pacienti.SubItems.Add(reader["Sex"].ToString());
                    pacienti.SubItems.Add(reader["Categorie_asigurat"].ToString());
               
                    listView1.Items.Add(pacienti);


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void varstaMediePacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
            OleDbConnection conexiune = new OleDbConnection(provider);
            OleDbCommand comanda = new OleDbCommand("SELECT AVG(Varsta) FROM Pacienti", conexiune);

            try
            {
                conexiune.Open();

                int avg = Convert.ToInt32(comanda.ExecuteScalar());
                MessageBox.Show("Varsta meide a pacientilor :   " + avg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void adaugareInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("Pacienti.txt");
                string row = null;
                while ((row = sr.ReadLine()) != null)
                {
                    try
                    {
                        int codPacient = Convert.ToInt32(row.Split(' ')[0]);
                        string nume = row.Split(' ')[1];
                        string prenume = row.Split(' ')[2];
                       
                        int varsta = Convert.ToInt32(row.Split(' ')[3]);
                        string sex = row.Split(' ')[4];
                        string categorieAsigurat = row.Split(' ')[5];


                        Pacienti p = new Pacienti(nume, prenume, varsta, sex, codPacient, categorieAsigurat);
                        listaPacienti.Add(p);


                        string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Proiect.accdb";
                        OleDbConnection conexiune = new OleDbConnection(provider);
                        OleDbCommand comanda = new OleDbCommand("INSERT INTO Pacienti VALUES(?,?,?,?,?,?)", conexiune);
                        try
                        {
                            conexiune.Open();
                            comanda.Parameters.Add("codPacient", OleDbType.Integer).Value = codPacient;
                            comanda.Parameters.Add("Nume", OleDbType.Char, nume.Length).Value = nume;
                            comanda.Parameters.Add("Prenume", OleDbType.Char, prenume.Length).Value = prenume;
                           
                            comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = varsta;
                            comanda.Parameters.Add("Sex", OleDbType.Char, sex.Length).Value = sex;
                            comanda.Parameters.Add("CategorieAsigurat", OleDbType.Char, prenume.Length).Value = categorieAsigurat;



                            comanda.ExecuteNonQuery();
                            MessageBox.Show("Client adaugat in BD ");
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message);
                        }
                        finally
                        {
                            conexiune.Close();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare " + ex.Message);
                    }

                }
                MessageBox.Show("Date citite cu succes");
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fisier negasit " + ex.Message);
            }

        }

        private void scriereMediciInFiseirXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;


            writer.WriteStartDocument();

            writer.WriteStartElement("Medici");

            foreach (Medici m in listaMedici)
            {
                writer.WriteStartElement("codMedic");
                writer.WriteValue(m.CodMedic);


                writer.WriteStartElement("Nume");
                writer.WriteValue(m.Nume);
                writer.WriteEndElement();

                writer.WriteStartElement("Prenume");
                writer.WriteValue(m.Prenume);
                writer.WriteEndElement();


                writer.WriteStartElement("Varsta");
                writer.WriteValue(m.Varsta);

                writer.WriteStartElement("Sex");
                writer.WriteValue(m.Sex);
                writer.WriteEndElement();

                writer.WriteStartElement("Specializare");
                writer.WriteValue(m.Specializare);
                writer.WriteEndElement();


                writer.WriteStartElement("PretConsultatie");
                writer.WriteValue(m.PretConsultatie);

                writer.WriteStartElement("CodMedici");
                writer.WriteValue(m.CodMedic);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }


            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();


            string xml = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            StreamWriter sw = new StreamWriter("Medici.xml");
            sw.WriteLine(xml);
            sw.Close();
        }

        private void reteteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

    


    

