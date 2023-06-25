using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            Producto.ActiveForm.Close();
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abririmagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Producto busqueda_Producto = new Busqueda_Producto();
            busqueda_Producto.ShowDialog();
        }
    }
}
