using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest.models
{
    public partial class Morada
    {
        public string rua;
        public string cidade;
        public string codPostal;
        public string pais;

        public Morada(string rua, string cidade, string codPostal, string pais)
        {
            this.rua = rua;
            this.cidade = cidade;
            this.codPostal = codPostal;
            this.pais = pais;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
