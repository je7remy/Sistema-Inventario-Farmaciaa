using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static string Insertar(int pId_Producto, string pNombre, int pId_Categoria, string pEstado, string pMarca,
            DateTime pFecha_De_Vencimiento, string pRepresentacion_Grafica, int pExistencia, decimal pPrecio_De_Venta)
        {

            CDProducto objCDProducto = new CDProducto();

            objCDProducto.Id_Producto = pId_Producto;
            objCDProducto.Nombre = pNombre;
            objCDProducto.Estado = pEstado;
            objCDProducto.Marca = pMarca;
            objCDProducto.Fecha_De_Vencimiento = pFecha_De_Vencimiento;
            objCDProducto.Representacion_Grafica = pRepresentacion_Grafica;
            objCDProducto.Existencia = pExistencia;
            objCDProducto.Precio_De_Venta = pPrecio_De_Venta;

            return objCDProducto.Insertar(objCDProducto);
        }//Fin del método Insertar


        public static string Actualizar(string pNombre, int pId_Categoria, string pEstado, string pMarca,
            DateTime pFecha_De_Vencimiento, string pRepresentacion_Grafica, int pExistencia, decimal pPrecio_De_Venta)
        {

            CDProducto objCDProducto = new CDProducto();

            objCDProducto.Nombre = pNombre;
            objCDProducto.Estado = pEstado;
            objCDProducto.Marca = pMarca;
            objCDProducto.Fecha_De_Vencimiento = pFecha_De_Vencimiento;
            objCDProducto.Representacion_Grafica = pRepresentacion_Grafica;
            objCDProducto.Existencia = pExistencia;
            objCDProducto.Precio_De_Venta = pPrecio_De_Venta;

            string resultado = objCDProducto.Actualizar(objCDProducto);
            return resultado;
        }//Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla 
        //correspondiente

        public DataTable ProductoConsultar(string miparametro)
        {
            CDProducto objCDProducto = new CDProducto();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCDProducto.ProductoConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

    }
}
