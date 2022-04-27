using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeux_des_des.Views;
namespace Jeux_des_des
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           // object[] luvut = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
          //  Console.WriteLine(Kuuluuko(luvut));
          
        }
  
      
    }
}
