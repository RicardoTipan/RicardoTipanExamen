using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RicardoTipanExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro( string usuario, string contraseña)
        {
            InitializeComponent();
            
            lblUsuario.Text = usuario;

        }

        void limpiar()
        {
            txtMonIn.Text = string.Empty;
            txtMonMen.Text = string.Empty;
            txtCuo.Text = string.Empty;
        }

        private void bntCal_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                double nCuota = Convert.ToDouble(txtCuo.Text);
                double MonIn = Convert.ToDouble(txtMonIn.Text);
                double resultado = 0;
                double resultado1 = 0;
                string alerta = "";


                if (MonIn <= 1800)
                {
                    resultado = (1800-MonIn);
                    txtCuo.Text = resultado.ToString();
                }

                else if (MonIn > 1800)
                {
                    alerta = "A excedido valor";
                    DisplayAlert("A Excedido el valor Total", alerta, "Aceptar");
                }

                

                if (resultado <= 1800)
                {
                    resultado1 = ((resultado / 3)*(1.5));
                    txtMonMen.Text = resultado1.ToString();
                    
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
                
                
            }

            



        }

        private async void bntGua_Clicked(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string monini = txtMonIn.Text;
            string pagmen = txtMonMen.Text;
            await Navigation.PushAsync(new Resumen(txtNom, txtMonIn, txtMonMen, txtCuo));
            
        }



    }

}