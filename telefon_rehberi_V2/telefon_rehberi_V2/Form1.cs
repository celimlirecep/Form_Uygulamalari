using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_rehberi_V2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yeniKayitFormu = new YeniKayitFormu();
            yeniKayitFormu.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            byncikis.PerformClick();
        }

        private void byncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            listeFormu listeFormu = new listeFormu();
            listeFormu.Show();
            this.Hide();
        }
    }
}
