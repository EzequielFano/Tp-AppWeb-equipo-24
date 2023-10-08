using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.Win32;

namespace Negocio
{
    public class ArticulosNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        //public List<Articulo> TraerListado()
        //{
        //    List<Articulo> articulos = new List<Articulo>();

        //    try
        //    {
        //        datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca,A.IdMarca,A.IdCategoria, C.Descripcion Categoria,A.Precio, IM.ImagenUrl from ARTICULOS A INNER join IMAGENES IM ON A.Id= IM.IdArticulo INNER JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id\r\n");
        //        datos.ejecutarLectura();
        //        int currentArticuloId = -1; // Para controlar el artículo actual

        //        while (datos.Lector.Read())
        //        {
        //            int articuloId = datos.Lector.GetInt32(0);

        //            // Si es un artículo diferente al anterior, crea un nuevo Articulo
        //            if (articuloId != currentArticuloId)
        //            {
        //                Articulo aux = new Articulo();
        //                aux.IdArticulo = articuloId;
        //                aux.CodigoArticulo = (string)datos.Lector["Codigo"];
        //                aux.NombreArticulo = (string)datos.Lector["Nombre"];
        //                aux.Descripcion = (string)datos.Lector["Descripcion"];
        //                aux.Marca = new Marca();
        //                aux.Marca.Descripcion = (string)datos.Lector["Marca"];
        //                aux.Marca.Id = (int)datos.Lector["IdMarca"];
        //                aux.Categoria = new Categoria();
        //                if (datos.Lector["Categoria"] is DBNull)
        //                {
        //                    aux.Categoria = null;
        //                }
        //                else
        //                {
        //                    aux.Categoria = new Categoria();
        //                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
        //                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
        //                }
        //                aux.Precio = (int)datos.Lector.GetSqlMoney(8);

        //                aux.URLImagen = new List<Imagen>(); // Inicializa la lista de imágenes
        //                currentArticuloId = articuloId;

        //                articulos.Add(aux);
        //            }

        //            // Añade la imagen actual al artículo actual
        //            if (!(datos.Lector["ImagenUrl"] is DBNull))
        //            {
        //                Imagen imagen = new Imagen();
        //                imagen.URL = (string)datos.Lector["ImagenUrl"];
        //                articulos.Last().URLImagen.Add(imagen);
        //            }
        //        }

