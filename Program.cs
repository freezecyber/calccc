using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcc
{
    public static class Program
    {
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
     [STAThread]
       public static void Main()
        {

           
            Application.Run(new Form1());

        }

      
    }
}
