using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class AdminProf : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminProf()
        {
            InitializeComponent();
        }

        public void fct()
        {
            //module.Items.Clear();
            //professeur.Items.Clear();
            //cin.Items.Clear();

            //connection.Open();
            //SqlDataReader myReader1 = null;
            //SqlCommand myCommand1 = new SqlCommand("select * from Module ", connection);
            //myReader1 = myCommand1.ExecuteReader();
            //while (myReader1.Read())
            //{
            //    //module.Items.Add(myReader1["Id_m"].ToString() + " - " + myReader1["Libelle"].ToString());
            //}
            //connection.Close();

            //connection.Open();
            //SqlDataReader myReader2 = null;
            //SqlCommand myCommand2 = new SqlCommand("select * from  Professeur", connection);
            //myReader2 = myCommand2.ExecuteReader();
            //while (myReader2.Read())
            //{
            //    //professeur.Items.Add(myReader2["Id_prof"].ToString() + "- " + myReader2["Nom"].ToString());
            //    cin.Items.Add(myReader2["Id_prof"].ToString() + "- " + myReader2["Nom"].ToString());
            //}
            //connection.Close();
            Telecharger.Hide();
        }

        private void professeur_Load(object sender, EventArgs e)
        {
            fct();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cinText.Text == "" || nomText.Text == ""
                || titreText.Text == "" || telText.Text == ""
                || emailText.Text == "" 
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(emailText.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(telText.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }


                String cinprof = this.cinText.Text;
                String nom = this.nomText.Text;
                String titre = this.titreText.Text;
                String cv = this.cvText.Text;
                String tel = this.telText.Text;
                String email = this.emailText.Text;
                String filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    String chemin = path + "\\CVs\\" + filename;
                    cmd.CommandText = "insert into Professeur(cinprof, Nom, Tel, Email , Titre, CV)" +
                        "values('" + cinprof + "','" + nom + "'," + "'" + tel + "'," +
                        "'" + email + "','" + titre + "','" + chemin + "')";
                    
                    Console.WriteLine(openFileDialog1.FileName);
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\CVs\\" + filename);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Professeur a ete bien ajouter.");
                    titreText.Clear(); cvText.Clear(); telText.Clear(); emailText.Clear();
                    cinText.Clear(); nomText.Clear();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fct();
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {
            Telecharger.Show();
            cinText.Enabled = false;
            String rechercher = this.rechercherText.Text;


            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Professeur" +
                " WHERE cinprof ='" + rechercher + "' ";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    this.cinText.Text = reader["cinprof"].ToString();
                    this.nomText.Text = reader["Nom"].ToString();
                    this.telText.Text = reader["Tel"].ToString();
                    this.emailText.Text = reader["Email"].ToString();
                    this.titreText.Text = reader["Titre"].ToString();
                    this.cvText.Text = reader["CV"].ToString();

                }
            }
            this.rechercherText.Clear();
            connection.Close();
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {

            String cinprof = this.rechercherText.Text;
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce professeur?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Professeur where cinprof = '" + cinprof + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Professeur a ete bien supprimer.", "Message");
                this.rechercherText.Clear();
            }
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cinText.Text == "" || nomText.Text == ""
                || titreText.Text == "" || telText.Text == ""
                || emailText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(emailText.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(telText.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }
                if (MessageBox.Show("Etes-vous sur de vouloir modifier ce professeur?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    /*SqlCommand cmd1 = connection.CreateCommand();*/
                    cmd.CommandType = CommandType.Text;
                    /*cmd1.CommandType = CommandType.Text;*/

                    /*cmd1.CommandText = "select *  from module" +
                    " WHERE libelle ='" + libelleText.Text + "' ";
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["id"]);
                        }
                    }*/
                    cmd.CommandText = "update Professeur set cinprof = '" + cinText.Text + "'," +
                        "Nom = '" + nomText.Text + "'," +
                        "Tel = '" + telText.Text + "'," +
                        "Email = '" + emailText.Text + "'," +
                        "Titre = '" + titreText.Text + "'," +
                        "CV = '" + cvText.Text + "'" +
                        " where cinprof = '" + cinText.Text + "'";
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Le Module a ete bien modifier.", "Message");
                    this.rechercherText.Clear();
                    reset();
                    fct();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            cinText.Enabled = true;
            cinText.Clear(); cvText.Clear();
            titreText.Clear(); telText.Clear();
            nomText.Clear(); emailText.Clear();
            Telecharger.Hide();
        }

       

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrateur ga = new Administrateur();
            ga.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AffectationProfMod afmo = new AffectationProfMod();
            afmo.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        string filename = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        cvText.Text = path + "\\CVs\\" + filename;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Telecharger_Click(object sender, EventArgs e)
        {
            String filename = cvText.Text;
            System.Diagnostics.Process.Start(filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cinText.Text == "" || nomText.Text == ""
                || titreText.Text == "" || telText.Text == ""
                || emailText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(emailText.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(telText.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }


                String cinprof = this.cinText.Text;
                String nom = this.nomText.Text;
                String titre = this.titreText.Text;
                String cv = this.cvText.Text;
                String tel = this.telText.Text;
                String email = this.emailText.Text;
                String filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    String chemin = path + "\\CVs\\" + filename;
                    cmd.CommandText = "insert into Professeur(cinprof, Nom, Tel, Email , Titre, CV)" +
                        "values('" + cinprof + "','" + nom + "'," + "'" + tel + "'," +
                        "'" + email + "','" + titre + "','" + chemin + "')";

                    Console.WriteLine(openFileDialog1.FileName);
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\CVs\\" + filename);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Professeur a ete bien ajouter.");
                    titreText.Clear(); cvText.Clear(); telText.Clear(); emailText.Clear();
                    cinText.Clear(); nomText.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cinText.Text == "" || nomText.Text == ""
                || titreText.Text == "" || telText.Text == ""
                || emailText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(emailText.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(telText.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }
                if (MessageBox.Show("Etes-vous sur de vouloir modifier ce professeur?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    /*SqlCommand cmd1 = connection.CreateCommand();*/
                    cmd.CommandType = CommandType.Text;
                    /*cmd1.CommandType = CommandType.Text;*/

                    /*cmd1.CommandText = "select *  from module" +
                    " WHERE libelle ='" + libelleText.Text + "' ";
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["id"]);
                        }
                    }*/
                    cmd.CommandText = "update Professeur set cinprof = '" + cinText.Text + "'," +
                        "Nom = '" + nomText.Text + "'," +
                        "Tel = '" + telText.Text + "'," +
                        "Email = '" + emailText.Text + "'," +
                        "Titre = '" + titreText.Text + "'," +
                        "CV = '" + cvText.Text + "'" +
                        " where cinprof = '" + cinText.Text + "'";
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Le Module a ete bien modifier.", "Message");
                    this.rechercherText.Clear();
                    reset();
                    fct();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrateur ga = new Administrateur();
            ga.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AffectationProfMod afmo = new AffectationProfMod();
            afmo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            String cinprof = this.rechercherText.Text;
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce professeur?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Professeur where cinprof = '" + cinprof + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Professeur a ete bien supprimer.", "Message");
                this.rechercherText.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Telecharger.Show();
            cinText.Enabled = false;
            String rechercher = this.rechercherText.Text;


            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Professeur" +
                " WHERE cinprof ='" + rechercher + "' ";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    this.cinText.Text = reader["cinprof"].ToString();
                    this.nomText.Text = reader["Nom"].ToString();
                    this.telText.Text = reader["Tel"].ToString();
                    this.emailText.Text = reader["Email"].ToString();
                    this.titreText.Text = reader["Titre"].ToString();
                    this.cvText.Text = reader["CV"].ToString();

                }
            }
            this.rechercherText.Clear();
            connection.Close();
        }
    }
}
