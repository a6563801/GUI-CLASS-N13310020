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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text == "點三小")
                    btn_ClickMe.Text = "按我一下";
            else if (btn_ClickMe.Text == "按我一下")
                    btn_ClickMe.Text = "點三小";
        }

        private void button_ChangeButton_Click(object sender, EventArgs e)
        {
            lab_changebutton.Text="你還真的按?";
        }

        private void button_conter_Click(object sender, EventArgs e)
        {
            String count = label_conter.Text;
            int sum = Int32.Parse(count)+1;
            label_conter.Text = sum.ToString();
        }
    }
}
