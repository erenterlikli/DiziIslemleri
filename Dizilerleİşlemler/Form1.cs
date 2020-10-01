using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizilerleİşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            Temizle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for(int i=0; i<listBox1.Items.Count; i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
               
            }
            Array.Sort(sayilar); //küçükten büyüğe sıralar.
            label6.Text = sayilar[sayilar.Length - 1].ToString();
            Temizle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(sayilar);
            label7.Text = sayilar[0].ToString();
            Temizle();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
              
            }
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam = toplam + sayi;
                label8.Text = toplam.ToString();
            }
            Temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            int toplam = 0;
            int ortalama = 0;
            foreach(int sayi in sayilar)
            {
                toplam = toplam + sayi;
                ortalama = toplam / (sayilar.Length);
                label9.Text = ortalama.ToString();
            }
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for(int i=0; i<listBox1.Items.Count;i++)
            {
                sayilar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            foreach(int sayi in sayilar)
            {
                if(sayi%2== 0)
                {
                    listBox2.Items.Add(sayi);
                }
                else
                {
                    listBox3.Items.Add(sayi);
                }
                
            }
            Temizle();
        }
    }
}
