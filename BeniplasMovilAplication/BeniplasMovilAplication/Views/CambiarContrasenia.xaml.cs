using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeniplasMovilAplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CambiarContrasenia : ContentPage
    {
        public CambiarContrasenia()
        {
            InitializeComponent();
        }

        private async void R_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InterfazPrincipal()); /*redirección a la interfaz principal*/
        }
    }
}