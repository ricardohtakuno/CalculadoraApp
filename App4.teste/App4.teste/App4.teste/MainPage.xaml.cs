using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4.teste
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void btnCalcular(object sender, System.EventArgs e)
        {
            double ValorTotal = double.Parse(txtValorTotal.Text);
            int NumeroParcelas = Convert.ToInt32(txtNumeroParcelas.Text);
            double Desconto = double.Parse(txtDesconto.Text);
            double Acrescimo = double.Parse(txtAcrescimo.Text);
            double Porcentagem = double.Parse(txtPorcentagem.Text);
            double ValorPagar = double.Parse(txtValorPagar.Text);
            double ValorParcelas = double.Parse(txtValorParcelas.Text);

            double ValorPorcentagem;
            if(txtPorcentagem.Text.Length >= 1)
            {
                ValorPorcentagem = double.Parse(txtPorcentagem.Text);
            }
            else
            {
                ValorPorcentagem = 0;
            }
            double porcentagem = (ValorTotal * ValorPorcentagem) / 100;

            if(txtDesconto.Text == "")
            {
                ValorPagar = ValorTotal - porcentagem;
                ValorParcelas = ValorPagar / NumeroParcelas;
                txtValorPagar.Text = ValorPagar.ToString();
                txtValorParcelas.Text = ValorParcelas.ToString();
                //return;
            }

            if(txtAcrescimo.Text == "")
            {
                ValorPagar = ValorTotal + porcentagem;
                ValorParcelas = ValorPagar / NumeroParcelas;
                txtValorPagar.Text = ValorPagar.ToString();
                txtValorParcelas.Text = ValorParcelas.ToString();
                //return;
            }

            ValorParcelas = ValorTotal / NumeroParcelas;

            txtValorPagar.Text = ValorTotal.ToString();
            txtValorParcelas.Text = ValorParcelas.ToString();
        }
	}
}
