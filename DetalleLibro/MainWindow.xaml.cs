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

namespace DetalleLibro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            llenaCombo();
            creaTitulo();
            llenaGridInicio();
        }

        public void llenaCombo()
        {
            DetalleRef.Service1Client cliente = new DetalleRef.Service1Client();
            DataSet ds = cliente.ObtenerListaLibros();

            Libros.Items.Clear();

            int cont = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cont; i++)
            {
                Libros.Items.Add(ds.Tables[0].Rows[i][1].ToString());

            }

        }
        public void creaTitulo()
        {
            DetalleRef.Service1Client cliente = new DetalleRef.Service1Client();
            DataSet ds = cliente.ObtenerDetalleLibro(1);

            if (ds != null) // table is a DataTable
            {
                foreach (DataColumn col in ds.Tables[0].Columns)
                {
                    Detalle.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("[{0}]", col.ColumnName))
                      });
                }

                Detalle.DataContext = ds;
            }
        }
        private void Libros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DetalleRef.Service1Client cliente = new DetalleRef.Service1Client();
            DataSet ds = cliente.ObtenerDetalleLibro(Libros.SelectedIndex + 1);
            Detalle.AutoGenerateColumns = false;
            Detalle.ItemsSource = ds.Tables[0].DefaultView;
           
        }
        public void llenaGridInicio()
        {
            DetalleRef.Service1Client cliente = new DetalleRef.Service1Client();
            DataSet ds = cliente.ObtenerDetalleLibro(1);
            Detalle.AutoGenerateColumns = false;
            Detalle.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
