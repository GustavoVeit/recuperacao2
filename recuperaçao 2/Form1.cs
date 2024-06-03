using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperaçao_2
{
    public partial class btnCalculo : Form
    {
        public btnCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcularH_Click(object sender, EventArgs e)
        {

            

            if (rbHomem.Checked )
            {

                double alturaH = Convert.ToDouble(txtAlturaH.Text);
                double pesoH = Convert.ToDouble(txtPesoH.Text);
                double resultadoH = pesoH / (alturaH * alturaH);

                MessageBox.Show("resultado é: " + resultadoH);
            }
            
            else if (rbMulher.Checked)
            {
                double alturaM = Convert.ToDouble(txtAlturaM.Text);
                double pesoM = Convert.ToDouble(txtPesoM.Text);
                double resultadoM = pesoM / (alturaM * alturaM);

                MessageBox.Show("resultado é: " + resultadoM);
            }
            else
            {
                MessageBox.Show("");
            }

        }

    }
}
