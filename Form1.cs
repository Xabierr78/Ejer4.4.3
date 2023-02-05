namespace Ejer4._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // programa que usa la función Math.PI
            string name ="Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            
            MessageBox.Show("Name is " + name + "\nThe value of x is " + x + "\nThe value of d is " + d);
            // Para qué sirve \n??  para hacer un salgo de linea.
            // Qué hace la función PI es una constante matematica. La llamamos usando el metodo estatico MATH.
            // cuál es el valor de la variable d? 1,5707... la mitad de el numero PI.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < 10)
            {
                cont = cont + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                cont = cont - 1;
            }
            // cuanto vale cont? vale 5.
            MessageBox.Show("La respuesta es: " + cont);
        }
    }
}