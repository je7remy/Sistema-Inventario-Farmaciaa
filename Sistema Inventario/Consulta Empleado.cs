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
    public partial class Consulta_Empleado : Form
    {
        public Consulta_Empleado()
        {
            InitializeComponent();
        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
           Busqueda_Empleado.ActiveForm.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }
    }
}
