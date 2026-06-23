using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配菜,飲品,甜點\n", Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDataTime = DateTime.Now;
            string formattedDataTime = currentDataTime.ToString("yyyy/MM/dd HH:mm:ss");

            string food = "", sidefood = "", drink = "", dessert = "";

            foreach(Control c in panel1.Controls) //主食
            {
                if(c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if(temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                        food+=" "+temp.Text;
                    } 


                }
            }
            foreach (Control c in panel2.Controls)//配菜
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                        sidefood+=" "+temp.Text;
                    }


                }
            }
            foreach (Control c in panel3.Controls)//飲料
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
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
                        dessert+=" "+temp.Text;
                    }


                }
            }
            File.AppendAllText("OrderData.csv", formattedDataTime+","+food+", "+sidefood+", "+drink+", "+dessert+"\n");
            MessageBox.Show("點餐完成,慢慢等不要催");
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
