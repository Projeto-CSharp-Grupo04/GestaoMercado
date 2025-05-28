namespace GestaoMercado
{
    internal class Menu
    {
        private string[] comandos =
        {
            "listar comandos",
            "criar usuario",
            "logar usuario",
            "mudar usuario",
            "editar usuario"
        };
        public void MostrarApresentacao()
        {
            Console.WriteLine("+--------------------+");
            Console.WriteLine("| Sistema de Mercado |");
            Console.WriteLine("+--------------------+");
        }
        public void MostrarComandos()
        {
            int maior_comando = 0;
            string borda = "+";
            for (int i = 0; i < comandos.Length; i++)
            {
                if (comandos[i].Length > maior_comando)
                {
                    maior_comando = comandos[i].Length;
                }
            }
            for (int i = 0; i < maior_comando - 1; i++)
            {
                borda.Concat("-");
            }
            borda.Concat("+");
            Console.WriteLine(borda);
            for (int i = 0; i < comandos.Length; i++)
            {
                string margem = "";
                for (int j = 0; j < maior_comando - comandos[i].Length; j++)
                {
                    margem.Concat(" ");
                }
                Console.WriteLine("| {0}{1} |", comandos[i], margem);
            }
            Console.WriteLine(borda);
        }
    }
}
