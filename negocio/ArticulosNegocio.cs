using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;



namespace negocio
{
    public class ArticulosNegocio 
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security = true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, m.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio, M.Id IdMarca, C.Id IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = m.Id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Precio = lector.GetDecimal(6);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)lector["ImagenUrl"];                    
                    }

                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Categorias = new Categoria();
                    aux.Categorias.Descripcion = (string)lector["Categoria"];
                    aux.Categorias.Id = (int)lector["IdCategoria"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;              
            }
            
        }

        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria, ImagenUrl)values(@Codigo,@Nombre,@Descripcion,@Precio,@IdMarca,@IdCategoria, @ImagenUrl)");
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categorias.Id);
                datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificar(Articulos modificar)
        {
            AccesoDatos datosModificar = new AccesoDatos();
            try
            {
                datosModificar.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl where Id = @Id");
                datosModificar.setearParametros("@Codigo", modificar.Codigo);
                datosModificar.setearParametros("@Nombre", modificar.Nombre);
                datosModificar.setearParametros("@Descripcion", modificar.Descripcion);
                datosModificar.setearParametros("@Precio", modificar.Precio);
                datosModificar.setearParametros("@IdMarca", modificar.Marca.Id);
                datosModificar.setearParametros("@IdCategoria", modificar.Categorias.Id);
                datosModificar.setearParametros("@ImagenUrl", modificar.ImagenUrl);
                datosModificar.setearParametros("@Id", modificar.Id);
                datosModificar.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosModificar.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametros("Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = ("select Codigo, Nombre, A.Descripcion, m.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio, M.Id IdMarca, C.Id IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = m.Id and A.IdCategoria = C.Id and ");
                if(campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                } 
                else if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }else if(campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Precio = datos.Lector.GetDecimal(6);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.Marca = new Marcas();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categorias = new Categoria();
                    aux.Categorias.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categorias.Id = (int)datos.Lector["IdCategoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
