using Mejoramiento2.Model;
using Mejoramiento2.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mejoramiento2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listaPeliculas();
        }

        private async void listaPeliculas()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://misapis.azurewebsites.net");
            var request = await cliente.GetAsync("/api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var peliculas = JsonConvert.DeserializeObject<List<Peliculas>>(responseJson);
                listaCartelera.ItemsSource = peliculas;
            }
        }

        private async void ubicarPelicula(object sender, SelectedItemChangedEventArgs e)
        {
            var pelicula = e.SelectedItem as Peliculas;
            await Navigation.PushAsync(new FuncionesPage(pelicula));

        }
    }
}
