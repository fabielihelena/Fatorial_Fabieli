using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //iterativa - for normal
        static double Iterativa(double n)
        {
            double result = 1;

            for (int i = 1; i <= n; i++) {
                result = result * i;
            }
            return result;
        }
        //recursiva - chama ela mesma
        static double Recursiva(double n) 
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Recursiva(n - 1);
        }

        private void Interativa_Click(object sender, EventArgs e)
        {
            label1.Text = (Iterativa(double.Parse(numeros.Text))).ToString();
        }

        private void Recursiva_click(object sender, EventArgs e)
        {
            label1.Text = (Recursiva(double.Parse(numeros.Text))).ToString();
        }
       
       }
}
