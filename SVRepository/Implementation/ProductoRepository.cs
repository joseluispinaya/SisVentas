using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;

namespace SVRepository.Implementation
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;

        public ProductoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Producto>> Lista(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();

            using (var con = _conexion.ObtenerSQLConexion())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProducto", con);
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            RefCategoria = new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Nombre = dr["NombreCategoria"].ToString()!
                            },
                            Codigo = dr["Codigo"].ToString()!,
                            Nombre = dr["Nombre"].ToString()!,
                            Descripcion = dr["Descripcion"].ToString()!,
                            PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                            PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Activo = Convert.ToInt32(dr["Activo"]),
                        });
                    }
                }
            }
            return lista;
        }

        public Task<string> Crear(Producto objeto)
        {
            throw new NotImplementedException();
        }

        public Task<string> Editar(Producto objeto)
        {
            throw new NotImplementedException();
        }

        
    }
}
