

using laboratorio2.Clases;
namespace laboratorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instanciar clase

            Perro perrito = new Perro();
            perrito.setraza ("chapina");
            MessageBox.Show(perrito.comer() );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro();
            perrito.setraza ("raza chapina");
            MessageBox.Show(perrito.respirar("esta respirando "));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro();
            perrito.setraza("raza chapina");
            MessageBox.Show(perrito.ladrando("esta ladrando"));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Perro perrito = new Perro();
            perrito.setraza("raza chapina");
            MessageBox.Show(perrito.corriendo("esta corriendo"));
        }
    }
}