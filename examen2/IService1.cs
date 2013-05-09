using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace examen2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
           // Listas
        [OperationContract]
        List<Libro> ObtenerListaTodosLibros();
        [OperationContract]
        List<Autor> ObtenerListaAutores();
        [OperationContract]
        List<Genero> ObtenerListaTodosGeneros();
        [OperationContract]
        List<Editorial> ObtenerListaEditoriales();

        [OperationContract]
        Task<Todo> ObtenerTodo();

        //DataSet
        [OperationContract]
        DataSet ObtenerListaLibrosXAutor(int AutorID);
        [OperationContract]
        DataSet ObtenerListaLibrosXGenero(int GeneroID);
        [OperationContract]
        DataSet ObtenerListaLibrosXEditorial(int EditorialID);

        [OperationContract]
        void NuevoLibro(string nombre, int autor, int editorial, int genero, string idioma, string pais, int paginas, string ImagenURL, string Descripcion);
  /*     
   *    [OperationContract]
        DataSet ObtenerListaGeneros();
        [OperationContract]
        DataSet ObtenerListaAutor();
        [OperationContract]
        DataSet ObtenerListaEditorial();
        [OperationContract]
        DataSet ObtenerListaLibrosNombres();
        
        //Buscar Espesifico
        [OperationContract]
        DataSet BuscaLibro(int id);
        [OperationContract]
        DataSet BuscaGenero(int id);
        [OperationContract]
        DataSet BuscaAutor(int id);
        [OperationContract]
        DataSet BuscaEditorial(int id);

        //Lista Ordenada
        [OperationContract]
        DataSet ObtenerListaLibrosOrdenada(int quien, int orden);

        //Agregar Nuevos
        [OperationContract]
        void NuevoGenero(string nombre);
        [OperationContract]
        void NuevoAutor(string nombre, string APaterno, string Nacionalidad);
        [OperationContract]
        void NuevoEditorial(string nombre, string Direccion, string Estado,string Pais);
       

        //Editar
        [OperationContract]
        void EditaGenero(int id, string nombre);
        [OperationContract]
        void EditaAutor(int id, string nombre, string APaterno, string Nacionalidad);
        [OperationContract]
        void EditaEditorial(int id,string nombre, string Direccion, string Estado, string Pais);
        [OperationContract]
        void EditaLibro(int id, string nombre, int autor, int editorial, int genero, string idioma, string pais, int paginas);

        /***********DEtalleLibro************
         
        [OperationContract]
        DataSet ObtenerDetalleLibro(int libro);
        */
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Todo
    {
        List<Autor> _a;
        List<Genero> _g;
        List<Editorial> _e;

        [DataMember]
        public List<Autor> Autor
        {
            get { return _a; }
            set { _a = value; }
        }

        [DataMember]
        public List<Genero> Genero
        {
            get { return _g; }
            set { _g = value; }
        }
        [DataMember]
        public List<Editorial> Editorial
        {
            get { return _e; }
            set { _e = value; }
        }
    }

    [DataContract]
    public class Autor
    {
        [DataMember]
        public int AutorID { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApPaterno { get; set; }
        [DataMember]
        public string Nacionalidad { get; set; }
        [DataMember]
        public string UrlImg { get; set; }
        [DataMember]
        public List<Libro> ListaLibros { get; set; }
    }
   
    [DataContract]
    public class Editorial
    {
        [DataMember]
        public int EditorialID { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Pais { get; set; }
        [DataMember]
        public string ImagenURL { get; set; }
        [DataMember]
        public string URLEditorial { get; set; }
        [DataMember]
        public List<Libro> ListaLibros { get; set; }
    }

    [DataContract]
    public class Genero
    {
        [DataMember]
        public int GeneroID { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ImagenURL { get; set; }
        [DataMember]
        public List<Libro> ListaLibros { get; set; }
    }

    [DataContract]
    public class Libro
    {
        [DataMember]
        public int LibroID { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int AutorID { get; set; }
        [DataMember]
        public int EditorialID { get; set; }
        [DataMember]
        public int GeneroID { get; set; }
        [DataMember]
        public string Idioma { get; set; }
        [DataMember]
        public string Pais { get; set; }
        [DataMember]
        public int NoPaginas { get; set; }
        [DataMember]
        public string ImagenURL { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

    }
}
