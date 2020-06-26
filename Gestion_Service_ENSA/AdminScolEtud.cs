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
    public partial class AdminScolEtud : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminScolEtud()
        {
            InitializeComponent();
        }

        private void AmdinEtud_Load(object sender, EventArgs e)
        {
            this.CNE.Focus();
            connection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select Libelle from Specialite ", connection);
            myReader = myCommand.ExecuteReader();
            //string userText = MainMDI.globalstring;
            while (myReader.Read())
            {
                specialite.Items.Add(myReader["Libelle"].ToString());

            }
            connection.Close();

            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select Libelle_gp from Groupe ", connection);
            myReader1 = myCommand1.ExecuteReader();
            //string userText = MainMDI.globalstring;
            while (myReader1.Read())
            {
                group.Items.Add(myReader1["Libelle_gp"].ToString());

            }
            connection.Close();
        }

       

        private void specialite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CNE.Text == "" || nom.Text == ""
                || prenom.Text == "" || datedenaissance.Text == ""
                || email.Text == "" || tel.Text == ""
                || adresse.Text == "" || obtentionbac.Text == ""
                || sexe.Text == "" || specialite.Text == ""
                || group.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(datedenaissance.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(email.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(tel.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }

                Regex regex3 = new Regex("[0-9]{4}");

                if (!regex3.IsMatch(obtentionbac.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                connection.Open();
                SqlDataReader myReader1 = null;
                int id = 0;
                SqlCommand myCommand1 = new SqlCommand("select Id_sp from Specialite where Libelle = '" + specialite.Text + "'", connection);
                myReader1 = myCommand1.ExecuteReader();
                while (myReader1.Read())
                {
                    id = (int)myReader1["Id_sp"];

                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader2 = null;
                int id2 = 0;
                SqlCommand myCommand2 = new SqlCommand("select Id_gp from Groupe where Libelle_gp = '" + group.Text + "'", connection);
                myReader2 = myCommand2.ExecuteReader();
                while (myReader2.Read())
                {
                    id2 = (int)myReader2["Id_gp"];

                }
                connection.Close();
                if (MessageBox.Show("Etes-vous sur de vouloir modifier cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand("update Etudiant set CNE = '" + CNE.Text + "', Nom = '" + nom.Text + "', Prenom = '" + prenom.Text + "', Date_naissance = '" + datedenaissance.Text + "', Email = '" + email.Text + "', Tel = '" + tel.Text + "', Adresse = '" + adresse.Text + "', Annee_Bac = '" + obtentionbac.Text + "', Specialite_id = " + id + ", Groupe_id = " + id2 + ", Sexe = '" + sexe.Text + "' where CNE = '" + search.Text + "'", connection);
                    myReader = myCommand.ExecuteReader();
                    MessageBox.Show("Mise à jour avec succees !!");
                }
                this.CNE.Clear();
                this.nom.Clear();
                this.prenom.Clear();
                this.datedenaissance.Clear();
                this.email.Clear();
                this.tel.Clear();
                this.adresse.Clear();
                this.obtentionbac.Clear();
                this.specialite.SelectedIndex = -1;
                this.group.SelectedIndex = -1;
                this.sexe.SelectedIndex = -1;
                this.search.Clear();

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Etudiant where CNE = '" + search.Text + "'", connection);
            myReader1 = myCommand1.ExecuteReader();

            int libe = 0;
            int gpe = 0;

            while (myReader1.Read())
            {
                this.CNE.Text = myReader1["CNE"].ToString();
                this.nom.Text = myReader1["Nom"].ToString();
                this.prenom.Text = myReader1["Prenom"].ToString();
                this.datedenaissance.Text = myReader1["Date_naissance"].ToString();
                this.email.Text = myReader1["Email"].ToString();
                this.tel.Text = myReader1["Tel"].ToString();
                this.adresse.Text = myReader1["Adresse"].ToString();
                this.obtentionbac.Text = myReader1["Annee_Bac"].ToString();
                libe = (int)myReader1["Specialite_id"];
                gpe = (int)myReader1["Groupe_id"];
                this.sexe.Text = myReader1["Sexe"].ToString();

            }
            connection.Close();

            connection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select Libelle from Specialite where Id_sp = " + libe + "", connection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                this.specialite.Text = myReader["Libelle"].ToString();

            }
            connection.Close();

            connection.Open();
            SqlDataReader myReader2 = null;
            SqlCommand myCommand2 = new SqlCommand("select Libelle_gp from Groupe where Id_gp = " + gpe + "", connection);
            myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                this.group.Text = myReader2["Libelle_gp"].ToString();

            }
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader myReader2 = null;
                SqlCommand myCommand2 = new SqlCommand("delete from Etudiant where CNE = '" + search.Text + "'", connection);
                myReader2 = myCommand2.ExecuteReader();
                MessageBox.Show("Suppression d'etudiant avec succees !!");
                this.CNE.Clear();
                this.nom.Clear();
                this.prenom.Clear();
                this.datedenaissance.Clear();
                this.email.Clear();
                this.tel.Clear();
                this.adresse.Clear();
                this.obtentionbac.Clear();
                this.specialite.SelectedIndex = -1;
                this.group.SelectedIndex = -1;
                this.sexe.SelectedIndex = -1;
                this.search.Clear();

                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CNE.Clear();
            this.nom.Clear();
            this.prenom.Clear();
            this.datedenaissance.Clear();
            this.email.Clear();
            this.tel.Clear();
            this.adresse.Clear();
            this.obtentionbac.Clear();
            this.specialite.SelectedIndex = -1;
            this.group.SelectedIndex = -1;
            this.sexe.SelectedIndex = -1;
            this.search.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (CNE.Text == "" || nom.Text == ""
                || prenom.Text == "" || datedenaissance.Text == ""
                || email.Text == "" || tel.Text == ""
                || adresse.Text == "" || obtentionbac.Text == ""
                || sexe.Text == "" || specialite.Text == ""
                || group.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(datedenaissance.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex1 = new Regex("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}");

                if (!regex1.IsMatch(email.Text))
                {
                    throw new Exception("Entrez un mail valide.");
                }

                Regex regex2 = new Regex("[0-9]{10}");

                if (!regex2.IsMatch(tel.Text))
                {
                    throw new Exception("Numero tel invalide.");
                }

                Regex regex3 = new Regex("[0-9]{4}");

                if (!regex3.IsMatch(obtentionbac.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                connection.Open();

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id_sp from Specialite where Libelle = '" + specialite.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int value = 0;
                while (myReader.Read())
                {
                    value = (int)myReader["Id_sp"];
                }
                connection.Close();

                connection.Open();

                SqlDataReader myReader1 = null;
                SqlCommand myCommand1 = new SqlCommand("select Id_gp from Groupe where Libelle_gp = '" + group.Text + "' ", connection);
                myReader1 = myCommand1.ExecuteReader();
                int value1 = 0;
                while (myReader1.Read())
                {
                    value1 = (int)myReader1["Id_gp"];
                }
                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Etudiant values ('" + CNE.Text + "','"
                                                                   + nom.Text + "','"
                                                                   + prenom.Text + "','"
                                                                   + datedenaissance.Text + "','"
                                                                   + email.Text + "','"
                                                                   + tel.Text + "','"
                                                                   + adresse.Text + "','"
                                                                   + obtentionbac.Text + "',"
                                                                   + value + " , " + value1 + " , '"
                                                                   + sexe.Text + "' );";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ajout avec succes!!");
                this.CNE.Clear();
                this.nom.Clear();
                this.prenom.Clear();
                this.datedenaissance.Clear();
                this.email.Clear();
                this.tel.Clear();
                this.adresse.Clear();
                this.obtentionbac.Clear();
                this.specialite.SelectedIndex = -1;
                this.group.SelectedIndex = -1;
                this.sexe.SelectedIndex = -1;
                this.search.Clear();

                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob ad1 = new AdminScolGlob();
            ad1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AffectationModEtudAdminScol etm = new AffectationModEtudAdminScol();
            etm.Show();
        }
    }
}