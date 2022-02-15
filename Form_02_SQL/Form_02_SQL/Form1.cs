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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {



            try
            {//çalıştıılması denenecek kod
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Sirket10;User=sa;Pwd=123";
                //baglanti.ConnectionString = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Sirket10;Trusted_";
                baglanti.Open();
                baglanti.Close();
                MessageBox.Show("veri tabanına bağlanti başarili");

            }
            catch (Exception ex)
            {  //hata varsa buraya düşer
               //   MessageBox.Show("veri tabanına bağlanti başarisiz");
                MessageBox.Show(ex.Message);

                throw;
            }
           



        }
    }       
}