using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace n13310020
{
    public partial class Formbtnbigger2 : Form
    {
        public Formbtnbigger2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hight = button1.Height;
            int width = button1.Width;
            button1.Size = new Size(width+10, hight+10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Int32.Parse(textBox1.Text);

            double sum = (a)*(9/5.0) + 32;
            label2.Text =sum.ToString()+"F";
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void Formbtnbigger2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
