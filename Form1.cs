using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3equacao2grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c, x, x1, x2, d, raizd;
        string result;

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            d = (b * b) - 4 * (a * c);

            if (d < 0)
            {
                result = "Não existem raízes reais!";
            }
            else if (d == 0)
            {
                x = -b / (2 * a);
                result = "O resultado de X é: " + x;
            }
            else if (d > 0)
            {
                raizd = Math.Sqrt(d);

                x1 = (-b + raizd) / (2 * a);
                x2 = (-b - raizd) / (2 * a);
                result = "Temos que: \n X' = " + x1 + "\n X'' = " + x2;
            }

            MessageBox.Show(result, "Resultado Final da equação de 2º grau");
        }
    }
}
