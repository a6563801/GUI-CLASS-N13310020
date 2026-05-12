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
    public partial class Form_calculator : Form
    {
        public Form_calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                int[] numbers =new int[10];
                numbers[0]=1;
                numbers[1]=2;
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                int sum = a+b;
                label3.Text = (a+b).ToString();
            }catch(System.FormatException ex)
            {
                MessageBox.Show(ex.Message+"輸入整數，不要亂打低能兒");
            }catch(System.IndexOutOfRangeException ex) 
            {
                MessageBox.Show(ex.Message+"打數字 啟智兒");
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message+"你輸入不是正統阿拉伯數字，但我不知道哪裡有問題");

            }
            
        }
    }
}
