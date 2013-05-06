using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Data;
using System.Data.OleDb;
using System.Data.Linq;

namespace examen2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       /* public void NuevoLibro(string nombre, int autor, int editorial, int genero, string idioma, string pais, int paginas)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = " INSERT INTO Libros (Nombre,AutorID,EditorialID,GeneroID,Idioma,Pais,NoPaginas) VALUES('" + nombre + "'," + autor + "," + editorial + "," + genero + ",'"+idioma+"','"+pais+"',"+paginas+");";


            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        public void EditaLibro(int id, string nombre, int autor, int editorial, int genero, string idioma, string pais, int paginas)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);

            string query = "UPDATE Libros SET nombre='" + nombre + "',AutorID=" + autor + ",EditorialID=" + editorial + ",GeneroID=" + genero + ", Idioma = '" + idioma + "',Pais='" + pais + "',NoPaginas=" + paginas + " WHERE LibroID=" + id + ";";


            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public void NuevoEditorial(string nombre, string Direccion, string Estado, string Pais)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = " INSERT INTO Editoriales (Nombre,Direccion,Estado,Pais) VALUES('" + nombre + "','"+Direccion+"','"+ Estado+"','"+Pais+"');";


            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        public void EditaEditorial(int id,string nombre, string Direccion, string Estado, string Pais)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = "UPDATE Editoriales SET nombre='" + nombre + "',Direccion='" + Direccion + "',Estado='"+Estado+"',Pais='"+Pais+"' WHERE EditorialID=" + id + ";";


            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public void NuevoAutor(string nombre, string APaterno, string Nacionalidad)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = " INSERT INTO Autores (Nombre,ApPaterno,Nacionalidad) VALUES('" + nombre + "','"+APaterno+"','"+ Nacionalidad+"');";


            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        public void EditaAutor(int id, string nombre, string APaterno, string Nacionalidad)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = "UPDATE Autores SET nombre='" + nombre + "',ApPaterno='" + APaterno + "',Nacionalidad ='" + Nacionalidad + "' WHERE AutorID=" + id + ";";
            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public void NuevoGenero(string nombre)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = " INSERT INTO Generos (Nombre) VALUES('" + nombre + "' );";
         

            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            
        }
        public void EditaGenero(int id,string nombre)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            string query = "UPDATE Generos SET nombre='" + nombre + "' WHERE GeneroID=" + id + ";";
           
           
            try
            {
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand(query, conn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                throw ex;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }*/
        public List<Editorial> ObtenerListaEditoriales()
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Editoriales;", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            List<Editorial> EditorialLst = new List<Editorial>();
            Editorial EditorialObj = new Editorial();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EditorialObj.Nombre = dr["Nombre"].ToString();
                EditorialObj.EditorialID = Convert.ToInt32(dr["EditorialID"].ToString());
                EditorialObj.Direccion = dr["Direccion"].ToString();
                EditorialObj.Estado = dr["Estado"].ToString();
                EditorialObj.Pais = dr["Pais"].ToString();
                EditorialObj.URLEditorial = dr["URLEditorial"].ToString();
                EditorialLst.Add(EditorialObj);
            }
       
           
            return EditorialLst;

        }
        public List<Genero> ObtenerListaTodosGeneros()
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT GeneroID,Nombre FROM Generos;", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            List<Genero> GeneroLst = new List<Genero>();
            

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Genero GeneroObj = new Genero();
                GeneroObj.GeneroID = Convert.ToInt32(dr["GeneroID"].ToString());
                GeneroObj.Nombre = dr["Nombre"].ToString();
              

                //Libros
                GeneroObj.ListaLibros = new List<Libro>();

                DataSet ds2 = ObtenerListaLibrosXGenero(GeneroObj.GeneroID);
                foreach (DataRow dr2 in ds2.Tables[0].Rows)
                {
                    Libro l = new Libro();
                    l.LibroID = Convert.ToInt32(dr2["LibroID"].ToString());
                    l.Nombre = dr2["Nombre"].ToString();
                    l.ImagenURL = dr2["ImagenURL"].ToString();
                    l.Descripcion = dr2["Descripcion"].ToString();

                    GeneroObj.ListaLibros.Add(l);
                }

                GeneroLst.Add(GeneroObj);
            }
            return GeneroLst;

        }
        public List<Autor> ObtenerListaAutores()
        {
            List<Autor> autoresList = new List<Autor>();

            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT AutorID, Nombre, ApPaterno, Nacionalidad,UrlImg FROM Autores", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            
           

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Autor AutorObj = new Autor();
                AutorObj.AutorID = Convert.ToInt32(dr["AutorID"].ToString());
                AutorObj.Nombre = dr["Nombre"].ToString();
                AutorObj.ApPaterno = dr["ApPaterno"].ToString();
                AutorObj.Nacionalidad = dr["Nacionalidad"].ToString();
                AutorObj.UrlImg = dr["UrlImg"].ToString();

                

                //Libros
                AutorObj.ListaLibros = new List<Libro>();

                DataSet ds2 = ObtenerListaLibrosXAutor(AutorObj.AutorID);
                foreach (DataRow dr2 in ds2.Tables[0].Rows)
                {
                    Libro l = new Libro();
                    l.LibroID = Convert.ToInt32(dr2["LibroID"].ToString());
                    l.Nombre = dr2["Nombre"].ToString();
                    l.ImagenURL = dr2["ImagenURL"].ToString();
                    l.Descripcion = dr2["Descripcion"].ToString();

                    AutorObj.ListaLibros.Add(l);
                }
                autoresList.Add(AutorObj);
            }

            return autoresList;


        }
        public List<Libro> ObtenerListaTodosLibros()
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Libros;", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            List<Libro> libroLst = new List<Libro>();
            Libro LibroObj = new Libro();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                LibroObj.Nombre = dr["Nombre"].ToString();
                LibroObj.LibroID = Convert.ToInt32(dr["LibroID"].ToString());
                LibroObj.AutorID = Convert.ToInt32(dr["AutorID"].ToString());
                LibroObj.EditorialID = Convert.ToInt32(dr["EditorialID"].ToString());
                LibroObj.GeneroID = Convert.ToInt32(dr["GeneroID"].ToString());
                LibroObj.Idioma = dr["Idioma"].ToString();
                LibroObj.Pais = dr["Pais"].ToString();
                LibroObj.NoPaginas = Convert.ToInt32(dr["NoPagina"].ToString());
                LibroObj.ImagenURL = dr["ImagenURL"].ToString();
                LibroObj.Descripcion = dr["Descripcion"].ToString();
               
                libroLst.Add(LibroObj);
            }
           

            return libroLst;


        }


        public DataSet ObtenerListaLibrosXAutor(int AutorID)
        {
            string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
            OleDbConnection conn = new OleDbConnection(connStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT LibroID, Nombre,ImagenURL,Descripcion FROM Libros WHERE AutorID = " + AutorID, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;


        }
           public DataSet ObtenerListaLibrosXGenero(int GeneroID)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT LibroID, Nombre,ImagenURL,Descripcion  FROM Libros WHERE GeneroID = " + GeneroID, conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
         /* public DataSet ObtenerListaGeneros()
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT GeneroID, Nombre FROM Generos;", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet BuscaGenero(int id)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Nombre FROM Generos where GeneroID = " +id+";", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet BuscaLibro(int id)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Nombre,AutorID,EditorialID,GeneroID,Idioma,Pais,NoPaginas,LibroID FROM Libros where LibroID = " + id + ";", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet BuscaEditorial(int id)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Nombre,Direccion,Estado,Pais FROM Editoriales where EditorialID = " + id + ";", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet ObtenerListaAutor()
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT AutorID, Nombre,ApPaterno FROM Autores;", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet ObtenerListaEditorial()
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT EditorialID, Nombre FROM Editoriales;", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet BuscaAutor(int id)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Nombre,ApPaterno,Nacionalidad FROM Autores where AutorID = " + id + ";", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet ObtenerDetalleLibro(int libro)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Libros.Nombre, Autores.Nombre, Editoriales.Nombre, Generos.Nombre, Libros.Idioma, Libros.NoPaginas FROM ((Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID) INNER JOIN Editoriales ON Libros.EditorialID = Editoriales.EditorialID) INNER JOIN Generos ON Libros.GeneroID = Generos.GeneroID WHERE Libros.LibroID="+libro+";", conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }
          public DataSet ObtenerListaLibrosOrdenada(int quien,int orden)
          {
              string dbStr = HostingEnvironment.MapPath(@"~/App_Data/libros.mdb;");
              string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbStr;
              OleDbConnection conn = new OleDbConnection(connStr);
              string query = "";
              switch (quien)
              {
                  case 0: 
                      if(orden == 0)
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Libros.Nombre;";
                      }
                      else
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Libros.Nombre DESC;"; 
                      }
                      break;
                  case 1: 
                       if(orden == 0)
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Autores.Nombre;";
                      }
                      else
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Autores.Nombre DESC;"; 
                      }
                      break;
                  case 2: 
                       if(orden == 0)
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Libros.Pais;";
                      }
                      else
                      {
                          query = "SELECT Libros.LibroID,Libros.Nombre, Autores.Nombre, Libros.Pais FROM Autores INNER JOIN Libros ON Autores.AutorID = Libros.AutorID ORDER BY Libros.Pais DESC;"; 
                      }
                      break;
              }
              OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
              DataSet ds = new DataSet();
              adapter.Fill(ds);
              return ds;
          }*/

        
    }
}
