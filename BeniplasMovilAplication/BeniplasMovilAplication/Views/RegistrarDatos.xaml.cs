using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BeniplasMovilAplication.Models;
using HTTPupt;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeniplasMovilAplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarDatos : ContentPage
    {
        public RegistrarDatos()
        {
            InitializeComponent();
        }

        private void REG_Clicked(object sender, EventArgs e)
        {
            ActualizarEmpleado(); /*Llamado del metodo*/
        }

        //Metodo para actualizar datos
        public dynamic ActualizarDatos ()
        {
            if (ConfirmarContraR.Text == NuevaContraR.Text)
            {
                Empleado empleado = new Empleado()
                {
                    Nombre = NombreR.Text,
                    ApellidoP = ApellidoPR.Text,
                    ApellidoM = ApellidoMR.Text,
                    NumTel = long.Parse(NumCR.Text),
                    Codigo = long.Parse(IdentificadorR.Text),
                    Contrasena = ConfirmarContraR.Text,
                    EmpleadoID = 2
                };
                PeticionHTTP peticion = new PeticionHTTP("http://beniplas-001-site1.dtempurl.com/");
                string serealizedJson = JsonConvertidor.Objeto_Json(empleado);
                peticion.PedirComunicacion("Empleado/ActualizarDatos", MetodoHTTP.POST, TipoContenido.JSON);
                peticion.enviarDatos(serealizedJson);
                return bool.Parse(peticion.ObtenerJson());
            }
            else
            {
                return false;
            }
        }

        //Validación de contraseña y confirmar contraseña
        public async void ActualizarEmpleado()
        {
            var resp = ActualizarDatos();
            if (resp == true)
            {
                await DisplayAlert("", "Datos actualizados corrrectamente!", "Aceptar");
                await Navigation.PushAsync(new InterfazPrincipal()); /*Redirección a la interfaz principal*/
            }
            else
            {
                await DisplayAlert("Error", "Las contraseñas no coinciden", "Aceptar");
            }
        }
    }
}