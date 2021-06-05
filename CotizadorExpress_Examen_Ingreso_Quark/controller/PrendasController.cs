using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CotizadorExpress_Examen_Ingreso_Quark.model;
using System.Diagnostics;

namespace CotizadorExpress_Examen_Ingreso_Quark.controller
{
    static class PrendasController
    {
        public static void AgregarPrenda()
        {
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            #region Cadenas de conexion alta prendas
            string cadena = @"insert into Prendas
                    (Nombre,Tipo,PrendaConfId)
                    values(@nombre,@tipo,@prendaconfid)";

            //string cadena = @"insert into Camisas
            //        (PrendaConfId,Manga,Cuello,Stock,Precio)
            //        values(@prendaConfId,@manga,@cuello,@stock,@precio)";

            //string cadena = @"insert into Pantalones
            //        (PrendaConfId,Tipo,Stock,Precio)
            //        values(@prendaConfId,@tipo,@stock,@precio)";
            #endregion

            SqlCommand comando = new SqlCommand(cadena, conexion);

            #region Set datos alta prendas
            comando.Parameters.Add("@nombre", SqlDbType.VarChar);
            comando.Parameters["@nombre"].Value = "Pantalon DOD";

            comando.Parameters.Add("@tipo", SqlDbType.VarChar);
            comando.Parameters["@tipo"].Value = "Pantalon";

            comando.Parameters.Add("@prendaconfid", SqlDbType.Int);
            comando.Parameters["@prendaconfid"].Value = 201;

            //comando.Parameters.Add("@tipo", SqlDbType.VarChar);
            //comando.Parameters["@tipo"].Value = "normal";

            //comando.Parameters.Add("@manga", SqlDbType.VarChar);
            //comando.Parameters["@manga"].Value = "larga";

            //comando.Parameters.Add("@cuello", SqlDbType.VarChar);
            //comando.Parameters["@cuello"].Value = "normal";

            //comando.Parameters.Add("@stock", SqlDbType.Int);
            //comando.Parameters["@stock"].Value = 500;

            //comando.Parameters.Add("@precio", SqlDbType.Float);
            //comando.Parameters["@precio"].Value = 740.75f;

            #endregion

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static List<Cotizacion> TraerHistorialCotizaciones(int vendedorId)
        {
            List<Cotizacion> cotizaciones = new List<Cotizacion>();

            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");
            conexion.Open();

            string cadena = @"select * from HistorialDeCotizaciones
                    where [VendedorId]=@vendedorId";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@vendedorId", SqlDbType.Int);
            comando.Parameters["@vendedorId"].Value = vendedorId;

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cotizacion cotizacion = new Cotizacion();

                cotizacion.Id = (int)reader["Id"];
                cotizacion.Fechayhora = DateTime.Parse(reader["FechaYHora"].ToString());
                cotizacion.VendedorId = vendedorId;
                cotizacion.Cantidad = (int)reader["Cantidad"];
                cotizacion.Resultado = float.Parse(reader["Resultado"].ToString());
                cotizacion.Prendatipo = reader["PrendaTipo"].ToString();
                cotizacion.Prendaconf = reader["PrendaConf"].ToString();
                cotizaciones.Add(cotizacion);
            }

            conexion.Close();
            return cotizaciones;
        }
        public static List<Prenda> TraerListadoPrendas()
        {
            List<Prenda> prendas = new List<Prenda>();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"select * from Prendas";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            List<string> tipos = new List<string>();

            while (reader.Read())
            {
                switch (reader["tipo"])
                {
                    case "Camisa":

                        tipos = TraerTiposCamisa();
                        foreach (string t in tipos)
                        {
                            string[] prendaData = t.Split(',');
                            if (prendaData.Length != 2)
                                break;

                            Manga manga = prendaData[0] == "Corta" ? Manga.Corta : Manga.Larga;
                            Cuello cuello = (Cuello)Enum.Parse(typeof(Cuello), prendaData[1]);
                            Camisa camisa = TraerDatosCamisa(manga, cuello);
                            
                            prendas.Add(camisa);
                        }
                        break;

                    case "Pantalon":
                        tipos = TraerTiposPantalon();
                        foreach(string t in tipos)
                        {
                            TipoPantalon tipo =
                            (TipoPantalon)Enum.Parse(typeof(TipoPantalon), t);
                            Pantalon pantalon = TraerDatosPantalon(tipo);

                            prendas.Add(pantalon);
                        }                       

                        break;
                    default: break;
                }

            }
            conexion.Close();
            return prendas;
        }
        public static List<string> TraerPrendas()
        {
            var prendas = new List<string>();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"select * from TipoDePrendas";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
                prendas.Add(reader["tipo"].ToString());
            conexion.Close();
            return prendas;
        }

