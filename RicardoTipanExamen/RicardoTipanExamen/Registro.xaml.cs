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

        private void bntCal_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                double nCuota = Convert.ToDouble(txtCuo.Text);
                double resultado = 0;
                if (nCuota <= 1800)
                {
                    resultado = nCuota / 1800;
                    txtCuo.Text = resultado.ToString();
                }



            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", ex.Message, "Aceptar");
            }


        }
    }
}