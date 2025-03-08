using AlbumsTS.Model;
using AlbumsTS.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AlbumsTS.Controller
{
    public class ControllerTS : IControllerTS
    {
        private Conexion conexion = new Conexion();
        public List<TSmodel> GetAlbums()
        {
            List<TSmodel> albums = new List<TSmodel>();

            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAlbums", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            albums.Add(new TSmodel
                            {
                                ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0, // Si es null, asigna 0
                                Nombre = reader["Nombre"].ToString(),
                                NumeroCanciones = Convert.ToInt32( reader["NumeroCanciones"]),
                                Genero = reader["Genero"].ToString(),
                                FechaPublicacion =Convert.ToDateTime(reader["FechaPublicacion"]),
                                ImagenURL = reader["ImagenURL"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los albums: " + ex.Message);
                }
            }

            return albums;
        }
    }
}
