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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e" +
                    "elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o diálogo e interlocução. * Responsabilizar-se pela produção, utilização e" +
                    "divulgação de informações. * Estimular a proatividade. ",
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
                    Nome = "Programação e Algoritmos",

                    AtribuicoesResponsabilidades = "Implementar algoritmos em linguagem de programação, utilizando ambientes de " +
                    "desenvolvimento de acordo com as necessidades. ",

                    ValoresAtitudes = "* Estimular a organização. * Incentivar atitudes de autonomia. * Fortalecer a persistência " +
                    "e o interesse na resolução de situações-problema. ",
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
                var c = new Componete
                {
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "Modelar banco de dados ",

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
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Análise e Projeto de Sistemas",

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação ",

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
                var c = new Componete
                {
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = " Desenvolver elementos gráficos para aplicativos e sites.  ",

                    ValoresAtitudes = "* Incentivar a criatividade. * Respeitar as manifestações culturais de outros povos. " +
                    "* Incentivar ações que promovam a cooperação. ",
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Programação Web I",

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
        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais. ",

                    ValoresAtitudes = "* Desenvolver a criticidade. * Incentivar comportamentos éticos. * Promover " +
                    "ações que consideram o respeito às normas estabelecidas. ",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componete
                {
                    Nome = "Técnicas de Programação",

                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas.",

                    ValoresAtitudes = "* Incentivar a criatividade. * Incentivar comportamentos éticos. * Fortalecer a persistência " +
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