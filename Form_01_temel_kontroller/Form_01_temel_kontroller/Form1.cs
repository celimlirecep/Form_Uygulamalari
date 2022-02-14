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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
           // lblsayi.Text = txtSayi.Text;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar.ToString()=="A")
            {
                MessageBox.Show("Büyük A harfine bastiniz");
            }
            else
            {
                MessageBox.Show("olmadi yar, su testisi dolmadi yar");
            }*/
            if (!(char.IsDigit(e.KeyChar)||  e.KeyChar==(char)Keys.Back ))
            {
                e.Handled = true;
              //  MessageBox.Show("evet bir rakam yazdiniz");
            }
          /*  else
            {
              //  MessageBox.Show("rakam dısında bişey yazdınız");
            }*/
        }

       

        private void txtHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space));
        }

        private void txtBuyukharf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!(char.IsUpper(e.KeyChar) || e.KeyChar == (char)Keys.Back||e.KeyChar==(char)Keys.Space));
        }
        void doldur()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("mobil programlama");
            comboBox1.Items.Add("web programlama");
            comboBox1.Items.Add("deskop progrmalama");
            comboBox1.Items.Add("oyun programlama");



        }
        void doldur2()
        {
            string[] iller = { "istanbul", "ankara", "izmir", "SİVAS" };
            
            comboBox2.Items.AddRange(iller);
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  rdbEvet.Checked = true;
            doldur();
            doldur2();
        }
      

        private void rdbEvet_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        void kontrolEt()
        {
            if (rdbEvet.Checked)
            {
                lblsayi.Text = "demek evet diyorsun";
            }
            else
            {
                
                lblsayi.Text = "çok üzüldüm";
            }
        }
        private void rdbEvet_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(rdbEvet.Checked.ToString());
            kontrolEt();
          
        }

        private void rdbhayir_Click(object sender, EventArgs e)
        {
            kontrolEt();
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            btnSay form2 = new btnSay();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
