using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class Administrateur : MetroForm
    {
        public Administrateur()
        {
            InitializeComponent();
        }

        private void Administrateur_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminProf adpr = new AdminProf();
            adpr.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminEtud a = new AdminEtud();
            a.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminAdminScolarite adad = new AdminAdminScolarite();
            adad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
