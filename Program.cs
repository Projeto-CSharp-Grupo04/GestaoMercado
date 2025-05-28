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
            try
            {
                Menu menu = new Menu();
                menu.MostrarApresentacao();
                menu.MostrarComandos();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Erro: {0}", excecao.Message);
                Console.WriteLine("Stack trace: {0}", excecao.StackTrace);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para sair ...");
                Console.ReadKey();
            }
        }
    }
}
