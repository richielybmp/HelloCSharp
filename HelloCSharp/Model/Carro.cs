using HelloCSharp.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Model
{
    public class Carro
    {
        public string Ano { get; set; }

        public string Cor { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public CodigoDescricao Tipo { get; set; }
    }
}
