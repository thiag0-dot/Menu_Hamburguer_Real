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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Segurança de Sistemas de Informação ",

                    AtribuicoesResponsabilidades = "Implentar rotinas de segurança da informação. ",

                    ValoresAtitudes = "* Estimular atitudes respeitosas. * Incentivar comportamento éticos. * Desenvolver a criticidade. ",
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
                var c = new Componete
                {
                    Nome = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria ",

                    ValoresAtitudes = "* Estimular atitudes respeitosas. * Incentivar comportamento éticos. * Desenvolver a criticidade. ",
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