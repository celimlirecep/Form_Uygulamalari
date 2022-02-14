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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstKisiler.Items.Add(txtAdSoyad.Text.ToUpper().Trim());
           // txtAdSoyad.Clear();
            //txtAdSoyad.Text = "";
            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();
        }
    }
}
