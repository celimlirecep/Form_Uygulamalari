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
    
    public partial class formrandevugoster : Form
    {
        veritabani vr = new veritabani();

        public formrandevugoster()
        {
            InitializeComponent();
        }

        private void formrandevugoster_Load(object sender, EventArgs e)
        {
            string sorgucumlesi = $"SELECT MAX(ID) FROM tblRandevular";
            vr.islem(sorgucumlesi);
            lblhastadi.
            
            
            

           // string hastaID
             sorgucumlesi = "USE sHastane " +
                "SELECT tblBolumler.bolumıd AS 'Bölum Adı',tbldoktorlar.adsoyad AS 'Doktor Adı',tblhastalar.ad+' '+tblhastalar.soyad AS 'Hasta Adı',tblrandevular.tarih AS 'Randevu Tarihi',tblRandevular.SAAT AS 'Randevu Saati'" +
                "FROM tblBolumler INNER JOIN tblDoktorlar" +
                " ON tblBolumler.ID=tblDoktorlar.BolumID INNER JOIN tblRandevular" +
                " ON tblRandevular.DOKTORLARID=tblDoktorlar.ID INNER JOIN tblHastalar" +
                " ON tblHastalar.ID=tblRandevular.HASTAID ";
            vr.islem(sorgucumlesi);



            //MAX(tblRandevular.ID),
            //    WHERE tblRandevular.HASTAID = '{hastaID}'
        }

        private void btnYenidenDüzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
