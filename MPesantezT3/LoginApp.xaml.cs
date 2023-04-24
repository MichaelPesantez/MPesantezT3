using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPesantezT3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginApp : ContentPage
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario=="estudiante2023" && contrasena=="uisrael2023")
            {
                Navigation.PushAsync(new Operaciones());
            }
            else
            {
                DisplayAlert("Mensaje de Alerta", "Usuario/Contrasena Incorrecta", "Cerrar");
                txtUsuario.Text = null;
                txtContrasena.Text = null;
            }
        }
    }
}