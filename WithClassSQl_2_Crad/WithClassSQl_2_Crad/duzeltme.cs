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
   
    public partial class duzeltme : Form
    {
        VeriTabani vt = new VeriTabani();
        public duzeltme()
        {
            InitializeComponent();
        }
        

        private void btnguncelle_Click(object sender, EventArgs e)
        {


            string ID = dgvguncellekisiler.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet;
            if (cmbcinsiyet.Text == "Erkek")
            {
                
                cinsiyet = "E";
            }
            else
            {
                cinsiyet = "K";
            }
            vt.duzenle(ID, txttc.Text, txtad.Text, txtsoyad.Text, cinsiyet, txtadres.Text, txttelefon.Text, txtmail.Text);
            dgvguncellekisiler.DataSource = vt.hastalariListele();


        }

        private void btnduzenlekapat_Click(object sender, EventArgs e)
        {
            FormAna anaform = new FormAna();
            anaform.Show();
            this.Hide();
        }

        private void duzeltme_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnduzenlekapat.PerformClick();
        }

        private void duzeltme_Load(object sender, EventArgs e)
        {
            dgvguncellekisiler.DataSource = vt.hastalariListele();
            kisileriaktar();
        }
        void kisileriaktar()
        {
          
            txtad.Text = dgvguncellekisiler.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dgvguncellekisiler.CurrentRow.Cells[3].Value.ToString();
            txtmail.Text = dgvguncellekisiler.CurrentRow.Cells[7].Value.ToString();
            txtadres.Text = dgvguncellekisiler.CurrentRow.Cells[5].Value.ToString();
            txttc.Text = dgvguncellekisiler.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dgvguncellekisiler.CurrentRow.Cells[6].Value.ToString();

            if (dgvguncellekisiler.CurrentRow.Cells[4].Value.ToString() == "E")
            {
                cmbcinsiyet.Text = "Erkek";

            }
            else
            {
                cmbcinsiyet.Text = "KADIN";

            }
            
        }

        private void dgvguncellekisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kisileriaktar();
        }
    }
}
