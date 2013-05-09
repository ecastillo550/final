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
        }

        Todo todo = new Todo();
        
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            svcLibreria.Service1Client cliente = new svcLibreria.Service1Client();
            //Genero.Items.Add -------------------

            todo = await cliente.ObtenerTodoAsync();
            svcLibreria.Autor autor = new svcLibreria.Autor();

            
            foreach (autor in todo){
                Autor.Items.Add(dato);
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
    }
}
