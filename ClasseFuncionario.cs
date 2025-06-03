using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Funcionario

    {
      
        {
           public string Nome {  get; set; }
           public string Cpf { get; set; }
           public string Cargo { get; set; }
           public double Salario { get; set; }
        
        public Funcionario(string nome, string cpf, string cargo, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
            Salario = salario;
        }

            public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Funcionario.Nome}");
            Console.WriteLine($"Cpf: {Funcionario.Cpf}");
            Console.WriteLine($"Cargo: {Funcionario.Cargo}");
            Console.WriteLine($"Cargo: {Funcionario.Salario}"};
        }
    }
}
    

