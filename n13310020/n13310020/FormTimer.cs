using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n13310020
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labeCounter.Text.Replace("秒", ""));
            counter+=1; //counter = counter+1;
            labeCounter.Text = counter.ToString()+"秒";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            

       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(label222.Text.Replace("秒", ""));
            counter += 1; //counter = counter+1;
            label222.Text = counter.ToString() + "秒";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label222.Text =  " 0秒"; ;
        }
    }
}
