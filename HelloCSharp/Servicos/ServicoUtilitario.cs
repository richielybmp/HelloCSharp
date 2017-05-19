using HelloCSharp.Enumeradores;
using HelloCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Servicos
{
    public class ServicoUtilitario
    {
        public static List<Carro> CrieListaDeCarros(int quantidade)
        {
            var listaDeCarros = new List<Carro>();

            string[] cores = new string[] { "Preto", "Branco", "Vermelho", "Prata" };
            string[] nomes = new string[] { "Hilux", "Palio", "Gol", "Camaro" };
            double[] precos = new double[] { 36.000, 45.000, 100.000, 74.000 };

            Random rdmObject = new Random();

            for (int i = 0; i < quantidade; i++)
            {
                int rdmCor = rdmObject.Next(4);
                int rdmNome = rdmObject.Next(4);
                int rdmPreco = rdmObject.Next(4);

                listaDeCarros.Add(

                    new Carro()
                    {
                        Ano = "201" + i.ToString(),
                        Cor = cores[rdmCor],
                        Nome = nomes[rdmNome],
                        Preco = precos[rdmPreco],
                        Tipo = new CodigoDescricao() { Codigo = i.ToString(), Descricao = Enum.GetNames(typeof(EnumTipoDeCarro))[rdmObject.Next(2)] }
                    }

                );
            }

            return listaDeCarros;
        }
    }
}
