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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string monini, string pagmen)
        {
            InitializeComponent();

            txtnombre.Text = nombre;
         


        }

        public Resumen(Entry txtNom, Entry txtMonIn1, Entry txtMonMen1, Entry txtCuo)
        {
            TxtNom = txtNom;
            TxtMonIn = txtMonIn1;
            TxtMonMen = txtMonMen1;
            TxtCuo = txtCuo;
        }

        public Entry TxtNom { get; }
        public Entry TxtMonIn { get; }
        public Entry TxtMonMen { get; }
        public Entry TxtCuo { get; }
    }
}