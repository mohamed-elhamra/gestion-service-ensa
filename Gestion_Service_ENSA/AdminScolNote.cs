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
    public partial class AdminScolNote : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminScolNote()
        {
            InitializeComponent();
        }

        public void fct()
        {
            this.etud.Hide();
            this.modules.Hide();
            this.metroLabel1.Hide();
            this.metroLabel2.Hide();
            this.groupBox1.Hide();

            connection.Open();
            SqlDataReader myReader3 = null;
            SqlCommand myCommand2 = new SqlCommand("select * from Professeur", connection);
            myReader3 = myCommand2.ExecuteReader();
            while (myReader3.Read())
            {
                pr.Items.Add(myReader3["Id_prof"].ToString() + " - " + myReader3["Nom"].ToString());
            }
            connection.Close();
        }

        private void AdminScolNote_Load(object sender, EventArgs e)
        {
            fct();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob gla = new AdminScolGlob();
            gla.Show();
        }

        private void pr_SelectedIndexChanged(object sender, EventArgs e)
        {
            modules.Items.Clear();
            this.modules.Show();
            this.metroLabel2.Show();

            connection.Open();
            int prof = int.Parse(pr.SelectedItem.ToString().Split('-')[0]);
            SqlDataReader myReader11 = null;
            SqlCommand myCommand21 = new SqlCommand("select * from Module,Professeur,Affectation where Module.Id_m=Affectation.Id_mod and Professeur.Id_prof=Affectation.Id_pr and Professeur.Id_prof = " + prof + " ", connection);
            myReader11 = myCommand21.ExecuteReader();
            while (myReader11.Read())
            {
                modules.Items.Add(myReader11["Id_m"].ToString() + " - " + myReader11["Libelle"].ToString());
            }
            connection.Close();
        }

        private void modules_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.note.Clear();
            this.dateexam.Clear();
            this.etud.Show();
            this.metroLabel1.Show();
            this.etud.Items.Clear();
            connection.Open();
            int mod = int.Parse(modules.SelectedItem.ToString().Split('-')[0]);
            SqlDataReader myReader14 = null;
            SqlCommand myCommand14 = new SqlCommand("select * from Etudiant,EtudMod where Etudiant.Id=EtudMod.Id_Etud and EtudMod.Id_module = " + mod + " ", connection);
            myReader14 = myCommand14.ExecuteReader();
            while (myReader14.Read())
            {
                etud.Items.Add(myReader14["Id"].ToString()+ "- " + myReader14["CNE"].ToString());
            }
            connection.Close();
        }

        private void etud_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.groupBox1.Show();
            connection.Open();
            int etud = int.Parse(this.etud.SelectedItem.ToString().Split('-')[0]);
            int mod = int.Parse(this.modules.SelectedItem.ToString().Split('-')[0]);
            SqlDataReader myReader11 = null;
            SqlCommand myCommand21 = new SqlCommand("select * from Examen where IdEtud = " +
                etud + " and IdMod = " + mod, connection);
            myReader11 = myCommand21.ExecuteReader();
            while (myReader11.Read())
            {
                this.note.Text = myReader11["Note_Ex"].ToString();
                this.dateexam.Text = myReader11["Date_Ex"].ToString();
            }
            connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int idetud = int.Parse(this.etud.SelectedItem.ToString().Split('-')[0]);
            int idmod = int.Parse(this.modules.SelectedItem.ToString().Split('-')[0]);

            try
            {
                if (note.Text == "" || dateexam.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(dateexam.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex3 = new Regex("^[0-9]{1,2}$");

                if (!regex3.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }


                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Examen values (" + idetud + "," + idmod + ",'" + dateexam.Text + "','" + note.Text + "' );";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
                this.dateexam.Clear(); this.note.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }


        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.pr.Items.Clear();
            fct();

            this.note.Clear();
            this.dateexam.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (note.Text == "" || dateexam.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(dateexam.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex3 = new Regex("^[0-9]{1,2}$");

                if (!regex3.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                if (MessageBox.Show("Etes-vous sur de vouloir modifier cette note ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "update Examen set Date_Ex = '" + this.dateexam.Text + "'," +
                        "Note_Ex = '" + this.note.Text + "'" +
                        " where IdEtud = " + int.Parse(this.etud.SelectedItem.ToString().Split('-')[0]) + "" +
                        " and IdMod = " + int.Parse(this.modules.SelectedItem.ToString().Split('-')[0]) + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La note a ete bien modifie.", "Message");
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pr.Items.Clear();
            fct();

            this.note.Clear();
            this.dateexam.Clear();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            int idetud = int.Parse(this.etud.SelectedItem.ToString().Split('-')[0]);
            int idmod = int.Parse(this.modules.SelectedItem.ToString().Split('-')[0]);

            try
            {
                if (note.Text == "" || dateexam.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(dateexam.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex3 = new Regex("^[0-9]{1,2}$");

                if (!regex3.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }


                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Examen values (" + idetud + "," + idmod + ",'" + dateexam.Text + "','" + note.Text + "' );";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
                this.dateexam.Clear(); this.note.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (note.Text == "" || dateexam.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(dateexam.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                Regex regex3 = new Regex("^[0-9]{1,2}$");

                if (!regex3.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                if (MessageBox.Show("Etes-vous sur de vouloir modifier cette note ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "update Examen set Date_Ex = '" + this.dateexam.Text + "'," +
                        "Note_Ex = '" + this.note.Text + "'" +
                        " where IdEtud = " + int.Parse(this.etud.SelectedItem.ToString().Split('-')[0]) + "" +
                        " and IdMod = " + int.Parse(this.modules.SelectedItem.ToString().Split('-')[0]) + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La note a ete bien modifie.", "Message");
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolGlob gla = new AdminScolGlob();
            gla.Show();
        }
    }
}
