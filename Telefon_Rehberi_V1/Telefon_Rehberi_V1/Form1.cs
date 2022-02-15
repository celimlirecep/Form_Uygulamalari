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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;// birden fazla yerde kullanabilirim
        SqlDataAdapter adapter;
        DataTable dt;
        string BaglantiCumlesi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=sRehber;User=sa;Pwd=123";
        string sorguCumlesi;
        SqlCommand komut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisilerigetir();

        }
        void Kisilerigetir()
        {
            baglanti = new SqlConnection(BaglantiCumlesi);

            sorguCumlesi = "SELECT * FROM tblKisiler";
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }
        void aktar()//dgw kisiler üzerine tıklandığında
        {           // yan tarafa ilgili kaydın degerlerini aktarmasını istiyoruz

            lblID.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            tctAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="K")
            {
                rdbKadin.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;
            }
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aktar();
        }
        void duzelt()
        {
            string ad = tctAd.Text;
            string soyad = txtSoyad.Text;
            char cinsiyet;
            if (rdbKadin.Checked==true)
            {
                cinsiyet = 'K';
            }
            else
            {
                cinsiyet = 'E';
            }
            string tel = txtTel.Text;
            string ID = lblID.Text;
            sorguCumlesi =$" UPDATE tblKisiler SET  Ad='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}',Telefon='{tel}' WHERE ID ='{ID}'";

            baglanti = new SqlConnection(BaglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kisilerigetir();

        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            duzelt();
        }
    }
}
