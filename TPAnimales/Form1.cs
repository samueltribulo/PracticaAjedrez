using ClasesAnimales;

namespace TPAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLeon_Click(object sender, EventArgs e)
        {

            Leon samu = new Leon(10, 1.3, 154.5);

            MessageBox.Show($"{samu.PrintProps()} \n{samu.PrintFood()}");

        }

        private void btnCrearLoro_Click(object sender, EventArgs e)
        {
            Loro tomi = new Loro(9, 0.20, 1);

            MessageBox.Show($"{tomi.PrintProps()} \n{tomi.PrintFood()}");

        }

        private void btnCrearConejo_Click(object sender, EventArgs e)
        {
            Conejo martu = new Conejo(6, 0.30, 0.60);

            MessageBox.Show($"{martu.PrintProps()} \n{martu.PrintFood()}");
        }
    }
}