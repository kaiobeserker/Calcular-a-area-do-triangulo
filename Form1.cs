using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_a_area_do_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bTMCALCULAR_Click(object sender, EventArgs e)
        {

            double b = double.Parse(txtalaltura.Text);
            double h = double.Parse(txtbase.Text);

            double resultado = b * h / 2;

            textBox1.Text = resultado.ToString();

        }
    }
}
