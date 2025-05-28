using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercado
{
    internal class Program
    {
        public static void CriarNovoUsuario()
        {
            ConexaoMysql conexao = new ConexaoMysql();
            Console.WriteLine("digite o novo login");
            string login = Console.ReadLine();
            Console.WriteLine("digite a nova senha");
            string senha = Console.ReadLine();
            conexao.CriarUsuario(login, senha);
        }
        public static void LogarNoUsuario()
        {
            ConexaoMysql conexao = new ConexaoMysql();
            Console.WriteLine("digite o seu login");
            string login = Console.ReadLine();
            Console.WriteLine("digite a sua senha");
            string senha = Console.ReadLine();
            conexao.Login(login, senha);
        }
        public static void Main()
        {
            LogarNoUsuario();
        }
    }
}
