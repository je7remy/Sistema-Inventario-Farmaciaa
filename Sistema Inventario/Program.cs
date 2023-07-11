using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario
{  

   public static class Program
    {
       
        public static bool nuevo;
        public static bool modificar;
        public static int vtextBox1;
    

        //public static int vtextBox2;
        //public static int vtextBox2;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fmenu());
        
        }
    }
}
