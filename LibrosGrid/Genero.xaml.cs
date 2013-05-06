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
using System.Windows.Shapes;
using System.Data;

namespace LibrosGrid
{
    /// <summary>
    /// Interaction logic for Genero.xaml
    /// </summary>
    public partial class Genero : Window
    {
        DataSet ds;
        int banderaUpdate = 0;
        public Genero()
        {
            InitializeComponent();

                llenaCombo();  
           
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (banderaUpdate == 0)
            {
                LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
                ds = cliente.BuscaGenero(Convert.ToInt32(cmb_libros.SelectedValue.ToString()));

                txt_nombre.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else { banderaUpdate = 0; }
            
        }
        public void llenaCombo()
        {
            
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            ds = cliente.ObtenerListaGeneros();

            //cmb_libros.Items.Clear();

            int cont = ds.Tables[0].Rows.Count;
            int[] idLibro = new int[cont];

            
           
        // cmb_libros.DisplayMember = "Nombre";
         //   cmb_libros.ValueMember = "EditorialID";

            cmb_libros.DataContext = ds.Tables[0];
            cmb_libros.SelectedValuePath = ds.Tables[0].Columns["GeneroID"].ToString();
            cmb_libros.DisplayMemberPath = ds.Tables[0].Columns["Nombre"].ToString();
          
         
           /* for (int i = 0; i < cont; i++)
            {

            cmb_libros.Items.Add(ds.Tables[0].Rows[i][1].ToString());
               
            }*/

         
            
        }

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            if (cmb_libros.SelectedIndex == -1)
            {
                if(txt_nombre.Text != ""){

                
                cliente.NuevoGenero(txt_nombre.Text.ToString());
                MessageBox.Show( " Guardado ");
                }else{
                MessageBox.Show( " Faltan Datos ");
                }
            }
            else
            {
                 if(txt_nombre.Text != ""){
                    string a =  cmb_libros.SelectedValue.ToString();
                     int id =  Convert.ToInt32(a);
                cliente.EditaGenero(id,txt_nombre.Text.ToString());
                MessageBox.Show( " Editado ");
                }else{
                MessageBox.Show( " Faltan Datos ");
                }
               
               
                
            }
            txt_nombre.Text = "";
            banderaUpdate = 1;
             llenaCombo();

        }
    }
}
