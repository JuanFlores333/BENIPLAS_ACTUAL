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
    public partial class InterfazPrincipal : ContentPage
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        private async void CERRS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login()); /*Redireccion a la interfaz de logeo*/
        }

        private async void CI_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnFingerprint_Clicked(object sender, EventArgs e)
        {

        }
    }
}