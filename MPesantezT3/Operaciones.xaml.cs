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
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular1_Clicked(object sender, EventArgs e)
        {
            double seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text)*0.3;
            double examen1 = Convert.ToDouble(txtExamen1.Text)*0.2;
            txtParcial1.Text = (seguimiento1 + examen1).ToString();
            txtSeguimiento1.IsEnabled = false;
            txtExamen1.IsEnabled = false;
            btnCalcular2.IsEnabled = true;
        }

        private void txtSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double seguimiento1 = 0;
            seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
            if (seguimiento1>10)
            {
                DisplayAlert("Mensaje de Alerta", "Nota de Seguimiento 1 debe estar entre 0 y 10", "Cerrar");
                txtSeguimiento1.Text = null;
                txtSeguimiento1.Focus();
            }

        }

        private void txtExamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double examen1 = 0;
            examen1 = Convert.ToDouble(txtExamen1.Text);
            if (examen1>10)
            {
                DisplayAlert("Mensaje de Alerta", "Nota de Examen 1 debe estar entre 0 y 10", "Cerrar");
                txtExamen1.Text = null;
                txtExamen1.Focus();
            }
        }

        private void btnCalcular2_Clicked(object sender, EventArgs e)
        {
            double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text)*0.3;
            double examen2 = Convert.ToDouble(txtExamen2.Text)*0.2;
            txtParcial2.Text = (seguimiento2 + examen2).ToString();
            txtSeguimiento2.IsEnabled = false;
            txtExamen2.IsEnabled = false;
            double total = Convert.ToDouble(txtParcial1.Text) + Convert.ToDouble(txtParcial2.Text);
            if (total >= 7)
            {
                txtAprobado.BackgroundColor = Color.Green;
                txtAprobado.Text = "APROBADO";
                txtAprobado.HorizontalTextAlignment = TextAlignment.Center;
                txtAprobado.TextColor = Color.White;
            }
            else
            {
                txtAprobado.BackgroundColor = Color.Red;
                txtAprobado.Text = "REPROBADO";
                txtAprobado.HorizontalTextAlignment = TextAlignment.Center;
                txtAprobado.TextColor = Color.White;
            }
            btnNuevo.IsEnabled = true;
        }

        private void txtSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double seguimiento2 = 0;
            seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
            if (seguimiento2>10)
            {
                DisplayAlert("Mensaje de Alerta", "Nota de Seguimiento 2 debe estar entre 0 y 10", "Cerrar");
                txtSeguimiento2.Text = null;
                txtSeguimiento2.Focus();
            }
        }

        private void txtExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double examen2 = 0;
            examen2 = Convert.ToDouble(txtExamen2.Text);
            if (examen2>10)
            {
                DisplayAlert("Mensaje de Alerta", "Nota de Examen 2 debe estar entre 0 y 10", "Cerrar");
                txtExamen2.Text = null;
                txtExamen2.Focus();
            }
        }

        private void btnNuevo_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Operaciones();
        }
    }
}