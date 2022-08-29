using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentalRefuerzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double suma = 0;
            double resta = 0;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            comboSuma.Items.Clear();
            comboSuma.Items.Add("La suma es: "+suma);
            listResta.Items.Add("La resta es: "+resta);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (comboSuma.Text != "")
            {
                MessageBox.Show(comboSuma.Text);
            }
            else 
            {
                MessageBox.Show("Usted no selecciono ninguna opción");
            }
        }
    }
}
