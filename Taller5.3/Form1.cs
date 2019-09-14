using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int i;
            int num;
            a = 0;
            b = 1;

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);

            num = Convert.ToInt32(txtnumeros.Text);

           

            for (i=3; i <= num; i++)
            {

                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
