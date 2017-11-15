using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sayisal s = new sayisal();
        int[] dizi = new int[6];
       
       
       
        int[] cevrilmis;

        

        private void button1_Click(object sender, EventArgs e)
        {
            sayibir.Text = "0";
            sayiiki.Text = "0";
            sayiuc.Text = "0";
            sayidort.Text = "0";
            sayibes.Text = "0";
            sayialti.Text = "0";
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dizi = s.terscevir(s.cek());
            sayibir.Text = dizi[0].ToString();
            sayiiki.Text = dizi[1].ToString();
            sayiuc.Text = dizi[2].ToString();
            sayidort.Text = dizi[3].ToString();
            sayibes.Text = dizi[4].ToString();
            sayialti.Text = dizi[5].ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                int adet = 0;
                int[] denden = new int[] { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) };

                for (int j = 0; j < denden.Length; j++)
                    if (s.kactane(denden[j], denden) > 1)
                        adet++;
                if (adet < 2)
                {
                    dizi = s.terscevir(denden);
                    sayibir.Text = dizi[0].ToString();
                    sayiiki.Text = dizi[1].ToString();
                    sayiuc.Text = dizi[2].ToString();
                    sayidort.Text = dizi[3].ToString();
                    sayibes.Text = dizi[4].ToString();
                    sayialti.Text = dizi[5].ToString();

                }
                else MessageBox.Show("()TÜM SAYILAR FARKLI OLMALIDIR!");

            }
            else MessageBox.Show("()TÜM ALANLARI DOLDURUNUZ");





        }
    }
}