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

        

        private async void bntReg_Clicked(object sender, EventArgs e)
        {
            try
            {
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

        private async void bntSig_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu());
        }
    }

}