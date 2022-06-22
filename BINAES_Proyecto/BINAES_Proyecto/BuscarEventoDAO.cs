using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Data.SqlClient;


namespace BINAES_Proyecto
{
    public class BuscarEventoDAO
    {
        public static List<Evento> NombreEvento(string nombre)
        {
            string cadena = Resources.Cadena_Conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha AS 'IE', EVENTO.finalizacion_evento_hora_fecha AS 'FE', AREA.nombre, STRING_AGG(OBJETIVOS.objetivos, ' ') 'Objetivos' " +
                    "FROM EVENTO INNER JOIN AREA ON AREA.id = EVENTO.id_area " +
                    "INNER JOIN OBJETIVOS ON OBJETIVOS.id_evento = EVENTO.id WHERE EVENTO.titulo like @titulobuscar GROUP BY EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha, EVENTO.finalizacion_evento_hora_fecha, AREA.nombre";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulobuscar",  nombre);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eje = new Evento();
                        eje.Titulo_Evento = reader["titulo"].ToString();
                        eje.Portada = reader["imagen"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Cantidad_de_asistentes = Convert.ToInt32(reader["asistentes_cantidad"].ToString());
                        eje.Area = reader["nombre"].ToString();
                        eje.Inicio_del_vento = Convert.ToDateTime(reader["IE"].ToString());
                        eje.Finalizacion_del_evento = Convert.ToDateTime(reader["FE"].ToString());
                        eje.Objetivos = reader["Objetivos"].ToString();
                        lista.Add(eje);
                        
                    }
                }
                connection.Close();
            }
            return lista;
        }
        
        
        public static List<Evento> Eventos()
        {
            string cadena = Resources.Cadena_Conexion;
            List<Evento> lista = new List<Evento>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha AS 'IE', EVENTO.finalizacion_evento_hora_fecha AS 'FE', AREA.nombre, STRING_AGG(OBJETIVOS.objetivos, ' ') 'Objetivos' " +
                    "FROM EVENTO INNER JOIN AREA ON AREA.id = EVENTO.id_area " +
                    "INNER JOIN OBJETIVOS ON OBJETIVOS.id_evento = EVENTO.id GROUP BY EVENTO.id, EVENTO.titulo, EVENTO.imagen, EVENTO.asistentes_cantidad, EVENTO.incio_evento_hora_fecha, EVENTO.finalizacion_evento_hora_fecha, AREA.nombre";


                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento eje = new Evento();
                        eje.Titulo_Evento = reader["titulo"].ToString();
                        eje.Portada = reader["imagen"].ToString();
                        eje.ID = Convert.ToInt32(reader["id"].ToString());
                        eje.Cantidad_de_asistentes = Convert.ToInt32(reader["asistentes_cantidad"].ToString());
                        eje.Area = reader["nombre"].ToString();
                        eje.Inicio_del_vento = Convert.ToDateTime(reader["IE"].ToString());
                        eje.Finalizacion_del_evento = Convert.ToDateTime(reader["FE"].ToString());
                        eje.Objetivos = reader["Objetivos"].ToString();
                        lista.Add(eje);
                        
                    }
                }
                connection.Close();
            }
            return lista;
        }
    }
}