using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            // teste do GIT


            // verifica se o operador foi escolhido
            if(cmbOperador.Text != "")
            {
                int numero1 = Convert.ToInt32(txtCaixa1.Text); ; // convert o text do txtCaixa1 para int
                int numero2 = Convert.ToInt32(txtCaixa2.Text); ; // ||      ||   ||  do txtcaixa2 para int
                int resultado; // variavel do tipo int para armazenar o resultado

                // verifica se é uma soma
                if (cmbOperador.Text == "Somar")
                {

                    resultado = numero1 + numero2;
                    MessageBox.Show("O resultado da operação: " +"\n" + resultado.ToString(), "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
       //corpo do messageBox, \n quebra a linha,  converte o resultado em string para imprimir  Titulo     botoes do MessageBox        icone do MessageBox

                }

                // verifica se é uma subtração
                if (cmbOperador.Text == "Subtrair")
                {

                    resultado = numero1 - numero2;
                    MessageBox.Show(resultado.ToString(), "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }

                // verifica se é divisão
                if (cmbOperador.Text == "Dividir")
                {

                    resultado = numero1 / numero2;
                    MessageBox.Show(resultado.ToString(), "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                // verifica se é multiplicação
                if (cmbOperador.Text == "Multiplicar")
                {

                    resultado = numero1 * numero2;
                    MessageBox.Show(resultado.ToString(), "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }

            }

            // verifica se o operador esta vazio
            if (cmbOperador.Text == "")
            {
                MessageBox.Show("Operado não selecionado", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }


    }
}
