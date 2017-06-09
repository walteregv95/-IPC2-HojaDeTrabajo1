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
    }
}
