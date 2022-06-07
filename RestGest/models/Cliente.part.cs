using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest
{
    public partial class Cliente
    {
        public string nif;
        public float totalGasto;

        public Cliente(string nif, float totalGasto)
        {
            this.nif = nif;
            this.totalGasto = totalGasto;
        }

        public override string ToString()
        {
            return $"{nif}";

        }
    }
}
