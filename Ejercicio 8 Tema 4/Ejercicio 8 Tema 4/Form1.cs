using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool validaNotas(int nota1, int nota2, int nota3)
        {
            bool valida = true;
            if (nota1 < 0 || nota1 > 10)
            {
                //!? Si esto se cumple, valida tiene que ser false
                valida = false;
            }
            //!? Nunca se cumplirá la condición
            //!? hay que cambiar && por ||
            if (nota2 < 0 || nota2 > 10)
            {
                valida = false;
            }
            //!? Cambiamos nota3 > 0 por nota3 < 0
            if (nota3 < 0 || nota3 > 10)
            {
                valida = false;
            }
            return valida;
        }
        int calculaMedia(int nota1, int nota2, int nota3)
        {
            int notaMedia = 0;

            //!? Hay que cambiar el orden
            //!? Descomentar la expresión
            //!? Cambiar el divisor por 3

            notaMedia = (nota1 + nota2 + nota3) / 3;

            return notaMedia;
        }
        private void validaMediaBtn_Click(object sender, EventArgs e)
        {
            int nota1;
            int nota2;
            int nota3;
            int notaMedia;
            bool valida;

            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
            nota3 = int.Parse(txtNota3.Text);

            valida = validaNotas(nota1, nota2, nota3);

            if (validaNotas(nota1, nota2, nota3) == true)
            {
                notaMedia = calculaMedia(nota1, nota2, nota3);

                MessageBox.Show("Las notas introducidas son correctas y su nota media es " + notaMedia);
            }
            else
            {
                MessageBox.Show("Las notas introducidas no son correctas.");
            }
        }
    }
}
