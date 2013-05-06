using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;


namespace LibrosGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        public static int idLibro = -1;

        public MainWindow()
        {
            InitializeComponent();
            llenaCombo();
            creaTitulo();
            llenaGridInicial();
        }

        public void llenaCombo()
        {
             cmbCat.Items.Add("Nombre Ascendente");
             cmbCat.Items.Add("Nombre Descendente");
             cmbCat.Items.Add("Autor Ascendente");
             cmbCat.Items.Add("Autor Descendente");
             cmbCat.Items.Add("País Ascendente");
             cmbCat.Items.Add("País Descendente");

        }
        public void creaTitulo()
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet ds = cliente.ObtenerListaLibros();

            if (ds != null) // table is a DataTable
            {
              
                foreach (DataColumn col in ds.Tables[0].Columns)
                { 
                    gridCosas.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("[{0}]", col.ColumnName))
                      });
                   
                }

                gridCosas.DataContext = ds;
            }
            gridCosas.Columns[0].Visibility = Visibility.Hidden;
            gridCosas.IsReadOnly = true;
        }
        public void llenaGridInicial()
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet ds = cliente.ObtenerListaLibros();
            
            gridCosas.AutoGenerateColumns = false;
            gridCosas.ItemsSource = ds.Tables[0].DefaultView;
            gridCosas.IsReadOnly = true;
        }
        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        private void AE_Autor(object sender, RoutedEventArgs e)
        {

            Autor autor = new Autor();
            autor.Show();
         
            
        }
        private void AE_Editorial(object sender, RoutedEventArgs e)
        {
            Editorial edi = new Editorial();
            edi.Show();
        }
   
        private void AE_Genero(object sender, RoutedEventArgs e)
        {
           
            
                Genero edit_Genero = new Genero();
                edit_Genero.Show();
              
                
            
        }
        private void Nuevo_Libro(object sender, RoutedEventArgs e)
        {
            Libro libr = new Libro();
            libr.Show();
        }
        private void cmbCat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();

            int index = cmbCat.SelectedIndex;
            DataSet ds = cliente.ObtenerListaLibros();
            switch (index)
            {
                case 0:
                    ds = cliente.ObtenerListaLibrosOrdenada(0,0);
                    break;
                case 1:
                    ds = cliente.ObtenerListaLibrosOrdenada(0,1);
                    break;
                case 2:
                    ds = cliente.ObtenerListaLibrosOrdenada(1,0);
                    break;
                case 3:
                    ds = cliente.ObtenerListaLibrosOrdenada(1,1);
                    break;
                case 4:
                    ds = cliente.ObtenerListaLibrosOrdenada(2,0);
                    break;
                case 5:
                    ds = cliente.ObtenerListaLibrosOrdenada(2,1);
                    break;
            }


            gridCosas.AutoGenerateColumns = false;
            gridCosas.ItemsSource = ds.Tables[0].DefaultView;
            gridCosas.IsReadOnly = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gridCosas.SelectedItem != null)
            {
                idLibro = (int)((System.Data.DataRowView)(gridCosas.SelectedItem)).Row.ItemArray[0];
                Libro libr = new Libro();
                libr.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un libro");
            }

        }
    }
}
