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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        String baglantiAdresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Srehber;User=sa;Pwd=123";
        String Sqlkomutlari;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataviewKisiler();
        }
        void DataviewKisiler()
        {
            Sqlkomutlari = @"SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiAdresi);
            adapter = new SqlDataAdapter(Sqlkomutlari,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
        }
        
        void TablodanAktar()
        {
            lblID.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtisim.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtsoyisim.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="E")
            {
               // MessageBox.Show("test");
                rdberkek.Checked = true;
            }
            else
            {
                rdbkadin.Checked = true;
            }
            txttel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvKisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void duzenle()
        {
            string ID = lblID.Text;
            string ad = txtisim.Text;
            string soyisim = txtsoyisim.Text;
            string tel = txttel.Text;
            string cinsiyet;
            if (rdberkek.Checked==true)
            {
                 cinsiyet = "E";
            }
            else
            {
                 cinsiyet = "K";
            }
            Sqlkomutlari = $"UPDATE tblKisiler SET  AD='{ad}',Soyad='{soyisim}',telefon='{tel}',cinsiyet='{cinsiyet}' WHERE ID='{ID}'";
            baglanti = new SqlConnection(baglantiAdresi);
            komut = new SqlCommand(Sqlkomutlari,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            DataviewKisiler();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            duzenle();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TablodanAktar();
        }

        void arama()
        {
            string bul = txtara.Text;
            Sqlkomutlari = $"SELECT* FROM  tblKisiler WHERE AD = '{bul}'OR Soyad = '{bul}' or Cinsiyet = '{bul}' or telefon = '{bul}' ";
            baglanti = new SqlConnection(baglantiAdresi);
            adapter = new SqlDataAdapter(Sqlkomutlari, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;


        }

        private void btnara_Click(object sender, EventArgs e)
        {
            arama();
        }
    }
}
