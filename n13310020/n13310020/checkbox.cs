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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("點三小");
            }

            
        }

        private void checkbox_Load(object sender, EventArgs e)
        {

        }
    }
}
