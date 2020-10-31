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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnMen1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Plato1());

        }

        private void btnMen2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMen3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMen4_Clicked(object sender, EventArgs e)
        {

        }
    }
}