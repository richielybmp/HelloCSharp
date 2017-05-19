///-----------------------------------------------------------------
///   Namespace:      <Class Namespace>
///   Class:          <Class Name>
///   Description:    <Description>
///   Author:         <Author>                    Date: <DateTime>
///   Notes:          <Notes>
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloCSharp.Servicos;
using HelloCSharp.Model;
using HelloCSharp.Enumeradores;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var novoCarro = new Carro()
            {
                Ano = "2017",
                Cor = "Preto",
                Nome = "Gol",
                Preco = 30.000, 
                Tipo = new CodigoDescricao() {Codigo = "1", Descricao= "1 - Carro" }
            };

            Console.WriteLine("Carro: " + novoCarro.Tipo.Descricao);
            Console.WriteLine();

            var listaDeCarros = ServicoUtilitario.CrieListaDeCarros(5);

            foreach (var item in listaDeCarros)
            {
                Console.WriteLine("Carros:");
                Console.WriteLine("Tipo: " + item.Tipo.Descricao);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Ano: " + item.Ano);
                Console.WriteLine("Cor: " + item.Cor);
                Console.WriteLine("Preco: " + item.Preco);
                Console.WriteLine();
            }

            Console.WriteLine(listaDeCarros.Where(carro => carro.Cor == "Preto").First().Nome);

            Console.Read();
        }
    }
}
