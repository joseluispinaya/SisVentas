using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRepository.Implementation
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Conexion _conexion;

        public NegocioRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();
            //Negocio objeto = null;

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Negocio()
                        {
                            RazonSocial = dr["RazonSocial"].ToString(),
                            RUC = dr["RUC"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Celular = dr["Celular"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            SimboloMoneda = dr["SimboloMoneda"].ToString(),
                            NombreLogo = dr["NombreLogo"].ToString(),
                            UrlLogo = dr["UrlLogo"].ToString()
                        };
                    }
                }
            }
            return objeto;
        }

        public async Task Editar(Negocio objeto)
        {
            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@RazonSocial", objeto.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", objeto.RUC);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Celular", objeto.Celular);
                cmd.Parameters.AddWithValue("@Correo", objeto.Correo);
                cmd.Parameters.AddWithValue("@SimboloMoneda", objeto.SimboloMoneda);
                cmd.Parameters.AddWithValue("@NombreLogo", objeto.NombreLogo);
                cmd.Parameters.AddWithValue("@UrlLogo", objeto.UrlLogo);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }

        
    }
}
