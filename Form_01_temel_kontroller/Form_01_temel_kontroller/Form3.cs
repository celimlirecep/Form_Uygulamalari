using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01_temel_kontroller
{
    public partial class Form3 : Form
    {
       // string cinsiyet = "";
        
        public Form3()
        {
            InitializeComponent();
            rdbKadin.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string cinsiyetbelirle()
        {
            if (rdbKadin.Checked==true)
            {
                return  "kadin";
            }
            else
            {
                return "erkek";
            }

        }
        void ekle()
        {

            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text;//lvi nin text özelliği birinci kolon
            lvi.SubItems.Add(cinsiyetbelirle());
            lsvKisiler.Items.Add(lvi);
            txtAdSoyad.ResetText();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekle();

        }
    }
}
