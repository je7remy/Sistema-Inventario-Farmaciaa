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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            Categoria.ActiveForm.Close();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            Consulta_Empleado consulta_empleado = new Consulta_Empleado();
            consulta_empleado.ShowDialog();
            
        }
    }
}
