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

namespace WithClassSQl_2_Crad
{
    public partial class FormAna : Form
    {
        VeriTabani veriTabani = new VeriTabani();

       // string sqlsorgusu = @"SELECT * FROM tblHastalar";
        public FormAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  VeriTabani vt = new VeriTabani();
              vt.baglan();*/
            doldur();    

        }
        void doldur()
        {
            
            dgvHastalar.DataSource =veriTabani.hastalariListele() ;
        }

        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            form_yeni_kayit form_Yeni_ = new form_yeni_kayit();
            form_Yeni_.Show();
        }

       private void FormAna_Activated(object sender, EventArgs e)
        {
            doldur();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDuzeltme_Click(object sender, EventArgs e)
        {
            duzeltme duzeltmesayfasi = new duzeltme();
            duzeltmesayfasi.Show();
            this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}
