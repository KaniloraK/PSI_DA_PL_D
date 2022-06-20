using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest
{
    public partial class Cliente
    {
        public string numContribuinte;
        public float totalGasto;

        public Cliente(string numContribuinte, float totalGasto)
        {
            this.numContribuinte = numContribuinte;
            this.totalGasto = totalGasto;
        }

        public override string ToString()
        {
            return $"{numContribuinte}";

        }
    }
}
