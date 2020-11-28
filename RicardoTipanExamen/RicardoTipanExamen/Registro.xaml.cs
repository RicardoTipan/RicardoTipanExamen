using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;

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

<<<<<<< HEAD
        

        private async void bntReg_Clicked(object sender, EventArgs e)
=======
        void limpiar()
        {
            txtMonIn.Text = string.Empty;
            txtMonMen.Text = string.Empty;
            txtCuo.Text = string.Empty;
        }

        private void bntCal_Clicked(object sender, EventArgs e)
>>>>>>> d7fc670ce8f569a8a0011fef68a19536b86600ed
        {
            try
            {
<<<<<<< HEAD
                WebClient Registro = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCod.Text);
                parametros.Add("codigo", txtNom.Text);
                parametros.Add("codigo", txtApe.Text);
                parametros.Add("codigo", txtIde.Text);
                Registro.UploadValues("http://192.168.1.5/Rest/post.php", "post", parametros);
                await DisplayAlert("alerta", "Dato ingresado correctamente", "ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("alerta", "Error: " + ex.Message, "ok");
            }

        }
=======
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

            


>>>>>>> d7fc670ce8f569a8a0011fef68a19536b86600ed

        private async void bntSig_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
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