using ClasesAjedrezPractica1;
namespace TPAjedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            Torre torre= new Torre();
            MessageBox.Show(torre.Mover());

        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {

            Caballo caballo = new Caballo();
            MessageBox.Show(caballo.Mover());
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {


            Peon peon = new Peon();
            MessageBox.Show(peon.Mover());
        }
    }
}