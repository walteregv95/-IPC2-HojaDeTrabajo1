using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _IPC2_HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Int32.Parse(textBox1.Text);
            numero2 = Int32.Parse(textBox2.Text);
            resultado = Math.Sqrt(Math.Pow(numero1,2) + Math.Pow(numero2,2));
            textBox3.Text = resultado.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto1, texto2;
            string cadena = "";
            char[] letras1, letras2;
            texto1 = textBox1.Text;
            texto2 = textBox2.Text;
            letras1 = textBox1.Text.ToCharArray();
            letras2 = textBox2.Text.ToCharArray();

            for (int i = letras1.Length-1; i >=0; i--)
            {
                cadena += letras1[i].ToString();
            }
            cadena += "  ";
            for (int i = letras2.Length-1; i >=0; i--)
            {
                cadena += letras2[i].ToString();
            }

            textBox3.Text = cadena+ "  201504403";   

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, resultado;
            numero1 = Int32.Parse(textBox1.Text);
            numero2 = Int32.Parse(textBox2.Text);
            numero3 = Int32.Parse(textBox3.Text);

            resultado = (numero3 * numero2) / numero1;
            textBox4.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = textBox1.Text;
            if ((cadena.Contains('a') || cadena.Contains('A')) && (cadena.Contains('e') || cadena.Contains('E')) && (cadena.Contains('i') || cadena.Contains('I')) && (cadena.Contains('o') || cadena.Contains('O')) && (cadena.Contains('u') || cadena.Contains('U')))
            {
                textBox4.Text = "CUMPLE ";
            }
            else
            {
                textBox4.Text = "NO CUMPLE";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
