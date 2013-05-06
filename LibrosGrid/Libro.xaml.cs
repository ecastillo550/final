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
    /// Interaction logic for Libro.xaml
    /// </summary>
    public partial class Libro : Window
    {
        DataSet ds;
        int banderaUpdate = 0;
        public Libro()
        {
            InitializeComponent();
            llenaComboLibro();
            llenaComboGenero();
            llenaComboEditorial();
            llenaComboAutor();
            if (MainWindow.idLibro != -1)
            {
                buscaLibroDatos();
            }
        }
        public void llenaComboGenero()
        {

            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet das = cliente.ObtenerListaGeneros();

            cmb_Genero.DataContext = das.Tables[0];
            cmb_Genero.SelectedValuePath = das.Tables[0].Columns["GeneroID"].ToString();
            cmb_Genero.DisplayMemberPath = das.Tables[0].Columns["Nombre"].ToString();
            cmb_Genero.SelectedIndex = 0;
        }

        public void llenaComboLibro()
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet dss = cliente.ObtenerListaLibrosNombres();

            cmb_libros.DataContext = dss.Tables[0];
            cmb_libros.SelectedValuePath = dss.Tables[0].Columns["LibroID"].ToString();
            cmb_libros.DisplayMemberPath = dss.Tables[0].Columns["Nombre"].ToString();
             

        }

        public void llenaComboEditorial()
        {

            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet des = cliente.ObtenerListaEditorial();

            //cmb_libros.Items.Clear();

            cmb_Editorial.DataContext = des.Tables[0];
            cmb_Editorial.SelectedValuePath = des.Tables[0].Columns["EditorialID"].ToString();

            cmb_Editorial.DisplayMemberPath = des.Tables[0].Columns["Nombre"].ToString();

            cmb_Editorial.SelectedIndex = 0;
        }

        public void llenaComboAutor()
        {

            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet dsA = cliente.ObtenerListaAutor();

            //cmb_libros.Items.Clear();

            cmb_Autor.DataContext = dsA.Tables[0];
            cmb_Autor.SelectedValuePath = dsA.Tables[0].Columns["AutorID"].ToString();

            cmb_Autor.DisplayMemberPath = dsA.Tables[0].Columns["Nombre"].ToString();

            cmb_Autor.SelectedIndex = 0;
        }

        public void buscaLibroDatos()
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            DataSet libros = cliente.BuscaLibro(MainWindow.idLibro);
            cmb_libros.SelectedValue = libros.Tables[0].Rows[0][7].ToString();
            //Nombre,AutorID,EditorialID,GeneroID,Idioma,Pais,NoPaginas
            txt_nombre.Text = libros.Tables[0].Rows[0][0].ToString();
            txt_idioma.Text = libros.Tables[0].Rows[0][4].ToString();
            txt_pais.Text = libros.Tables[0].Rows[0][5].ToString();
            txt_paginas.Text = libros.Tables[0].Rows[0][6].ToString();
            cmb_Autor.SelectedValue = libros.Tables[0].Rows[0][1].ToString();
            cmb_Editorial.SelectedValue = libros.Tables[0].Rows[0][2].ToString();
            cmb_Genero.SelectedValue = libros.Tables[0].Rows[0][3].ToString();
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (banderaUpdate == 0)
            {
                LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
                DataSet libros = cliente.BuscaLibro(Convert.ToInt32(cmb_libros.SelectedValue.ToString()));
                //Nombre,AutorID,EditorialID,GeneroID,Idioma,Pais,NoPaginas
                txt_nombre.Text = libros.Tables[0].Rows[0][0].ToString();
                txt_idioma.Text = libros.Tables[0].Rows[0][4].ToString();
                txt_pais.Text = libros.Tables[0].Rows[0][5].ToString();
                txt_paginas.Text = libros.Tables[0].Rows[0][6].ToString();
                cmb_Autor.SelectedValue = libros.Tables[0].Rows[0][1].ToString();
                cmb_Editorial.SelectedValue = libros.Tables[0].Rows[0][2].ToString();
                cmb_Genero.SelectedValue = libros.Tables[0].Rows[0][3].ToString();
                    
            }
            else { banderaUpdate = 0; }
            
        }
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            LibrosRef.Service1Client cliente = new LibrosRef.Service1Client();
            if (cmb_libros.SelectedIndex == -1)
            {
               

                if (txt_nombre.Text != "")
                {

                    string a = cmb_Autor.SelectedValue.ToString();
                    int idA = Convert.ToInt32(a);
                    a = cmb_Editorial.SelectedValue.ToString();
                    int idE = Convert.ToInt32(a);
                    a = cmb_Genero.SelectedValue.ToString();
                    int idG = Convert.ToInt32(a);

                    cliente.NuevoLibro(txt_nombre.Text.ToString(), idA, idE, idG, txt_idioma.Text.ToString(), txt_pais.Text.ToString(), Convert.ToInt32(txt_paginas.Text.ToString()));
                    MessageBox.Show(" Guardado ");
                }
                else
                {
                    MessageBox.Show(" Faltan Datos ");
                }
            }
            else
            {
                if (txt_nombre.Text != "")
                {
                    string a = cmb_Autor.SelectedValue.ToString();
                    int idA = Convert.ToInt32(a);
                    a = cmb_Editorial.SelectedValue.ToString();
                    int idE = Convert.ToInt32(a);
                    a = cmb_Genero.SelectedValue.ToString();
                    int idG = Convert.ToInt32(a);
                     a = cmb_libros.SelectedValue.ToString();
                    int id = Convert.ToInt32(a);
                    cliente.EditaLibro(id, txt_nombre.Text.ToString(), idA, idE, idG, txt_idioma.Text.ToString(), txt_pais.Text.ToString(), Convert.ToInt32(txt_paginas.Text.ToString()));
                    MessageBox.Show(" Editado ");
                }
                else
                {
                    MessageBox.Show(" Faltan Datos ");
                }



            }
            txt_nombre.Text = "";
            txt_idioma.Text = "";
            txt_paginas.Text = "";
            txt_pais.Text = "";
            banderaUpdate = 1;
            llenaComboLibro();
            cmb_Genero.SelectedIndex = 0;
            cmb_Autor.SelectedIndex = 0;
            cmb_Editorial.SelectedIndex = 0;

        }

        private void ComboBox_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
