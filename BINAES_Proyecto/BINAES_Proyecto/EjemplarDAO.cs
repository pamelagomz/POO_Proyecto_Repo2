using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public class EjemplarDAO
    {
        public static void IngresarEjemplar(Ejemplar ejem)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string nonquery =
                    "INSERT INTO EJEMPLAR (nombre, fecha_publicada, imagen_portada, id_idioma, id_editorial, id_formato, isbn, issn, doi, id_coleccion)" +
                    "VALUES (@nuevonombre, @nuevafecha_publicada, @nuevaimagen_portada, @nuevoid_idioma, @nuevoid_editorial, @nuevoid_formato, @nuevoisbn, @nuevoissn, @nuevodoi, @nuevoid_coleccion)";

                SqlCommand command = new SqlCommand(nonquery, connection);
                command.Parameters.AddWithValue("@nuevonombre", ejem.nombre);
                command.Parameters.AddWithValue("@nuevafecha_publicada", ejem.fecha);
                command.Parameters.AddWithValue("@nuevaimagen_portada", ejem.imagen);
                command.Parameters.AddWithValue("@nuevoid_idioma", ejem.idioma);
                command.Parameters.AddWithValue("@nuevoid_editorial", ejem.editorial);
                command.Parameters.AddWithValue("@nuevoid_formato", ejem.formato);
                command.Parameters.AddWithValue("@nuevoisbn", ejem.isbn);
                command.Parameters.AddWithValue("@nuevoissn", ejem.issn);
                command.Parameters.AddWithValue("@nuevodoi", ejem.doi);
                command.Parameters.AddWithValue("@nuevoid_coleccion", ejem.coleccion);
                
                
              
                    
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

//Llenando los combo box 
        //llenando el combo de colecciones 
        public static List<Coleccion> CargarDatosColeccion()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Coleccion> lista = new List<Coleccion>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, nombre FROM COLECCION";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Coleccion col = new Coleccion();
                        col.coleccionID = Convert.ToInt32(reader["id"].ToString());
                        col.coleccionNombre = reader["nombre"].ToString();

                        lista.Add(col);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        
        //llenando el combo de editorial 
        public static List<Editorial> CargarDatosEditorial()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, editorial FROM EDITORIAL";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Editorial edit = new Editorial();
                        edit.editorialID = Convert.ToInt32(reader["id"].ToString());
                        edit.nombreEditorial = reader["editorial"].ToString();

                        lista.Add(edit);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        
        //llenando el combo de formato 
        public static List<Formato> CargarDatosFormato()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Formato> lista = new List<Formato>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, formato FROM FORMATO";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Formato formato = new Formato();
                         formato.formatoID= Convert.ToInt32(reader["id"].ToString());
                        formato.nombreFormato= reader["formato"].ToString();

                        lista.Add(formato);
                    }
                }

                connection.Close();
            }

            return lista;
        }



        //llenando el combo de idioma 
        public static List<Idioma> CargarDatosIdiomas()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Idioma> lista = new List<Idioma>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, idioma FROM IDIOMA";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Idioma idioma = new Idioma();
                        idioma.idIdioma = Convert.ToInt32(reader["id"].ToString());
                        idioma.nombreIdioma = reader["idioma"].ToString();

                        lista.Add(idioma);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        


    }
}
