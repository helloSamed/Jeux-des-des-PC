using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace Jeux_des_des.BusinessLayer
{
    class DesManagement
    {
        public object randomResult(object[] luvut)
        {

            var random = new Random();
            object k= luvut[random.Next(0, luvut.Length)];
            return k;
        } 
        public object randomNumero(int k)
        {

            var random = new Random();
           int result=random.Next(0, k);
            return result;
        }
  
     
    }
}
