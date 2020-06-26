using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class AdminScolarModule : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminScolarModule()
        {
            InitializeComponent();

        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" || dureeText.Text == ""
                || coefText.Text == "" 
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex(@"\d{1}(\d{1})?");
                if (!regex.IsMatch(dureeText.Text))
                {
                    throw new Exception("Entrez une duree valide.");
                }

                Regex regex1 = new Regex(@"\d{1}(\d{1})?");

                if (!regex1.IsMatch(coefText.Text))
                {
                    throw new Exception("Entrez un coeff valide.");
                }


                String libelle = this.libelleText.Text;
                int duree = Convert.ToInt32(this.dureeText.Text);
                int coef = Convert.ToInt32(this.coefText.Text);

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Module(Libelle, Duree, Coef)" +
                    "values('" + libelle + "'," + duree + "," + coef + ")";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le module a ete bien ajouter.");
                libelleText.Clear(); dureeText.Clear(); coefText.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {

            libelleText.Enabled = false;
            string rechercher = this.rechercherText.Text;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Module" +
                " WHERE Libelle ='" + rechercher + "' ";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string libelle = reader["Libelle"].ToString();
                    int duree = Convert.ToInt32(reader["Duree"]);
                    int coef = Convert.ToInt32(reader["Coef"]);

                    libelleText.Text = libelle;
                    dureeText.Text = duree.ToString();
                    coefText.Text = coef.ToString();

                }
            }
            this.rechercherText.Clear();
            connection.Close();
        }

        private void updateButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" || dureeText.Text == ""
                || coefText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex(@"\d{1}(\d{1})?");
                if (!regex.IsMatch(dureeText.Text))
                {
                    throw new Exception("Entrez une duree valide.");
                }

                Regex regex1 = new Regex(@"\d{1}(\d{1})?");

                if (!regex1.IsMatch(coefText.Text))
                {
                    throw new Exception("Entrez un coeff valide.");
                }

                int id = 0;
                string libelle = libelleText.Text;
                libelleText.Enabled = true;
                if (MessageBox.Show("Etes-vous sur de vouloir modifier ce module ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd1.CommandType = CommandType.Text;

                    cmd1.CommandText = "select *  from Module" +
                    " WHERE Libelle ='" + libelleText.Text + "' ";
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["Id_m"]);
                        }
                    }
                    cmd.CommandText = "update Module set Libelle = '" + libelle + "'," +
                        "Duree =" + int.Parse(dureeText.Text) + "," +
                        "Coef = " + int.Parse(coefText.Text) +
                        " where Id_m =" + id + "";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(libelleText.Text);

                    connection.Close();
                    MessageBox.Show("Le Module a ete bien modifier.", "Message");
                    this.rechercherText.Clear();
                    this.libelleText.Clear();
                    this.dureeText.Clear();
                    this.coefText.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            libelleText.Enabled = true;
            this.rechercherText.Clear();
            this.libelleText.Clear();
            this.dureeText.Clear();
            this.coefText.Clear();
        }

        private void AdminScolModule_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dureeLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob gl = new AdminScolGlob();
            gl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            libelleText.Enabled = false;
            string rechercher = this.rechercherText.Text;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Module" +
                " WHERE Libelle ='" + rechercher + "' ";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string libelle = reader["Libelle"].ToString();
                    int duree = Convert.ToInt32(reader["Duree"]);
                    int coef = Convert.ToInt32(reader["Coef"]);

                    libelleText.Text = libelle;
                    dureeText.Text = duree.ToString();
                    coefText.Text = coef.ToString();

                }
            }
            this.rechercherText.Clear();
            connection.Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" || dureeText.Text == ""
                || coefText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex(@"\d{1}(\d{1})?");
                if (!regex.IsMatch(dureeText.Text))
                {
                    throw new Exception("Entrez une duree valide.");
                }

                Regex regex1 = new Regex(@"\d{1}(\d{1})?");

                if (!regex1.IsMatch(coefText.Text))
                {
                    throw new Exception("Entrez un coeff valide.");
                }

                int id = 0;
                string libelle = libelleText.Text;
                libelleText.Enabled = true;
                if (MessageBox.Show("Etes-vous sur de vouloir modifier ce module ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd1.CommandType = CommandType.Text;

                    cmd1.CommandText = "select *  from Module" +
                    " WHERE Libelle ='" + libelleText.Text + "' ";
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["Id_m"]);
                        }
                    }
                    cmd.CommandText = "update Module set Libelle = '" + libelle + "'," +
                        "Duree =" + int.Parse(dureeText.Text) + "," +
                        "Coef = " + int.Parse(coefText.Text) +
                        " where Id_m =" + id + "";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(libelleText.Text);

                    connection.Close();
                    MessageBox.Show("Le Module a ete bien modifier.", "Message");
                    this.rechercherText.Clear();
                    this.libelleText.Clear();
                    this.dureeText.Clear();
                    this.coefText.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" || dureeText.Text == ""
                || coefText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex(@"\d{1}(\d{1})?");
                if (!regex.IsMatch(dureeText.Text))
                {
                    throw new Exception("Entrez une duree valide.");
                }

                Regex regex1 = new Regex(@"\d{1}(\d{1})?");

                if (!regex1.IsMatch(coefText.Text))
                {
                    throw new Exception("Entrez un coeff valide.");
                }


                String libelle = this.libelleText.Text;
                int duree = Convert.ToInt32(this.dureeText.Text);
                int coef = Convert.ToInt32(this.coefText.Text);

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Module(Libelle, Duree, Coef)" +
                    "values('" + libelle + "'," + duree + "," + coef + ")";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le module a ete bien ajouter.");
                libelleText.Clear(); dureeText.Clear(); coefText.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            libelleText.Enabled = true;
            this.rechercherText.Clear();
            this.libelleText.Clear();
            this.dureeText.Clear();
            this.coefText.Clear();
        }
    }
}
