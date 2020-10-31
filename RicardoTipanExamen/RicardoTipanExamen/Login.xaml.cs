using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RicardoTipanExamen
{
    public partial class MainPage : ContentPage
    {
        string errorMessage = null;

        public MainPage()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtUsu.Text = string.Empty;
            txtCon.Text = string.Empty;
        }

        private async void btnIng_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsu.Text;
            string contraseña = txtCon.Text;

            if (txtUsu.Text == "est" && txtCon.Text == "uis")
            {
                await DisplayAlert("Acceso Correcto", errorMessage, "OK");
                await Navigation.PushAsync(new Registro(usuario, contraseña));
            }

            else
            {
                await DisplayAlert("Usuario o Contraseña Incorrecta", errorMessage, "OK");
                await Navigation.PushAsync(new MainPage());
                limpiar();

            }
        }
    }
}
