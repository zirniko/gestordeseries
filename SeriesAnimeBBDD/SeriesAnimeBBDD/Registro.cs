using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnimeBBDD
{
    class Registro
    {
        SqlConnection conn;
        string miConexion = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public DataTable VerificaUsuario(string Usuario, string Password)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("VerificaUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 255);
                cmd.Parameters["@Usuario"].Value = Usuario;

                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 255);
                cmd.Parameters["@Password"].Value = Password;
                #endregion
                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion
                #region Poblar el DataTable
                dt.Load(dr);
                #endregion
                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }


        }



        public void GuardarGenero(string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("IngresarGenero", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                #endregion
                #region Ejecuta el Insert
                cmd.ExecuteNonQuery(); //ejecuto el insert
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ListaGenero()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaGenero", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public void ActualizarGenero(string ID, string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llama al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ActualizarGenero", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = ID;

                #endregion
                #region Ejecutar la Consulta
                cmd.ExecuteNonQuery();
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void EliminaGenero(string GeneroId)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("EliminarGenero", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@generoId", SqlDbType.Int);
                cmd.Parameters["@generoId"].Value = GeneroId;
                #endregion
                #region Ejecuta el Delete
                cmd.ExecuteNonQuery(); //ejecuto el eliminar
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable CargaGeneroPorID(int GeneroID)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaGeneroId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@GeneroId", SqlDbType.Int);
                cmd.Parameters["@GeneroId"].Value = GeneroID;
                #endregion
                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion
                #region Poblar el DataTable
                dt.Load(dr);
                #endregion
                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }



        public void GuardarAdaptacion(string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("IngresarAdaptacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                #endregion
                #region Ejecuta el Insert
                cmd.ExecuteNonQuery(); //ejecuto el insert
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ListaAdaptacion()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAdaptacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public void ActualizarAdaptacion(string ID, string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llama al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ActualizarAdaptacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = ID;

                #endregion
                #region Ejecutar la Consulta
                cmd.ExecuteNonQuery();
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void EliminaAdaptacion(string AdaptacionId)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("EliminarAdaptacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@adaptacionId", SqlDbType.Int);
                cmd.Parameters["@adaptacionId"].Value = AdaptacionId;
                #endregion
                #region Ejecuta el Delete
                cmd.ExecuteNonQuery(); //ejecuto el eliminar
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable CargaAdaptacionPorID(int AdaptacionID)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAdaptacionId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@AdaptacionId", SqlDbType.Int);
                cmd.Parameters["@AdaptacionId"].Value = AdaptacionID;
                #endregion
                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion
                #region Poblar el DataTable
                dt.Load(dr);
                #endregion
                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }



        public void GuardarClasificacion(string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("IngresarClasificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                #endregion
                #region Ejecuta el Insert
                cmd.ExecuteNonQuery(); //ejecuto el insert
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ListaClasificacion()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaClasificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public void ActualizarClasificacion(string ID, string Descripcion)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llama al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ActualizarClasificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = ID;

                #endregion
                #region Ejecutar la Consulta
                cmd.ExecuteNonQuery();
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void EliminaClasificacion(string ClasificacionId)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("EliminarClasificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@ClasificacionId", SqlDbType.Int);
                cmd.Parameters["@ClasificacionId"].Value = ClasificacionId;
                #endregion
                #region Ejecuta el Delete
                cmd.ExecuteNonQuery(); //ejecuto el eliminar
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable CargaClasificacionPorID(int ClasificacionId)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaClasificacionId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@ClasificacionId", SqlDbType.Int);
                cmd.Parameters["@ClasificacionId"].Value = ClasificacionId;
                #endregion
                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion
                #region Poblar el DataTable
                dt.Load(dr);
                #endregion
                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }



        public DataTable ListaAnime()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnime", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public void GuardarAnime(string nombre, string Emision, int episodio, int GeneroID, int AdaptacionID, int ClasificacionID)//parametros
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("IngresarAnime", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
                cmd.Parameters["@nombre"].Value = nombre;

                cmd.Parameters.Add("@Emision", SqlDbType.Date);
                cmd.Parameters["@Emision"].Value = Emision;

                cmd.Parameters.Add("@episodio", SqlDbType.Int);
                cmd.Parameters["@episodio"].Value = episodio;

                cmd.Parameters.Add("@GeneroID", SqlDbType.Int);
                cmd.Parameters["@GeneroID"].Value = GeneroID;

                cmd.Parameters.Add("@AdaptacionID", SqlDbType.Int);
                cmd.Parameters["@AdaptacionID"].Value = AdaptacionID;

                cmd.Parameters.Add("@ClasificacionID", SqlDbType.Int);
                cmd.Parameters["@ClasificacionID"].Value = ClasificacionID;

                #endregion
                #region Ejecuta el Insert
                cmd.ExecuteNonQuery(); //ejecuto el insert
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void EliminaAnime(string AnimeId)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada a Procedimiento
                SqlCommand cmd = new SqlCommand("EliminarAnime", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso de Parametros
                cmd.Parameters.Add("@AnimeId", SqlDbType.Int);
                cmd.Parameters["@AnimeId"].Value = AnimeId;
                #endregion
                #region Ejecuta el Delete
                cmd.ExecuteNonQuery(); //ejecuto el eliminar
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable CargaAnimePorID(string AnimeId)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnimeId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@AnimeId", SqlDbType.Int);
                cmd.Parameters["@AnimeId"].Value = AnimeId;
                #endregion
                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion
                #region Poblar el DataTable
                dt.Load(dr);
                #endregion
                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public void ActualizarAnime(string ID, string nombre, string Emision, int episodio, int GeneroID, int AdaptacionID, int ClasificacionID)
        {
            try
            {
                #region Abrir Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region Llama al Procedimiento Almacenado
                SqlCommand cmd = new SqlCommand("ActualizarAnime", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Paso Parametros
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = ID;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 255);
                cmd.Parameters["@nombre"].Value = nombre;

                cmd.Parameters.Add("@Emision", SqlDbType.Date);
                cmd.Parameters["@Emision"].Value = Emision;

                cmd.Parameters.Add("@episodio", SqlDbType.Int);
                cmd.Parameters["@episodio"].Value = episodio;

                cmd.Parameters.Add("@GeneroID", SqlDbType.Int);
                cmd.Parameters["@GeneroID"].Value = GeneroID;

                cmd.Parameters.Add("@AdaptacionID", SqlDbType.Int);
                cmd.Parameters["@AdaptacionID"].Value = AdaptacionID;

                cmd.Parameters.Add("@ClasificacionID", SqlDbType.Int);
                cmd.Parameters["@ClasificacionID"].Value = ClasificacionID;


                #endregion
                #region Ejecutar la Consulta
                cmd.ExecuteNonQuery();
                #endregion
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ListaAnimeGenero(string Genero)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnimeGenero", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
               
                #region Paso Parametros
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar,255);
                cmd.Parameters["@Genero"].Value = Genero;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public DataTable ListaAnimeAdaptacion(string Adaptacion)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnimeAdaptacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Paso Parametros
                cmd.Parameters.Add("@Adaptacion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Adaptacion"].Value = Adaptacion;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public DataTable ListaAnimeClasificacion(string Clasificacion)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnimeClasificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Paso Parametros
                cmd.Parameters.Add("@Clasificacion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Clasificacion"].Value = Clasificacion;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }
        public DataTable ListaAnimeFiltro(string Genero, string Adaptacion,string Clasificacion)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region Abrir la Conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion

                #region Llamada al Procedimiento
                SqlCommand cmd = new SqlCommand("ListaAnimeFiltro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region Paso Parametros
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar, 255);
                cmd.Parameters["@Genero"].Value = Genero;
                cmd.Parameters.Add("@Adaptacion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Adaptacion"].Value = Adaptacion;
                cmd.Parameters.Add("@Clasificacion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Clasificacion"].Value = Clasificacion;
                #endregion

                #region Ejecutar 
                dr = cmd.ExecuteReader();
                #endregion

                #region Poblar el DataTable
                dt.Load(dr);
                #endregion

                #region Retornarmos el DataTable
                return dt;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                dr.Close();
            }

        }


    }
}
