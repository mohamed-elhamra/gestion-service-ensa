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
    public partial class AdminScolGlob : MetroForm
    {
        public AdminScolGlob()
        {
            InitializeComponent();
        }

        private void AdminScolGlob_Load(object sender, EventArgs e)
        {

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolarSpecialite sp = new AdminScolarSpecialite();
            sp.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolarGroupe gp = new AdminScolarGroupe();
            gp.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fp = new Form1();
            fp.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolNote an = new AdminScolNote();
            an.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolEtud ee = new AdminScolEtud();
            ee.Show();
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolProf ee = new AdminScolProf();
            ee.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolEtud ee = new AdminScolEtud();
            ee.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolNote an = new AdminScolNote();
            an.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolarSpecialite sp = new AdminScolarSpecialite();
            sp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolarGroupe gp = new AdminScolarGroupe();
            gp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolarModule mod = new AdminScolarModule();
            mod.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScolAbsence abs = new AdminScolAbsence();
            abs.Show();
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fp = new Form1();
            fp.Show();
        }
    }
}
