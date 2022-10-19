using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu_Hamburguer.Model;

namespace Menu_Hamburguer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação",

                    ValoresAtitudes = "* Fortalecer a persistência e o interesse na resolução de situações-problema. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "Implementar banco de dados ",

                    ValoresAtitudes = "* Estimular a organização. * Fortalecer a persistência " +
                    "e o interesse na resolução de situações-problema. *Promover ações que considerem o respeito às normas estabelecidas.",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados ",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados. ",

                    ValoresAtitudes = "* Estimular a organização. * Incentivar a criatividade. * Fortalecer a persistência " +
                    "e o interesse na resolução de situações-problema. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",

                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",

                    ValoresAtitudes = "* Estimular a organização. * Incentivar a criatividade. * Fortalecer a persistência " +
                    "e o interesse na resolução de situações-problema. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "Desenvolver sites para Web ",

                    ValoresAtitudes = "* Incentivar a criatividade. * Estimular a organização. * Fortalecer a persistência " +
                    "e o interesse na resolução de situações-problema.",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}