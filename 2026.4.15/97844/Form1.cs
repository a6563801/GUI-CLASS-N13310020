namespace _97844
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String count = label1.Text;
            int sum = Int32.Parse(count) + 1;
            label1.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String count = label1.Text;
            int sum = Int32.Parse(count) -1;
            label1.Text = sum.ToString();
        }
    }
}
