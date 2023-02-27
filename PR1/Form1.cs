using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[100];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = rnd.Next(0, 1000);
                listBox1.Items.Add(a[i]);
            }
        }
    }
}
