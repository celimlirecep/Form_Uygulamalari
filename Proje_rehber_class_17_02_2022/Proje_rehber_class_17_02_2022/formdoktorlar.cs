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
    public partial class formdoktorlar : Form
    {
        veritabani vt = new veritabani();
        string sorgucumlesi;
        public formdoktorlar()
        {
            InitializeComponent();
        }

        private void formdoktorlar_Load(object sender, EventArgs e)
        {
             sorgucumlesi = "SELECT * FROM tblBolumler";
            cmbbolum.DataSource = vt.DataGoster(sorgucumlesi);//***************************
            cmbbolum.DisplayMember = "BolumID";//************************gösterdiği deger
            cmbbolum.ValueMember = "ID";//**************************tablodaki degeri
        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbbolum.SelectedValue.ToString());******* ıd degerine ulaşırım
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            sorgucumlesi = $" INSERT INTO tblDoktorlar VALUES ('{txtsicilNo.Text}', '{txtadsoyad.Text}','{txttel.Text}','{txtmail.Text}','{cmbbolum.SelectedValue.ToString()}')";//******************
            vt.islem(sorgucumlesi);
        }
    }
}
