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
    public partial class Form6 : Form
    {
        Random rnd = new Random();
        int rSayi = 0;
        int sayac = 0;
        int sure = 0;

        public Form6()
        {
            InitializeComponent();

            timerSüre.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1,100);
            lblSayi.Text = rSayi.ToString();
            
        }

        private void lblSayi_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled==true)
            {
                
                timer1.Stop();
                if ((rSayi % 2 == 0 && rdbTek.Checked==false)|| (rSayi % 2 != 0 && rdbTek.Checked == true))
                {
                    sayac++;
                    lblSonuc.Text = "bildin";
                    lstBildiklerim.Items.Add(rSayi.ToString());
                    if (sayac==2)
                    {
                        MessageBox.Show("dur");
                        timer1.Stop();
                        timer1.Enabled = false;
                        lblSayi.Enabled = false;
                        lblSonuc.Text = "geçen süre saniye : " + sure.ToString();
                       

                    }
                }
                else 
                {
                    lblSonuc.Text = "bilemedin";
                }
            }
            else
            {
                timer1.Start();
            }
            lblSonuc.ResetText();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblSayi.Enabled = true;
        }

        private void timerSüre_Tick(object sender, EventArgs e)
        {
            sure++;

        }

      
    }
}
