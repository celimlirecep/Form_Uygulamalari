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
    public partial class hocarandevuonizleme : Form
    {
        string bolumad;
        string hastaad;
         string doktorad;
         string tarih;
        public hocarandevuonizleme(string BOLUMAD,string HASTAAD,String DOKTORAD,String TARİH)
        {
           
            InitializeComponent();
             bolumad = BOLUMAD;
             hastaad = HASTAAD;
             doktorad = DOKTORAD;
             tarih = TARİH;
        }

        private void hocarandevuonizleme_Load(object sender, EventArgs e)
        {
            MessageBox.Show(bolumad);
        }
    }
}
