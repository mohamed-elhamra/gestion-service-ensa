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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class EtudiantAbsenceExam : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public EtudiantAbsenceExam(String value)
        {
            InitializeComponent();
            cne.Text = value;

        }

        private void EtudiantAbsenceExam_Load(object sender, EventArgs e)
        {
            module.Items.Clear();
            

            int idE = 0;
            connection.Close();
            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select *  from Etudiant" +
                " WHERE CNE = '" + cne.Text + "'";
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    idE = (int)reader["Id"];
                }
            }

            connection.Close();

            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from EtudMod e, Module m where  " +
                "m.Id_m = e.Id_module and " +
                "e.Id_Etud = " + idE , connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                module.Items.Add(myReader1["Id_module"].ToString() + "- " + myReader1["Libelle"].ToString());

            }
            connection.Close();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                //this.module.Items.Clear();
                int idM = int.Parse(module.SelectedItem.ToString().Split('-')[0]);
                Hashtable ht = new Hashtable();
                int idE = 0;

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select *  from Etudiant" +
                    " WHERE CNE = '" + cne.Text + "';";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idE = (int)reader["Id"];
                    }
                }

                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *  from Examen" +
                    " WHERE IdMod = " + idM + "and IdEtud = " + idE;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ht.Add(reader["Date_Ex"].ToString(), reader["Note_Ex"].ToString());
                    }
                }
                string value = "";
                foreach (var key in ht.Keys)
                {
                    value += "Date examen: " + key + "  -  " + "Note: " + ht[key] + "\n";
                }
                MessageBox.Show(value, "Notes");
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void absenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                //this.module.Items.Clear();
                int idM = int.Parse(module.SelectedItem.ToString().Split('-')[0]);
                List<String> list = new List<string>();
                int idE = 0;
                string value = "";

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select *  from Etudiant" +
                    " WHERE CNE = '" + cne.Text + "';";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idE = (int)reader["Id"];
                    }
                }

                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *  from Absence" +
                    " WHERE IdMod = " + idM + "and IDEtud = " + idE;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        value = "Date debut: " + reader["Date_Debut"].ToString() + "  -  " +
                            "Date fin: " + reader["Date_Fin"].ToString() + "  -  " +
                             "Justification: " + reader["Justification"].ToString();
                        list.Add(value);
                    }
                }
                String x = "";
                foreach (var s in list)
                {
                    x += s + "\n";
                }
                MessageBox.Show(x, "Absences");
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                //this.module.Items.Clear();
                int idM = int.Parse(module.SelectedItem.ToString().Split('-')[0]);
                List<String> list = new List<string>();
                int idE = 0;
                string value = "";

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select *  from Etudiant" +
                    " WHERE CNE = '" + cne.Text + "';";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idE = (int)reader["Id"];
                    }
                }

                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *  from Absence" +
                    " WHERE IdMod = " + idM + "and IDEtud = " + idE;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        value = "Date debut: " + reader["Date_Debut"].ToString() + "  -  " +
                            "Date fin: " + reader["Date_Fin"].ToString() + "  -  " +
                             "Justification: " + reader["Justification"].ToString();
                        list.Add(value);
                    }
                }
                String x = "";
                foreach (var s in list)
                {
                    x += s + "\n";
                }
                MessageBox.Show(x, "Absences");
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (module.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                //this.module.Items.Clear();
                int idM = int.Parse(module.SelectedItem.ToString().Split('-')[0]);
                Hashtable ht = new Hashtable();
                int idE = 0;

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select *  from Etudiant" +
                    " WHERE CNE = '" + cne.Text + "';";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idE = (int)reader["Id"];
                    }
                }

                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *  from Examen" +
                    " WHERE IdMod = " + idM + "and IdEtud = " + idE;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ht.Add(reader["Date_Ex"].ToString(), reader["Note_Ex"].ToString());
                    }
                }
                string value = "";
                foreach (var key in ht.Keys)
                {
                    value += "Date examen: " + key + "  -  " + "Note: " + ht[key] + "\n";
                }
                MessageBox.Show(value, "Notes");
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gz = new Form1();
            gz.Show();
        }
    }
}
