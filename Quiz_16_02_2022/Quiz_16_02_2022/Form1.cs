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

namespace Quiz_16_02_2022
{
    public partial class Form1 : Form
    {
        string BaglantiCumlesi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=sRehber;User=sa;Pwd=123";
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        string sqlkomutlari;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisileriaktar();
        }

        private void kisileriaktar()
        {
            baglanti = new SqlConnection(BaglantiCumlesi);
            sqlkomutlari = "SELECT * FROM tblKisiler";
            adapter = new SqlDataAdapter(sqlkomutlari, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;



        }
    }
}
