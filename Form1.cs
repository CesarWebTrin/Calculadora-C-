using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        //double numero1, numero2, resultado;
        string operador;
        int numero = 0;
        bool validar = false;
        

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtResultado.Text = txtResultado.Text + bt.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label1.Text = "";
            numero = 0;
            validar = false;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                numero = numero + Convert.ToInt32(txtResultado.Text);
                label1.Text  = Convert.ToString(numero) + "+";
                txtResultado.Text   = "";
                operador = "+";

            }
            else
            {
                label1.Text = txtResultado.Text + btnAdicao.Text;
                numero = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                numero = numero - Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(numero) + "-";
                txtResultado.Text = "";
                operador = "-";

            }
            else
            {
                label1.Text = txtResultado.Text + btnMenos.Text;
                numero = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                numero = numero * Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(numero) + "*";
                txtResultado.Text = "";
                operador = "*";

            }
            else
            {
                label1.Text = txtResultado.Text + btnMultiplicacao.Text;
                numero = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                numero = numero / Convert.ToInt32(txtResultado.Text);
                label1.Text = "/" + Convert.ToString(numero);
                txtResultado.Text = "";
                operador = "/";

            }
            else
            {
                label1.Text = txtResultado.Text + btnDivisao.Text;
                numero = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {


            switch (operador)
            {
                case "+":
                    {
                        label1.Text = "=" + label1.Text + txtResultado.Text ;
                        txtResultado.Text = Convert.ToString(numero + Convert.ToInt32(txtResultado.Text));
                        break;
                    }
                case "-":
                    {
                        label1.Text = "=" + label1.Text + txtResultado.Text ;
                        txtResultado.Text = Convert.ToString(numero - Convert.ToInt32(txtResultado.Text));
                        break;
                    }
                case "*":
                    {
                        label1.Text = "=" + label1.Text + txtResultado.Text ;
                        txtResultado.Text = Convert.ToString(numero * Convert.ToInt32(txtResultado.Text));
                        break;
                    }
                case "/":
                    {
                        label1.Text = "=" + label1.Text + txtResultado.Text ;
                        txtResultado.Text = Convert.ToString(numero / Convert.ToInt32(txtResultado.Text));
                        break;
                    }
            }

        }

        
    }
}

