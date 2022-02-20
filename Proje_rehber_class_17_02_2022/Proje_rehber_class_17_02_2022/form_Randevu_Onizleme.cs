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
{
    public partial class form_Randevu_Onizleme : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;

        public form_Randevu_Onizleme()
        {
            InitializeComponent();
        }

        private void form_Randevu_Onizleme_Load(object sender, EventArgs e)
        {
            sorgucumlesi = "USE sHastane SELECT tblBolumler.bolumıd AS 'Bölum Adı',tbldoktorlar.adsoyad AS 'Doktor Adı',tblhastalar.ad+' '+tblhastalar.soyad AS 'Hasta Adı',tblrandevular.tarih AS 'Randevu Tarihi',tblRandevular.SAAT AS 'Randevu Saati'FROM tblBolumler INNER JOIN tblDoktorlar ON tblBolumler.ID=tblDoktorlar.BolumID INNER JOIN tblRandevular ON tblRandevular.DOKTORLARID=tblDoktorlar.ID INNER JOIN tblHastalar ON tblHastalar.ID=tblRandevular.HASTAID";


            dgvrandevuOnizleme.DataSource = vr.DataGoster(sorgucumlesi);

        }

        private void tblcik_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();

        }

        private void form_Randevu_Onizleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            tblcik.PerformClick();
        }
    }
}
