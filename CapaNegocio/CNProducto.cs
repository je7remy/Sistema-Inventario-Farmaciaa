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
            objCDProducto.Id_Categoria = pId_Categoria;
            objCDProducto.Estado = pEstado;
            objCDProducto.Marca = pMarca;
            objCDProducto.Fecha_De_Vencimiento = pFecha_De_Vencimiento;
            objCDProducto.Representacion_Grafica = pRepresentacion_Grafica;
            objCDProducto.Existencia = pExistencia;
            objCDProducto.Precio_De_Venta = pPrecio_De_Venta;

            return objCDProducto.Insertar(objCDProducto);
        }//Fin del método Insertar


        public static string Actualizar(int pId_Producto, string pNombre, int pId_Categoria, string pEstado, string pMarca,
            DateTime pFecha_De_Vencimiento, string pRepresentacion_Grafica, int pExistencia, decimal pPrecio_De_Venta)
        {

            CDProducto objCDProducto = new CDProducto();
            objCDProducto.Id_Producto = pId_Producto;
            objCDProducto.Nombre = pNombre;
            objCDProducto.Id_Categoria = pId_Categoria;
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

        public DataTable ProductoObtener(string miparametro)
        {
            CDProducto objCDProducto = new CDProducto();
            DataTable dt = new DataTable(); // Creamos un nuevo DataTable

            // Creamos la conexión al procedimiento almacenado "ProductoConsultar"
            using (SqlConnection sqlCon = new SqlConnection(InventarioConexion.miconexion))
            {
                using (SqlCommand sqlCommand = new SqlCommand("ProductoConsultar", sqlCon))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Verificamos si el parámetro es numérico y válido, y lo pasamos al procedimiento
                    if (!string.IsNullOrEmpty(miparametro) && int.TryParse(miparametro, out int idProducto))
                    {
                        sqlCommand.Parameters.AddWithValue("@pId_Producto", idProducto);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@pId_Producto", DBNull.Value);
                    }

                    // Abrimos la conexión y ejecutamos el comando para llenar el DataTable con los datos del producto
                    sqlCon.Open();
                    SqlDataReader leerDatos = sqlCommand.ExecuteReader();
                    dt.Load(leerDatos);
                }
            }

            return dt; // Retornamos el DataTable con los datos del producto
        }



        public DataTable ProductoObtenerTodos()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\C#\Sistema-Inventario-Farmacia\CapaDatos\DBInventario.mdf;
Integrated Security = True"; // Reemplaza esto con la cadena de conexión a tu base de datos
            string consulta = "SELECT * FROM Producto"; // Reemplaza "tabla_empleados" con el nombre de tu tabla de empleados

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dt.Load(reader);
            }

            return dt;
        }


       
    }
}
