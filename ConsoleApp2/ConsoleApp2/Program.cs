using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Estoque
    {
        public string NomeProduto;
        public int Quantidade;
        public void Adicionar(int quantidade)
        {
            Quantidade = quantidade;
        }

        public void Remover(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente no estoque.");
            }
        }
        public void MostrarEstoque()
        {
            Console.WriteLine($"Produto:{NomeProduto}, Qunatidade: {Quantidade}");
        }
    }
}
