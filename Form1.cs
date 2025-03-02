using System;
using System.Drawing;
using System.Windows.Forms;

namespace Broma
{
    public partial class Form1 : Form
    {
        // Random para generar números aleatorios
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNo_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener las dimensiones del formulario
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Obtener las dimensiones del botón
            int buttonWidth = btnNo.Width;
            int buttonHeight = btnNo.Height;

            // Generar coordenadas aleatorias dentro de los límites del formulario
            int newX = random.Next(0, formWidth - buttonWidth);
            int newY = random.Next(0, formHeight - buttonHeight);

            // Asignar la nueva ubicación al botón
            btnNo.Location = new Point(newX, newY);
        }

        private void btnSi_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Disco duro eliminado");
        }
    }
}