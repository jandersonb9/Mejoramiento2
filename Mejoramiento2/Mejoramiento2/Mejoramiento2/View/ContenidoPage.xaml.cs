using Mejoramiento2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mejoramiento2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContenidoPage : ContentPage
    {
        public ContenidoPage(Funcion funcion, Peliculas pelicula, int valor)
        {
            int total = valor * (funcion.Precio);
            InitializeComponent();
            stackLayout.BindingContext = funcion;
            peliculasel.BindingContext = pelicula;
            miLabel.Text = Convert.ToString(valor);
            lbltotal.Text = Convert.ToString(total);
        }

        private void Confirmar(object sender, EventArgs e)
        {
            DisplayAlert("Reservar", "Su reserva ha sido generada", "Continuar");
        }
    }
}