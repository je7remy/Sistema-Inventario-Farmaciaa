using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;


namespace Sistema_Inventario
{
    public partial class Movimiento_Inventario : Form
    {
       
        public string valorparametro = "", mensaje = "";
        public static int vId_Inventario = 0, Cantidad = 0;
        public static string Empleado, Tipo_De_Movimiento, Nombre, Representacion_Grafica;
        public static DateTime Fecha;
        public static bool selecciono = false;
        public static string miconexion = "Data Source=HDX16T; Initial Catalog = DBInventario; Integrated Security = True;";



        public Movimiento_Inventario()
        {
            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            //Close();
            Movimiento_Inventario.ActiveForm.Close();
            
        }

       

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Empleado busqueda_Empleado = new Busqueda_Empleado();
            busqueda_Empleado.ShowDialog();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sólo se permiten números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsPunctuation(e.KeyChar)) //permitir punto
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vId_Inventario = 0;
            Busqueda_Producto busqueda_producto = new Busqueda_Producto();
            busqueda_producto.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
              
            }
            else

            {
                MessageBox.Show("no se pudo");
               
            }

        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            button1.Focus();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void Bguardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
            //if (TId_producto.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar 
            //{ // el cursor en dicho textbox 
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    TId_producto.Focus();
            //}
            //else
            if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                comboBox3.Focus();
            }
            else
            if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                textBox4.Focus();
            }
            else
            if (comboBox4.Text == String.Empty)
            {
                MessageBox.Show("Debe rellenar todos los campos!");
                comboBox4.Focus();
            }
            else
            //if (dateTimePicker1.Text == String.Empty)
            //{
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    dateTimePicker1.Focus();
            //}
            //else
            //if (textBox2.Text == String.Empty)
            //{
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    textBox2.Focus();
            //}
            //else
            //if (TRepresentaciongrafica.Text == String.Empty)
            //{
            //    MessageBox.Show("Debe rellenar todos los campos!");

            //}
            //else
            //if (TRepresentaciongrafica.Text == String.Empty)
            //{
            //    MessageBox.Show("Debe rellenar todos los campos!");
            //    TRepresentaciongrafica.Focus();
            //}

            //else
            {
                //Si todo es correcto procede a Insertar o actualizar según corresponda, usaremos las 
                //variables globales a toda la solución contenidas en Program.CS
                if (Program.nuevo) //Si la variable nuevo llega con valor true se van a Insertar nuevos datos
                {

                    //string existencia = TExistencias.Text;
                    //string existencia = TExistencia.ToString();

                    string cantidad = textBox4.Text; // Si CIdcategoria es un ComboBox
                    string empleado = comboBox3.Text; // Si CIdcategoria es un ComboBox
                    //string existencia = TExistencia.Text;
                    //string precioventa = TPrecio_venta.Text;

                    mensaje = CNMovimientoInventario.Insertar(Program.vMovimiento_Inventario,Program.vId_Producto,
                                                  int.Parse(cantidad),
                                                  comboBox4.Text,
                                                 int.Parse(empleado),
                                                  dateTimePicker1.Value);
                    //DFecha_vencimiento.Value,
                    //TRepresentaciongrafica.Text,
                    //int.Parse(existencia), // Asumiendo que pExistencia es de tipo int
                    //decimal.Parse(precioventa)); // Asumiendo que pPrecio_De_Venta es de tipo int

                }
               
                //Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación 
                MessageBox.Show(mensaje, "Mensage de Botica Sila", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Se prepara todo para la próxima operación
                Program.nuevo = false;
                Program.modificar = false;
              
            } //Fin del else para validar los datos
              //            j) Hacer doble clic en un lugar vacío del formulario para generar el evento Load del mismo.
              //Este se ejecuta cuando se habilita el formulario. Escribir dentro el siguiente código:
            Program.nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.modificar = false;

         

        
    }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                Cantidad = Convert.ToInt32(textBox4.Text);
                if (Cantidad < Cantidad)
                {
                    MessageBox.Show("No hay suficiente existencia de la mercancia indicada!"); 
                   
                    button1.Focus();
                }
                else
                {
                    button1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe indicar la cantidad vendida!");
                button1.Focus();
            }
        }

        private void Movimiento_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n¿Seguro que desea hacerlo?", "Mensaje de Botica Sila",
                 MessageBoxButtons.YesNo
               , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Limpiar()
        {

            textBox1.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox4.Text = string.Empty;
            dateTimePicker1.Value = System.DateTime.Now.Date;
            textBox2.Text = string.Empty;
            pictureBox1.Image = null;

        }


        public void RecuperaDatos()
        {
            string vparametro = Program.vMovimiento_Inventario.ToString();
            CNMovimientoInventario cnmovimientoinventario = new CNMovimientoInventario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = cnmovimientoinventario.MovimientoInventarioConsultar(vparametro); //Llenamos el DataTable
                                                         //Recorremos cada fila del DataTable asignando a los controles de edición los valores de 
                                                         //los campos correspondientes
            foreach (DataRow row in dt.Rows)
            {
                textBox1.Text = row["Id_Inventario"].ToString();
                textBox2.Text = row["Id_Producto"].ToString();
                textBox4.Text = row["Cantidad"].ToString();
                comboBox4.Text = row["Tipo_De_Movimiento"].ToString();
                comboBox3.Text = row["Id_Empleado"].ToString();
                //  TRepresentaciongrafica.Text = row["Representacion_Grafica"].ToString();
                dateTimePicker1.Text = row["Fecha"].ToString();
                //TExistencia.Text = row["Existencia"].ToString();
                //TIdcategoria.Text = row["Id_Categoria"].ToString();
                //// MessageBox.Show(TIdcategoria.Text);
                //TPrecio_venta.Text = row["Precio_De_Venta"].ToString();

            }
        } //Fin del metodo RecuperarDatos

    }
}
