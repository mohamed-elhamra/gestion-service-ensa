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
    public partial class AffectationModEtud : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AffectationModEtud()
        {
            InitializeComponent();
        }

        public void fct()
        {
            connection.Open();
            SqlDataReader myReader2 = null;
            SqlCommand myCommand2 = new SqlCommand("select * from  Etudiant", connection);
            myReader2 = myCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                cne.Items.Add(myReader2["Id"].ToString() + " - " + myReader2["CNE"].ToString());
                cnebox.Items.Add(myReader2["Id"].ToString() + " - " + myReader2["CNE"].ToString());
            }
            connection.Close();
        }

        private void AffectationModEtud_Load(object sender, EventArgs e)
        {
            this.add.Hide();
            this.mod.Hide();
            this.module.Hide();
            fct();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cne.Text == "" || module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                int etu = int.Parse(cne.SelectedItem.ToString().Split('-')[0]);
                int mod = int.Parse(module.SelectedItem.ToString().Split('-')[0]);

                Console.WriteLine(etu); Console.WriteLine(mod);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into EtudMod(Id_module, Id_Etud)" +
                    "values(" + mod + "," + etu + ")";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Module a ete bien affecter.");
                cne.Items.Clear(); cnebox.Items.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void cne_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.add.Show();
            this.mod.Show();
            this.module.Show();
            module.Items.Clear(); 
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Module ", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                module.Items.Add(myReader1["Id_m"].ToString() + " - " + myReader1["Libelle"].ToString());
            }
            connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEtud dz = new AdminEtud();
            dz.Show();
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {
            
            int idetud = int.Parse(cnebox.SelectedItem.ToString().Split('-')[0]);
            List<String> list = new List<String>();

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from EtudMod e, Module m" +
                " WHERE e.Id_Etud =" + idetud + " and m.Id_m = e.Id_module";
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

        private void cnebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void module_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.add.Show();
            this.mod.Show();
            this.module.Show();
            module.Items.Clear();
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from Module ", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                module.Items.Add(myReader1["Id_m"].ToString() + " - " + myReader1["Libelle"].ToString());
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminEtud dz = new AdminEtud();
            dz.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int idetud = int.Parse(cnebox.SelectedItem.ToString().Split('-')[0]);
            List<String> list = new List<String>();

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from EtudMod e, Module m" +
                " WHERE e.Id_Etud =" + idetud + " and m.Id_m = e.Id_module";
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

        private void affecter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cne.Text == "" || module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                int etu = int.Parse(cne.SelectedItem.ToString().Split('-')[0]);
                int mod = int.Parse(module.SelectedItem.ToString().Split('-')[0]);

                Console.WriteLine(etu); Console.WriteLine(mod);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into EtudMod(Id_module, Id_Etud)" +
                    "values(" + mod + "," + etu + ")";
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Module a ete bien affecter.");
                cne.Items.Clear(); cnebox.Items.Clear();
                fct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

       

        private void module_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
