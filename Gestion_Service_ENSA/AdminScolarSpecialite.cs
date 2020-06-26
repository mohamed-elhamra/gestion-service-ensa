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
    public partial class AdminScolarSpecialite : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminScolarSpecialite()
        {
            InitializeComponent();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "" )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                string libelle = this.libelleText.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Specialite(Libelle)" +
                    "values('" + libelle + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("La specialite a ete bien ajouter.");
                libelleText.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            libelleText.Clear();
        }

        private void AdminScolSpecialite_Load(object sender, EventArgs e)
        {
            fct();
        }

        public void fct()
        {
            libelle.Items.Clear();
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Specialite ", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                libelle.Items.Add(myReader1["Id_sp"].ToString() + "- " + myReader1["Libelle"].ToString());

            }
            connection.Close();
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(libelle.SelectedItem.ToString().Split('-')[0]);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette specialite?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Specialite where Id_sp = '" + id + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Specialite a ete bien supprimer.", "Message");
            }
            fct();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob g2 = new AdminScolGlob();
            g2.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob g2 = new AdminScolGlob();
            g2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(libelle.SelectedItem.ToString().Split('-')[0]);
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cette specialite?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from Specialite where Id_sp = '" + id + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Specialite a ete bien supprimer.", "Message");
            }
            fct();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (libelleText.Text == "")
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                string libelle = this.libelleText.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Specialite(Libelle)" +
                    "values('" + libelle + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("La specialite a ete bien ajouter.");
                libelleText.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            libelleText.Clear();
        }
    }
}
