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

namespace Form_02_SQL
{
    public partial class Form3 : Form
    {
        string baglantiCumlesi = "";
        string sorguCumlesi = "";

        public Form3()
        {
            InitializeComponent();
        }
        void dataGridviewDoldur()
        {
            baglantiCumlesi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Sirket10;user=sa;Pwd=123";
            sorguCumlesi = "SELECT * FROM tblpersonel";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns["ID"].Visible = false;
            dgvPersonel.Columns[5].Visible = false;
            dgvPersonel.Columns[7].Visible = false;
            dgvPersonel.Columns[8].Visible = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridviewDoldur();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
