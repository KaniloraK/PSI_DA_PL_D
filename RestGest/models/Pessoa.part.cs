using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest.models
{
    public partial class Pessoa
    {
        public string nome;
        public string telemovel;

        public Pessoa(string nome, string telemovel)
        {
            this.nome = nome;
            this.telemovel = telemovel;
        }

        public override string ToString()
        {
            return $"{nome} | {telemovel}";

        }
    }
}
