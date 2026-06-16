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
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                    }


                }
            }
            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                    }


                }
            }
            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                    }


                }
            }
        }
         
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
