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
    public partial class Prof : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\melha\OneDrive\Bureau\gestion_service_ensa-master\gestion_service_ensa-master\gestion_service_ensa-master\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True;Connect Timeout=30");

        public Prof(String value)
        {
            InitializeComponent();
            cc.Text = value;
        }

        private void Prof_Load(object sender, EventArgs e)
        {
            this.etud.Hide();
            this.metroLabel1.Hide();
            this.groupBox1.Hide();
            this.groupBox2.Hide();

            connection.Close();
            connection.Open();
            SqlDataReader myReader3 = null;
            SqlCommand myCommand2 = new SqlCommand("select Libelle from Module,Professeur,Affectation where Module.Id_m=Affectation.Id_mod and Professeur.Id_prof=Affectation.Id_pr and cinprof = '" + cc.Text + "' ", connection);
            myReader3 = myCommand2.ExecuteReader();
            while (myReader3.Read())
            {
                modules.Items.Add(myReader3["Libelle"].ToString());
            }
            connection.Close();

            

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void modules_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.etud.Items.Clear();
            this.etud.Show();
            this.metroLabel1.Show();
            this.groupBox1.Show();
            this.groupBox2.Show();

            connection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select CNE from Module,EtudMod,Etudiant where Module.Id_m=EtudMod.Id_module and EtudMod.Id_Etud=Etudiant.Id and Module.Libelle = '" + modules.Text + "' ", connection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                etud.Items.Add(myReader["CNE"].ToString());
            }
            connection.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
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

                Regex regex1 = new Regex("^[0-9]{1,2}$");

                if (!regex1.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Examen values (" + idetud + "," + idmod + ",'" + dateexam.Text + "','" + note.Text + "' );";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
           
        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {

                if (debut.Text == "" || fin.Text == "" || justi.Text ==""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(debut.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                if (!regex.IsMatch(fin.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Absence values (" + idetud + "," + idmod + ",'" + debut.Text + "','" + fin.Text + "','" + justi.Text + "' );";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
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

                Regex regex1 = new Regex("^[0-9]{1,2}$");

                if (!regex1.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                if (MessageBox.Show("Etes-vous sur de vouloir modifier cet Examen pour Cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlDataReader myReader22 = null;
                    SqlCommand myCommand22 = new SqlCommand("update Examen set IdEtud = " + idetud + ", IdMod = " + idmod + ", Date_ex = '" + dateexam.Text + "', Note_ex = '" + note.Text + "' where IdEtud = " + idetud + " and IdMod = " + idmod + "", connection);
                    myReader22 = myCommand22.ExecuteReader();
                    MessageBox.Show("Mise à jour avec succees !!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {

                if (debut.Text == "" || fin.Text == "" || justi.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(debut.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                if (!regex.IsMatch(fin.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                if (MessageBox.Show("Etes-vous sur de vouloir modifier l'Absence de cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlDataReader myReader22 = null;
                    SqlCommand myCommand22 = new SqlCommand("update Absence set IdEtud = " + idetud + ", IdMod = " + idmod + ", Date_Debut = '" + debut.Text + "', Date_Fin = '" + fin.Text + "', Justification = '" + justi.Text + "' where IdEtud = " + idetud + " and IdMod = " + idmod + "", connection);
                    myReader22 = myCommand22.ExecuteReader();
                    MessageBox.Show("Mise à jour avec succees !!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }

        }

        private void etud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                Regex regex1 = new Regex("^[0-9]{1,2}$");

                if (!regex1.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Examen values (" + idetud + "," + idmod + ",'" + dateexam.Text + "','" + note.Text + "' );";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
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

                Regex regex1 = new Regex("^[0-9]{1,2}$");

                if (!regex1.IsMatch(note.Text))
                {
                    throw new Exception("Entrez une note valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                if (MessageBox.Show("Etes-vous sur de vouloir modifier cet Examen pour Cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlDataReader myReader22 = null;
                    SqlCommand myCommand22 = new SqlCommand("update Examen set IdEtud = " + idetud + ", IdMod = " + idmod + ", Date_ex = '" + dateexam.Text + "', Note_ex = '" + note.Text + "' where IdEtud = " + idetud + " and IdMod = " + idmod + "", connection);
                    myReader22 = myCommand22.ExecuteReader();
                    MessageBox.Show("Mise à jour avec succees !!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (debut.Text == "" || fin.Text == "" || justi.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(debut.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                if (!regex.IsMatch(fin.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }



                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                connection.Open();
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Absence values (" + idetud + "," + idmod + ",'" + debut.Text + "','" + fin.Text + "','" + justi.Text + "' );";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Ajout avec Succees!!");
                connection.Close();
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

                if (debut.Text == "" || fin.Text == "" || justi.Text == ""
                )
                {
                    throw new Exception("Veuillez remplir tous les champs.");
                }

                Regex regex = new Regex("^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)[0-9]{4}$");

                if (!regex.IsMatch(debut.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                if (!regex.IsMatch(fin.Text))
                {
                    throw new Exception("Entrez une date valide.");
                }

                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select Id from Etudiant where CNE = '" + etud.Text + "' ", connection);
                myReader = myCommand.ExecuteReader();
                int idetud = 0;
                while (myReader.Read())
                {
                    idetud = (int)myReader["Id"];
                }
                connection.Close();

                connection.Open();
                SqlDataReader myReader11 = null;
                SqlCommand myCommand11 = new SqlCommand("select Id_m from Module where Libelle = '" + modules.Text + "' ", connection);
                myReader11 = myCommand11.ExecuteReader();
                int idmod = 0;
                while (myReader11.Read())
                {
                    idmod = (int)myReader11["Id_m"];
                }
                connection.Close();

                if (MessageBox.Show("Etes-vous sur de vouloir modifier l'Absence de cet Etudiant?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlDataReader myReader22 = null;
                    SqlCommand myCommand22 = new SqlCommand("update Absence set IdEtud = " + idetud + ", IdMod = " + idmod + ", Date_Debut = '" + debut.Text + "', Date_Fin = '" + fin.Text + "', Justification = '" + justi.Text + "' where IdEtud = " + idetud + " and IdMod = " + idmod + "", connection);
                    myReader22 = myCommand22.ExecuteReader();
                    MessageBox.Show("Mise à jour avec succees !!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