        //        return articulos;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        public List<Articulo> TraerListadoSP()
        {
            List<Articulo> articulos = new List<Articulo>();

            try
            {
                datos.setearProcedure("storedListar");
                datos.ejecutarLectura();
                int currentArticuloId = -1; // Para controlar el artículo actual

                while (datos.Lector.Read())
                {
                    int articuloId = datos.Lector.GetInt32(0);

                    // Si es un artículo diferente al anterior, crea un nuevo Articulo
                    if (articuloId != currentArticuloId)
                    {
                        Articulo aux = new Articulo();
                        aux.IdArticulo = articuloId;
                        aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                        aux.NombreArticulo = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Categoria = new Categoria();
                        if (datos.Lector["Categoria"] is DBNull)
                        {
                            aux.Categoria = null;
                        }
                        else
                        {
                            aux.Categoria = new Categoria();
                            aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                            aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        }
                        aux.Precio = (int)datos.Lector.GetSqlMoney(8);

                        aux.URLImagen = new List<Imagen>(); // Inicializa la lista de imágenes
                        currentArticuloId = articuloId;

                        articulos.Add(aux);
                    }

                    // Añade la imagen actual al artículo actual
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        Imagen imagen = new Imagen();
                        imagen.URL = (string)datos.Lector["ImagenUrl"];
                        articulos.Last().URLImagen.Add(imagen);
                    }
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        //public List<Articulo> TraerListado()
        //{
        //    List<Articulo> articulos = new List<Articulo>();

        //    try
        //    {
        //        datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca,A.IdMarca,A.IdCategoria, C.Descripcion Categoria,A.Precio, IM.ImagenUrl from ARTICULOS A INNER join IMAGENES IM ON A.Id= IM.IdArticulo INNER JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id\r\n");
        //        datos.ejecutarLectura();
        //        while (datos.Lector.Read())
        //        {
        //            Articulo aux = new Articulo();
        //            aux.IdArticulo = datos.Lector.GetInt32(0);
        //            aux.CodigoArticulo = (string)datos.Lector["Codigo"];
        //            aux.NombreArticulo = (string)datos.Lector["Nombre"];
        //            aux.Descripcion = (string)datos.Lector["Descripcion"];
        //            aux.Marca = new Marca();
        //            aux.Marca.Descripcion = (string)datos.Lector["Marca"];
        //            aux.Marca.Id = (int)datos.Lector["IdMarca"];
        //            aux.Categoria = new Categoria();
        //            if (datos.Lector["Categoria"] is DBNull)
        //            {
        //                aux.Categoria = null;
        //            }
        //            else
        //            {
        //                aux.Categoria = new Categoria();
        //                aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
        //                aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
        //            }
        //            aux.Precio = (int)datos.Lector.GetSqlMoney(8);
        //            aux.URLImagen= new Imagen();
        //            if (!(datos.Lector["ImagenUrl"] is DBNull))
        //            {
        //                aux.URLImagen.URL = (string)datos.Lector["ImagenUrl"];
        //            }
        //            articulos.Add(aux);

        //        }
        //        return articulos;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}
        public void agregarArticulo(Articulo articulo)
        {
            try
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                Imagen imag = new Imagen();

                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametro("@Codigo", articulo.CodigoArticulo);
                datos.setearParametro("@Nombre", articulo.NombreArticulo);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.ejecutarAccion();
                imag = imagenNegocio.ObtenerIDarticuloCargado();
                foreach (Imagen imagen in articulo.URLImagen)
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", imag);
                    datos.setearParametro("@ImagenUrl", imagen.URL);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
                         
        }
        public void modificarArticulo(Articulo articulo)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                // Actualizar la información del artículo en la tabla ARTICULOS
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @IdArticulo");
                datos.setearParametro("@IdArticulo", articulo.IdArticulo);
                datos.setearParametro("@Codigo", articulo.CodigoArticulo);
                datos.setearParametro("@Nombre", articulo.NombreArticulo);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.ejecutarAccion();

                // Eliminar imágenes existentes asociadas al artículo
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", articulo.IdArticulo);
                datos.ejecutarAccion();

                // Insertar las nuevas imágenes
                foreach (Imagen imagen in articulo.URLImagen)
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", articulo.IdArticulo);
                    datos.setearParametro("@ImagenUrl", imagen.URL);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarArticulo (int id)
        {
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS where id = @IdArticulo");
                datos.setearParametro("@IdArticulo", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, A.IdCategoria, A.IdMarca, C.Descripcion AS Categoria, A.Precio, IM.ImagenUrl\r\nFROM ARTICULOS A\r\nINNER JOIN IMAGENES IM ON A.Id = IM.IdArticulo\r\nINNER JOIN MARCAS M ON A.IdMarca = M.Id\r\nLEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id\r\nWHERE ";
                if (campo == "Categoria")
                {
                    consulta += "C.Descripcion = '" + criterio + "'";
                }
                else if (campo == "Marca")
                {
                    consulta += "M.Descripcion = '" + criterio + "'";
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Nombre LIKE '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "A.Nombre LIKE '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "A.Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = datos.Lector.GetInt32(0);
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (int)datos.Lector.GetSqlMoney(8);

                    // Obtener la lista de imágenes para el artículo actual
                    aux.URLImagen = new List<Imagen>();
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        Imagen imagen = new Imagen();
                        imagen.URL = (string)datos.Lector["ImagenUrl"];
                        aux.URLImagen.Add(imagen);
                    }

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
