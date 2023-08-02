using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonnaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            if (int.TryParse(textBox1.Text, out N))
            {
                int sayi1 = 0, sayi2 = 1, sayi3;
                listBox1.Items.Add(sayi1);
                listBox1.Items.Add(sayi2);
                for (int i = 0; i < (N-2); i++)
                {
                    sayi3 = sayi1 + sayi2;
                    listBox1.Items.Add(sayi3);
                    sayi1 = sayi2;
                    sayi2 = sayi3;
                }
            }
            else
            {
                MessageBox.Show("N için tamsayı ifade giriniz");
            }
            
        }
    }
}
