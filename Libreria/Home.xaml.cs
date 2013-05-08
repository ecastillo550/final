using Libreria.Data;
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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Libreria
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Home : Libreria.Common.LayoutAwarePage
    {
        public static int tipo = 0;
        public static int vista = 0;
        public Home()
        {
            tipo = 0;
            this.InitializeComponent();
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

        private void AppbarLibroB(object sender, RoutedEventArgs e)
        {


        }

        private void StackPanel_GotFocus_1(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(GroupedItemsPage), pageTitle.Text);
            tipo = 1;
        }

        private void StackPanel_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {
            tipo = 1;
            if (vistacmb.SelectedIndex == 0)
            {
                this.Frame.Navigate(typeof(ItemsPage), "AllGroups");
            }
            else {
                
                this.Frame.Navigate(typeof(GroupedItemsPage), "AllGroups"); 
            
            }


            
            
            
        }

        private void StackPanel_PointerPressed_2(object sender, PointerRoutedEventArgs e)
        {
            tipo = 2;
            if (vistacmb.SelectedIndex == 0)
            {
                this.Frame.Navigate(typeof(ItemsPage), "AllGroups");
            }
            else
            {

                this.Frame.Navigate(typeof(GroupedItemsPage), "AllGroups");

            }
        }
        private void StackPanel_PointerPressed_3(object sender, PointerRoutedEventArgs e)
        {
            tipo = 3;
            if (vistacmb.SelectedIndex == 0)
            {
                this.Frame.Navigate(typeof(ItemsPage), "AllGroups");
            }
            else
            {

                this.Frame.Navigate(typeof(GroupedItemsPage), "AllGroups");

            }
        }
        private void StackPanel_GotFocus_2(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(GroupedItemsPage), pageTitle.Text);
            tipo = 2;
        }

        private void Menu_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            
            this.Frame.Navigate(typeof(GroupedItemsPage), "AllGroups");
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           // tipo = vistacmb.SelectedIndex;
        }
    }
}
