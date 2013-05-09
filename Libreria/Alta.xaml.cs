using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Libreria.svcLibreria;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Libreria
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Alta : Libreria.Common.LayoutAwarePage
    {
        public Alta()
        {
            this.InitializeComponent();
            GetDataGenero();
            GetDataAutor();
            GetDataEditorial();
        }
        private static svcLibreria.Service1Client client;
    

        public async void GetDataGenero()
        {
            client = new svcLibreria.Service1Client();
            var listaGenero = await client.ObtenerListaTodosGenerosAsync();

            foreach (var genero in listaGenero.ObtenerListaTodosGenerosResult)
            {
                //Genero GeneroObj = new Genero();
                //GeneroObj.GeneroID = genero.GeneroID;
                //GeneroObj.Nombre = genero.Nombre;
                //Genero.Items.Add(GeneroObj);
               // Genero.DataContext = genero;
               // Genero.SelectedValuePath = genero.GeneroID.ToString();
                //Genero.DisplayMemberPath = genero.Nombre.ToString();
               // Genero.SelectedIndex = 0;
               
            }


        }
        public async void GetDataAutor()
        {
            client = new svcLibreria.Service1Client();
            var listaAutores = await client.ObtenerListaAutoresAsync();

            foreach (var autor in listaAutores.ObtenerListaAutoresResult)
            {
               // Autor.Items.Add(autor.Nombre);
               // Autor.DataContext = autor;
               // Autor.SelectedValuePath = autor.AutorID.ToString();
               // Autor.DisplayMemberPath = autor.Nombre.ToString() + autor.ApPaterno.ToString();
               // Autor.SelectedIndex = 0;
            }


        }
        public async void GetDataEditorial()
        {
            client = new svcLibreria.Service1Client();
            var listaEditorial = await client.ObtenerListaEditorialesAsync();

            foreach (var editorial in listaEditorial.ObtenerListaEditorialesResult)
            {
               // Editorial.Items.Add(editorial.Nombre);
               // Editorial.DataContext = editorial;
               // Editorial.SelectedValuePath = editorial.EditorialID.ToString();
               // Editorial.DisplayMemberPath = editorial.Nombre.ToString();
               // Editorial.SelectedIndex = 0;
            }


        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private async void btnalta_Click(object sender, RoutedEventArgs e)
        {
            
            client = new svcLibreria.Service1Client();
            await client.NuevoLibroAsync(" nombre", 1, 1, 1,"idioma","pais", 200,"Assets/Libro/jp.jpg","desc");
           
        }
    }
}
