using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class AdminScolarGroupe : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminScolarGroupe()
        {
            InitializeComponent();
        }

        public void fct()
        {
            libelle.Items.Clear();
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Groupe", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                libelle.Items.Add(myReader1["Id_gp"].ToString() + "- " + myReader1["Libelle_gp"].ToString());

            }
            connection.Close();
        }

        private void AdminScolGroupe_Load(object sender, EventArgs e)
        {
            fct();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            libelleText.Clear();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                this.libelle.Items.Clear();
                string libelle = this.libelleText.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Groupe(Libelle_gp)" +
                    "values('" + libelle + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le Groupe a ete bien ajouter.");
                libelleText.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(libelle.SelectedItem.ToString().Split('-')[0]);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce groupe?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Groupe where Id_gp = '" + id + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Groupe a ete bien supprimer.", "Message");
            }
            fct();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob g = new AdminScolGlob();
            g.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = int.Parse(libelle.SelectedItem.ToString().Split('-')[0]);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer ce groupe?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Groupe where Id_gp = '" + id + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Groupe a ete bien supprimer.", "Message");
            }
            fct();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "")
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                this.libelle.Items.Clear();
                string libelle = this.libelleText.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Groupe(Libelle_gp)" +
                    "values('" + libelle + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Le Groupe a ete bien ajouter.");
                libelleText.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            libelleText.Clear();
        }
    }
}
