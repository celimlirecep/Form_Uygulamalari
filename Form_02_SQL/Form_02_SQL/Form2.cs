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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        void verileriCek()
        {
           
            SqlConnection baglanti = new SqlConnection(@"Server=RECEP-CELIMLI\SQLEXPRESS;
            Database=Sirket10;User=sa;Pwd=123");
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblDepartman";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                int ID =(int) dr["ID"];
                String departmanAd = dr["DepartmanAd"].ToString();
                lstDepartman.Items.Add($"{ID}\t{departmanAd}");
            }



            baglanti.Close();
            
           
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            verileriCek();
        }
    }
}
