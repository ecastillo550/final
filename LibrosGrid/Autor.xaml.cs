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
    /// Interaction logic for Autor.xaml
    /// </summary>
    public partial class Autor : Window
    {
        DataSet ds;
        int banderaUpdate = 0;

        public Autor()
        {
            InitializeComponent();
            llenaCombo();
        }
         private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (banderaUpdate == 0)
            {
                LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
                ds = cliente.BuscaAutor(Convert.ToInt32(cmb_libros.SelectedValue.ToString()));

                txt_nombre.Text = ds.Tables[0].Rows[0][0].ToString();
                txt_apaterno.Text = ds.Tables[0].Rows[0][1].ToString();
                txt_nacionalidad.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            else { banderaUpdate = 0; }
            
        }
        public void llenaCombo()
        {
            
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            ds = cliente.ObtenerListaAutor();

            //cmb_libros.Items.Clear();

            cmb_libros.DataContext = ds.Tables[0];
            cmb_libros.SelectedValuePath = ds.Tables[0].Columns["AutorID"].ToString();
            
            cmb_libros.DisplayMemberPath = ds.Tables[0].Columns["Nombre"].ToString();
        }

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            if (cmb_libros.SelectedIndex == -1)
            {
                if(txt_nombre.Text != ""){

                
                cliente.NuevoAutor(txt_nombre.Text.ToString(),txt_apaterno.Text.ToString(),txt_nacionalidad.Text.ToString());
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
                     cliente.EditaAutor(id, txt_nombre.Text.ToString(), txt_apaterno.Text.ToString(), txt_nacionalidad.Text.ToString());
                MessageBox.Show( " Editado ");
                }else{
                MessageBox.Show( " Faltan Datos ");
                }
               
               
                
            }
            txt_nombre.Text = "";
            txt_nacionalidad.Text = "";
            txt_apaterno.Text = "";
            banderaUpdate = 1;
             llenaCombo();

        }
    
    }
}
