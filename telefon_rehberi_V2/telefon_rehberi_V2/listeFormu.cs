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

namespace telefon_rehberi_V2
{
    public partial class listeFormu : Form
    {
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Srehber;User=sa;Pwd=123";
        SqlConnection baglanti;
        string sqlkomutlari;
        SqlDataAdapter adapter;
        SqlCommand komut;
        
        public listeFormu()
        {
            InitializeComponent();
        }

        private void listeFormu_Load(object sender, EventArgs e)
        {
            kisilerigetir();
        }

        private void  kisilerigetir()
        {
          baglanti  = new SqlConnection(baglantiadresi);
          sqlkomutlari = "SELECT * FROM tblKisiler";
            adapter = new SqlDataAdapter(sqlkomutlari,baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvkisiler.DataSource = dt;

        }

        private void kisileriaktar()
        {
            txtad.Text= dgvkisiler.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dgvkisiler.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dgvkisiler.CurrentRow.Cells[4].Value.ToString();
            cmbcinsiyet.SelectedIndex = dgvkisiler.CurrentRow.Cells[3].Value.ToString() == "E" ? 0 : 1;
        }

        private void listeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        

        private void düzenle()
        {
            string ID = dgvkisiler.CurrentRow.Cells[0].Value.ToString();
            string ad = txtad.Text;
            string soyad = txtsoyad.Text;
            string tel = txttel.Text;
            string cinsiyet = cmbcinsiyet.SelectedIndex.ToString() == "erkek" ? "E": "K";
            sqlkomutlari = $"UPDATE tblKisiler SET ad='{ad}',soyad='{soyad}',telefon='{tel}',cinsiyet='{cinsiyet}' WHERE ID ='{ID}'";
            baglanti = new SqlConnection(baglantiadresi);
            komut = new SqlCommand(sqlkomutlari,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kisilerigetir();

        }
        private void btnduzelt_Click(object sender, EventArgs e)
        {
            düzenle();
        }

        private void dgvkisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kisileriaktar();
        }

        private void sil()
        {
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}
