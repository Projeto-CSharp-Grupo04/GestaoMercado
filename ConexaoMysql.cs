using MySql.Data.MySqlClient;
namespace GestaoMercado
{
    internal class InformacoesUsuario
    {
        private string _nome;
        public string Nome
        {
            get { return _nome.ToUpper().Trim(); }
            set { _nome = value; }
        }
        private string _login;
        public string Login
        {
            get { return _login.ToUpper().Trim(); }
            set { _login = value; }
        }
        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
    internal class ConexaoMysql
    {
        private static string servidor = "localhost";
        private static string porta = "3307";
        private static string banco_de_dados = "sistema_mercado";
        private static string usuario = "root";
        private static string senha = "root";
        private static string dsn = "server=" + servidor + ";port=" + porta + ";database=" + banco_de_dados + ";user=" + usuario + ";password=" + senha;
        private MySqlConnection conexao = new MySqlConnection(dsn);
        public InformacoesUsuario Login(string login, string senha)
        {
            conexao.Open();
            string sql = "SELECT * FROM usuarios WHERE login_usuario = @login AND senha_usuario = @senha";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader busca = cmd.ExecuteReader();
            busca.Read();
            InformacoesUsuario retorno;
            if (busca.HasRows)
            {
                if (busca["login_usuario"].ToString().Equals(login) && busca["senha_usuario"].ToString().Equals(senha))
                {

                    retorno = new InformacoesUsuario();
                    retorno.Nome = busca["nome_usuario"].ToString();
                    retorno.Login = busca["login_usuario"].ToString();
                    busca.Close();
                }
            }
            else
            {
                busca.Close();
            }
            conexao.Close();
            return null;
        }
        public int CriarUsuario(string login, string senha)
        {
            conexao.Open();
            string sql = "INSERT INTO usuarios (login_usuario, senha_usuario) VALUES (@login, @senha)";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            int afetadas = cmd.ExecuteNonQuery();
            conexao.Close();
            return afetadas;
        }
        public InformacoesUsuario[] ListarUsuarios()
        {
            conexao.Open();
            string sql = "SELECT *, COUNT(id_usuario) AS numero_de_usuarios FROM usuarios";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader busca = cmd.ExecuteReader();
            InformacoesUsuario[] retorno = [];
            uint numero_de_resultados = 0;
            if (busca.HasRows)
            {
                uint i = 0;
                while (busca.Read())
                {
                    if (numero_de_resultados == 0)
                    {
                        numero_de_resultados = (uint) busca.GetInt32("numero_de_usuarios");
                        retorno = new InformacoesUsuario[numero_de_resultados];
                    }
                    retorno[i] = new InformacoesUsuario();
                    retorno[i].Nome = busca.GetString("nome_usuario");
                    retorno[i].Login = busca.GetString("login_usuario");
                    retorno[i].Senha = busca.GetString("senha_usuario");
                    i++;
                }
            }
            conexao.Close();
            return retorno;
        }
    }
}
