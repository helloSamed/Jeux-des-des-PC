using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_des_des.Models
{
    class des
    {
        int id;
        string type;

        public des(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
    }
}
