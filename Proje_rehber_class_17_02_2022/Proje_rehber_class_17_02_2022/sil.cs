using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_rehber_class_17_02_2022
{// REHBER UYGULAMASINDAN VERİLERİN SİLİNMESİNİ SAĞLAR
    public partial class sil : Form
    {
        veritabani vr = new veritabani();

        public sil()
        {
            InitializeComponent();
        }

        private void btncık_Click(object sender, EventArgs e)
        {
            formhastalar dz = new formhastalar();
            dz.Show();
            this.Hide();
        }

        private void sil_Load(object sender, EventArgs e)
        {
            datagoster();
        }
        void datagoster()
        {
            string sqlkomudum = "SELECT * FROM tblHastalar";
            dgvsiltablosu.DataSource = vr.DataGoster(sqlkomudum);
        }

       

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvsiltablosu.CurrentRow.Cells[0].Value.ToString();
            string sqlkomutlari = $"DELETE FROM tblHastalar WHERE ID='{ID}'";
            
            vr.islem(sqlkomutlari);
            datagoster();

        }

        private void sil_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncık.PerformClick();
        }
    }
}
