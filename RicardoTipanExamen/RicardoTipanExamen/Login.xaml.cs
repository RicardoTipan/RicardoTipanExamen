using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RicardoTipanExamen
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.1.5/Rest/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<RicardoTipanExamen.Ws.Datos> _post;


        string errorMessage = null;

        public MainPage()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
            var content = await client.GetStringAsync(Url);
            List<RicardoTipanExamen.Ws.Datos> posts = JsonConvert.DeserializeObject<List<RicardoTipanExamen.Ws.Datos>>(content);
            _post = new ObservableCollection<RicardoTipanExamen.Ws.Datos>(posts);
            
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

<<<<<<< HEAD
            if (txtUsu.Text == "invitado" && txtCon.Text == "invitado")
=======
            if (txtUsu.Text == "estudiante2020" && txtCon.Text == "uisrael2020")
>>>>>>> d7fc670ce8f569a8a0011fef68a19536b86600ed
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
