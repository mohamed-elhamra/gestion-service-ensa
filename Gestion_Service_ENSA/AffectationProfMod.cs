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
    public partial class AffectationProfMod : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AffectationProfMod()
        {
            InitializeComponent();
        }

        public void fct()
        {
            module.Items.Clear();
            professeur.Items.Clear();

            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Module ", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                module.Items.Add(myReader1["Id_m"].ToString() + " - " + myReader1["Libelle"].ToString());

            }
            connection.Close();

            connection.Open();
            SqlDataReader myReader2 = null;
            SqlCommand myCommand2 = new SqlCommand("select * from  Professeur", connection);
            myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                professeur.Items.Add(myReader2["Id_prof"].ToString() + "- " + myReader2["Nom"].ToString());
                cin.Items.Add(myReader2["Id_prof"].ToString() + "- " + myReader2["Nom"].ToString());
            }
            connection.Close();
        }

        private void AffectationProfMod_Load(object sender, EventArgs e)
        {
            fct();
        }

       

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProf p = new AdminProf();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProf p = new AdminProf();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int prof = int.Parse(cin.SelectedItem.ToString().Split('-')[0]);
            List<String> list = new List<String>();

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Affectation a, Module m" +
                " WHERE a.Id_pr =" + prof + " and m.Id_m = a.Id_mod";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader["Libelle"].ToString());
                }
            }
            string value = "";
            foreach (string s in list)
            {
                value += s + "\n";
            }
            MessageBox.Show(value, "Modules");
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (professeur.Text == "" || module.Text == "" || dateText.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(dateText.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                int prof = int.Parse(professeur.SelectedItem.ToString().Split('-')[0]);
                int mod = int.Parse(module.SelectedItem.ToString().Split('-')[0]);


                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Affectation(Id_pr, Id_mod, Date_aff)" +
                    "values(" + prof + ", " + mod + ", '" + dateText.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Module a ete bien affecter.");
                professeur.Items.Clear(); module.Items.Clear();
                dateText.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void professeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
