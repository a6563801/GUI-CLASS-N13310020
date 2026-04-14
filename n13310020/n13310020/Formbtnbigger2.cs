using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            button1.Size = new Size(width+10,hight+10);

        }
    }
}
