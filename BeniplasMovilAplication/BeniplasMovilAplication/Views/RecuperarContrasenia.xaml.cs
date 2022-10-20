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
    public partial class RecuperarContrasenia : ContentPage
    {
        public RecuperarContrasenia()
        {
            InitializeComponent();
        }

        

        async private void InS_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login()); /*Redirección a la interfaz de logeo*/
        }
    }
}