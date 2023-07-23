using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;

namespace Sistema_Inventario
{
    public partial class Producto : Form
    {
        public string valorparametro = "", mensaje = "";

        public Producto()
        {

            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            //Producto.ActiveForm.Close();
            this.Close();
        }

     



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                TRepresentaciongrafica.Text = abririmagen.FileName;
                TRepresentaciongrafica.ReadOnly = true;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

      

        private void Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                 MessageBoxButtons.YesNo
               , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Producto busqueda_Producto = new Busqueda_Producto();
            busqueda_Producto.ShowDialog();
            //Llamada al formulario para buscar los datos de la tabla correspondiente. Lo pondremos 
            //en comentario hasta que creemos dicho formulario.
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento();
            //fBuscarDepto.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
                Beditar_Click(sender, e); //Llamo al método editar
            }
            else

            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                Bbuscar.Focus();
            }

        }


        public void RecuperaDatos()
        {
            string vparametro = Program.vId_Producto.ToString();
            CNProducto CNProducto = new CNProducto();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = CNProducto.ProductoObtener (vparametro); //Llenamos el DataTable
                                                              //Recorremos cada fila del DataTable asignando a los controles de edición los valores de 
                                                              //los campos correspondientes
            foreach (DataRow row in dt.Rows)
            {
               // TId_producto.Text = row["Id_Producto"].ToString();
                TNombre.Text = row["Nombre"].ToString();
                CEstado.Text = row["Estado"].ToString();
                TMarca.Text = row["Marca"].ToString();
                TRepresentaciongrafica.Text = row["Representacion_Grafica"].ToString();
                DFecha_vencimiento.Text = row["Fecha_De_Vencimiento"].ToString();
                TExistencia.Text = row["Existencia"].ToString();
                TIdcategoria.Text = row["Id_Categoria"].ToString();
                TPrecio_venta.Text = row["Precio_De_Venta"].ToString();
                
            }
        } //Fin del metodo RecuperarDatos

        


        //Método propio para limpiar los objetos del formulario. Asegúrese de utilizar el nombre
        // correcto de cada objeto
        public void LimpiaObjetos()
        {
            //Para limpiar TextBox.
            TId_producto.Clear();
            TNombre.Clear();
            TMarca.Clear();
            DFecha_vencimiento.CustomFormat = "dd/MM/yyyy";
            DFecha_vencimiento.Format = DateTimePickerFormat.Custom;

            if (DFecha_vencimiento.Value == DateTime.MinValue)
            {
                DFecha_vencimiento.Text = "01/01/1750";
            }
            TExistencia.Clear();
            TIdcategoria.Clear();
            CEstado.SelectedItem = 0;
            pictureBox1.Image = null;
            TPrecio_venta.Clear();
            TRepresentaciongrafica.Clear();


        } //Fin del método LimpiaObjetos


       

        //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            TId_producto.ReadOnly = true;
            TNombre.Enabled = valor;//la propiedad ReadOnly hace de solo lectura un objeto
            TMarca.Enabled = valor; //la propiedad Enabled habilita o inhabilita un objeto
            TExistencia.Enabled = valor;
            //DFecha_vencimiento.Valor;
            TIdcategoria.Enabled = valor;
            CEstado.Enabled = valor;
            pictureBox1.Enabled = valor;
            TRepresentaciongrafica.Enabled = valor;
            button1.Enabled = valor;
            DFecha_vencimiento.Enabled = valor;
            TPrecio_venta.Enabled = valor;

            if (Program.nuevo)
            TIdcategoria.Clear();
            CEstado.SelectedIndex = 0;
          
        } //Fin del método HabilitaControles

        private void Bnuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitaBotones(); //Se habilitan solo aquellos botones que sean necesarios
            TNombre.Focus(); //Coloca el cursor en el TextBox indicado
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
            //if (TId_producto.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar 
            //{ // el cursor en dicho textbox 
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    TId_producto.Focus();
            //}
            //else
            if (TNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TNombre.Focus();
            }
            else
            if (TMarca.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TMarca.Focus();
            }
            else
            if (TExistencia.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TExistencia.Focus();
            }
            else
            if (TIdcategoria.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TIdcategoria.Focus();
            }
            else
            if (CEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                CEstado.Focus();
            }
            else
            if (TRepresentaciongrafica.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
              
            }
            else
            if (TPrecio_venta.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                TPrecio_venta.Focus();
            }

            else
            {
                //Si todo es correcto procede a Insertar o actualizar según corresponda, usaremos las 
                //variables globales a toda la solución contenidas en Program.CS
                if (Program.nuevo) //Si la variable nuevo llega con valor true se van a Insertar nuevos datos
                {

                    //string existencia = TExistencias.Text;
                    //string existencia = TExistencia.ToString();

                    string categoria = TIdcategoria.Text; // Si CIdcategoria es un ComboBox
                    string existencia = TExistencia.Text;
                    string precioventa = TPrecio_venta.Text;

                    mensaje = CNProducto.Insertar(Program.vId_Producto,
                                                  TNombre.Text,
                                                  int.Parse(categoria), // Asumiendo que pId_Categoria es de tipo int
                                                  CEstado.Text,
                                                  TMarca.Text,
                                                  DFecha_vencimiento.Value,
                                                  TRepresentaciongrafica.Text,
                                                  int.Parse(existencia), // Asumiendo que pExistencia es de tipo int
                                                  decimal.Parse(precioventa)); // Asumiendo que pPrecio_De_Venta es de tipo int

                }
                else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                   
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario. 
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado

                    string categoria = TIdcategoria.Text; 
                    string existencia = TExistencia.Text;
                    string precioventa = TPrecio_venta.Text;

                    mensaje = CNProducto.Actualizar(Program.vId_Producto,
                                                  TNombre.Text,
                                                  int.Parse(categoria), 
                                                  CEstado.Text,
                                                  TMarca.Text,
                                                  DFecha_vencimiento.Value,
                                                  TRepresentaciongrafica.Text,
                                                  int.Parse(existencia), 
                                                  int.Parse(precioventa)); 

                }
                //Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación 
                MessageBox.Show(mensaje, "Mensage de Botica Sila", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Se prepara todo para la próxima operación
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones(); //Habilita los objetos y botones correspondientes
                LimpiaObjetos(); //Llama al método LimpiaObjetos
            } //Fin del else para validar los datos
              //            j) Hacer doble clic en un lugar vacío del formulario para generar el evento Load del mismo.
              //Este se ejecuta cuando se habilita el formulario. Escribir dentro el siguiente código:
            Program.nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.modificar = false;

            HabilitaBotones(); //Se habilitarán los objetos y los botones necesarios.

        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!TId_producto.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un producto para poder Modificar sus datos!");
            }
        }

        private void Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            //Program.nuevo;
            TRepresentaciongrafica.TextChanged += TRepresentaciongrafica_TextChanged;
            // Deshabilitar el TextBox
            //TRepresentaciongrafica.Enabled = false;
        }

        private void Producto_Activated(object sender, EventArgs e)
        {
            Program.nuevo = true;
        }

        private void TRepresentaciongrafica_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto del TextBox no está vacío
            if (!string.IsNullOrEmpty(TRepresentaciongrafica.Text))
            {
                // Asignar la imagen del PictureBox usando la dirección de la imagen proporcionada por el TextBox
                pictureBox1.ImageLocation = TRepresentaciongrafica.Text;

                // Asegurarse de que la imagen se ajuste correctamente al tamaño del PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // Deshabilitar el TextBox
                TRepresentaciongrafica.ReadOnly = true;
            }
        }



        //Habilita los botones según el valor que tengan las variables globales nuevo y modificar
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                Bnuevo.Enabled = false;
                Bguardar.Enabled = true;
                Beditar.Enabled = false;
                Bbuscar.Enabled = false;
                Bcancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false); //Llamada al método para inhabilitar los objetos
                Bnuevo.Enabled = true;
                Bguardar.Enabled = false;
                Beditar.Enabled = false;
                Bbuscar.Enabled = true;
                Bcancelar.Enabled = false;
            }
        }


    }

}