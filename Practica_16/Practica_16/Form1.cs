namespace Practica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);

            if (num % 2 == 0) MessageBox.Show("El Numero Es Par");
            else
                if (num % 3 == 0) MessageBox.Show("El Numero Es Impar Y Es Divisible Por 3");
            else MessageBox.Show("El Numero Es Impar Es No Divisible Por 3");
        }
    }
}
