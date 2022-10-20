using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeniplasMovilAplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Ol_Clicked(object sender, EventArgs e)
        {
            
        }

        //Lista para validación de usuario
        public async Task<string> LoginUs()
        {
            string us = UsuarioL.Text;
            string contra = ContrasenaL.Text;
            WebRequest request = WebRequest.Create("http://beniplas-001-site1.dtempurl.com/Empleado/ValidarEmpleado?user=" + us + "&contrasena=" + contra);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        // Metodo de validación de usuario
        public async void LoginUser()
        {
            try
            {
                string validar = await LoginUs();
                if (bool.Parse(validar) == true)
                {
                    await Navigation.PushAsync(new RegistrarDatos());
                    await DisplayAlert("Bienvenido", "Ingrese sus datos", "Aceptar");
                }
                else
                {
                    await DisplayAlert("Error", "Contraseña o Usuario Incorrecto", "Aceptar");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", "Sin conexión", "Aceptar");
            }
        }
        private async void In_Clicked(object sender, EventArgs e)
        {
            LoginUser(); /*Validación de usuario*/
        }
    }
}