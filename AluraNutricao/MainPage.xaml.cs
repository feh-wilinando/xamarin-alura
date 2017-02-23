using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AluraNutricao
{
	public partial class MainPage : ContentPage
	{
		public double width { get; private set; }

		public double height { get; private set;}

		public MainPage()
		{
			InitializeComponent();
		}

		void Salvar_Clicked(object sender, EventArgs e)
		{
			Refeicao refeicao = this.DoFormularioParaRefeicao();

			var mensagem = String.Format("A refeição {0} de {1} calorias foi salva com sucesso.", refeicao.Descricao, refeicao.Calorias);

			DisplayAlert("Salvar Refeição", mensagem, "Ok");

			this.Clear();
		}

		void CaloriasSlider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			Slider slider = (Slider)sender;

			labelCalorias.Text = String.Format("Calorias {0}", Math.Round(slider.Value, 2) );

		}

		Refeicao DoFormularioParaRefeicao()
		{
			string descricao = textDescricao.Text;
			double calorias = sliderCalorias.Value;
			return new Refeicao(descricao, calorias);
		}

		void Clear()
		{
			textDescricao.Text = "";
			sliderCalorias.Value = 0;
		}

	}
}
