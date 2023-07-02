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
    public class CNCategoria
    {

        public static string Insertar(int pId_Categoria, string pNombre, string pDescripcion)
        {

            CDCategoria objCDCategoria = new CDCategoria();

            objCDCategoria.Id_Categoria = pId_Categoria;
            objCDCategoria.Nombre = pNombre;
            objCDCategoria.Descripcion = pDescripcion;
            

            return objCDCategoria.Insertar(objCDCategoria);
        }//Fin del método Insertar


        public static string Actualizar(int pId_Categoria, string pNombre, string pDescripcion)
        {

            CDCategoria objCDCategoria = new CDCategoria();

            objCDCategoria.Id_Categoria = pId_Categoria;
            objCDCategoria.Nombre = pNombre;
            objCDCategoria.Descripcion = pDescripcion;


            return objCDCategoria.Insertar(objCDCategoria);
     
    }//Fin del método Actualizar


        //Método utilizado para obtener un DataTable con todos los datos de la tabla 
        //correspondiente

        public DataTable CategoriaConsultar(string miparametro)
        {
            CDCategoria objCDCategoria = new CDCategoria();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
                                            //El DataTable se llena con todos los datos devueltos
            dt = objCDCategoria.CategoriaConsultar(miparametro);
            return dt; //Se retorna el DataTable con los datos adquiridos
        }

    }
}
