using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest.models
{


    public partial class Trabalhador
    {
        public double salario;
        public string posicao;

        public Trabalhador(double salario, string posicao)
        {
            this.salario = salario;
            this.posicao = posicao;
        }
    }
}
