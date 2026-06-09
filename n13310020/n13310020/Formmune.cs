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
    public partial class Formmune : Form
    {
        public Formmune()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if(temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                    } 


                }
            }
        }
    }
}