        public static List<string> TraerTiposCamisa()
        {
            var tipos = new List<string>();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"select * from Camisas";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string fixedTipo = $"{reader["Manga"]}, {reader["Cuello"]}";
                tipos.Add(fixedTipo);
            }
            conexion.Close();
            return tipos;
        }

        public static List<string> TraerTiposPantalon()
        {
            var tipos = new List<string>();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"select * from Pantalones";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string fixedTipo = $"{reader["Tipo"]}";
                tipos.Add(fixedTipo);
            }
            conexion.Close();
            return tipos;
        }

        public static Camisa TraerDatosCamisa(Manga manga, Cuello cuello)
        {
            Camisa camisa = new Camisa();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @$"select * from Camisas
                    where [Manga]=@manga
                    and [Cuello]=@cuello";
                
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@manga", SqlDbType.VarChar);
            comando.Parameters["@manga"].Value = manga.ToString();

            comando.Parameters.Add("@cuello", SqlDbType.VarChar);
            comando.Parameters["@cuello"].Value = cuello.ToString();

            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                camisa.Cuello = cuello;
                camisa.Manga = manga;
                camisa.Stock = (int)reader["Stock"];
                camisa.Precio = float.Parse(reader["Precio"].ToString());
            }
            conexion.Close();
            return camisa;
        }

        public static Pantalon TraerDatosPantalon(TipoPantalon tipo)
        {
            Pantalon pantalon = new Pantalon();
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @$"select * from Pantalones
                    where [Tipo]=@tipo";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@tipo", SqlDbType.VarChar);
            comando.Parameters["@tipo"].Value = tipo.ToString();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                pantalon.Tipo = tipo;
                pantalon.Stock = (int)reader["Stock"];
                pantalon.Precio = float.Parse(reader["Precio"].ToString());
            }
            conexion.Close();

            return pantalon;
        }

        public static void AgregarCotizacion(
            string prendaTipo,
            string prendaconf,
            int vendedorId,
            int cantidad,
            float resultado)
        {
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"insert into HistorialDeCotizaciones
                    (FechaYHora,VendedorId,Cantidad,Resultado,PrendaTipo,PrendaConf)
                    values (@fechayhora,@vendedorid,@cantidad,@resultado,@prendatipo,@prendaconf)";
           
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@fechayhora", SqlDbType.DateTime);
            comando.Parameters["@fechayhora"].Value = DateTime.Now;

            comando.Parameters.Add("@vendedorid", SqlDbType.Int);
            comando.Parameters["@vendedorid"].Value = vendedorId;

            comando.Parameters.Add("@cantidad", SqlDbType.Int);
            comando.Parameters["@cantidad"].Value = cantidad;

            comando.Parameters.Add("@resultado", SqlDbType.Float);
            comando.Parameters["@resultado"].Value = resultado;

            comando.Parameters.Add("@prendatipo", SqlDbType.VarChar);
            comando.Parameters["@prendatipo"].Value = prendaTipo;

            comando.Parameters.Add("@prendaconf", SqlDbType.VarChar);
            comando.Parameters["@prendaconf"].Value = prendaconf;

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static void VenderCamisa(Camisa camisa, int cantidad)
        {
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"update Camisas set Stock = Stock - @cantidad
                        where [Manga]=@manga
                        and [Cuello]=@cuello";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@cantidad", SqlDbType.Int);
            comando.Parameters["@cantidad"].Value = cantidad;

            comando.Parameters.Add("@manga", SqlDbType.VarChar);
            comando.Parameters["@manga"].Value = camisa.Manga.ToString();

            comando.Parameters.Add("@cuello", SqlDbType.VarChar);
            comando.Parameters["@cuello"].Value = camisa.Cuello.ToString();

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static void VenderPantalon(Pantalon pantalon, int cantidad)
        {
            SqlConnection conexion = new SqlConnection(
               @"server= DESKTOP-05RBA71;
                database = Cotizador_Express_ExamenIngreso_Quark_BD;
                integrated security = true");

            conexion.Open();

            string cadena = @"update Pantalones set Stock = Stock - @cantidad
                        where [Tipo]=@tipo";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.Add("@cantidad", SqlDbType.Int);
            comando.Parameters["@cantidad"].Value = cantidad;

            comando.Parameters.Add("@tipo", SqlDbType.VarChar);
            comando.Parameters["@tipo"].Value = pantalon.Tipo.ToString();

            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
