namespace hello_world
{
    public partial class Form1 : Form
    {
        private object label3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => label3.text = "hello" + textBox1.Text + "!";
    }
}