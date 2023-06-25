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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            Empleado.ActiveForm.Close();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Empleado busqueda_Empleado = new Busqueda_Empleado();
            busqueda_Empleado.ShowDialog();
        }
    }
}
