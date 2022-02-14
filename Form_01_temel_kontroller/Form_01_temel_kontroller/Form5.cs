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
    public partial class Form5 : Form
    {
        bool baslat = true;
        string tek = "tek";
        int rasgele = 0;
        Random rgl = new Random();
        


        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             rasgele = rgl.Next(1,101);
            label1.Text = rasgele.ToString();
            

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (baslat==false)//start
            {
                timer1.Start();
                
                baslat = true;

            }
            else//stop
            {
                
                timer1.Stop();
                if ((rasgele % 2 == 0 && rdbCift.Checked == true) || ( rasgele % 2 != 0 && rdbTek.Checked == true))
                {
                    ListViewItem liste = new ListViewItem();
                    lblsonuc.Text = "bildin";
                    liste.Text = rasgele.ToString();
                    if (rasgele%2==0)
                    {
                        tek = "çift";
                    }
                   
                    liste.SubItems.Add(tek);
                    lsvSonuclar.Items.Add(liste);
                    tek = "tek";

                }
                else
                {
                    lblsonuc.Text = "bilemedin";

                }
              
                baslat =false;
                
            }

        }

      

        private void label1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
