using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SampleClass benimSinifim = new SampleClass();
            MessageBox.Show(benimSinifim.AdSoyad);
           MessageBox.Show("Hos Geldin" +benimSinifim.AdSoyad);
            int sonuc = benimSinifim.Topla(456, 300);
            MessageBox.Show($"Sonuc={sonuc}");
        }
    }
}
