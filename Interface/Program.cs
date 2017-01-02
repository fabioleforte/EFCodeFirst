
using Infra.Data.Models;
using System.Linq;
using System;
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new ModeloFeioContext();
            var pessoa = ctx.Pessoa.Include("Endereco").FirstOrDefault(p => p.Nome == "Fabio");

            Console.WriteLine(pessoa.Endereco.FirstOrDefault().Rua);
            Console.ReadLine();

        }
    }
}
