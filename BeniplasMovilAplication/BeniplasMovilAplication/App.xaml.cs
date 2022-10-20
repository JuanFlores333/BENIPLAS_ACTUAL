using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BeniplasMovilAplication.Views;

namespace BeniplasMovilAplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login()); /*Inicializacion de la aplicacion en la interfaz login*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
