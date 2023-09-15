namespace Calculactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value1 = float.Parse(textBox1.Text);
            float value2 = float.Parse(textBox3.Text);
            float hasil;
            hasil = value1 + value2;
            textBox2.Text = hasil.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            float value1 = float.Parse(textBox1.Text);
            float value2 = float.Parse(textBox3.Text);
            float hasil;
            hasil = value1 - value2;
            textBox2.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float value1 = float.Parse(textBox1.Text);
            float value2 = float.Parse(textBox3.Text);
            float hasil;
            hasil = value1 * value2;
            textBox2.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float value1 = float.Parse(textBox1.Text);
            float value2 = float.Parse(textBox3.Text);
            float hasil;
            hasil = value1 / value2;
            textBox2.Text = hasil.ToString();
        }
    }
}