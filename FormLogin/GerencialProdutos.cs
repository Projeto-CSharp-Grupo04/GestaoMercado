using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GestaoMercado
{
    public partial class GerencialProdutos : Form
    {
        Bitmap bmp;

        string stringDeConexao = "Server=localhost;Database=sistemaMercado;Uid=root;Pwd=root;";
        MySqlConnection conexao;

        public GerencialProdutos()
        {
            InitializeComponent();
            conexao = new MySqlConnection(stringDeConexao);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GerencialProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_produto WHERE nome = @nome", conexao);

            MySqlParameter nome = new MySqlParameter("@nome", MySqlDbType.VarChar);

            nome.Value = nomeProduto.Text;

            comando.Parameters.Add(nome);

            try
            {
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    nomeProduto.Text = reader[1].ToString();
                    byte[] imagem = (byte[])(reader[4]);

                    if (imagem == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(imagem);

                        pictureBox1.Image = System.Drawing.Image.FromStream(memory);
                    }
                }

                conexao.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {

            MemoryStream memory = new MemoryStream();

            bmp.Save(memory, ImageFormat.Bmp);

            byte[] foto = memory.ToArray();

            MySqlCommand comando = new MySqlCommand("insert into tb_produto (nome,quantidade,preco,imagem) VALUES(@nome, @quantidade, @preco, @imagem)", conexao);

            MySqlParameter nome = new MySqlParameter("@nome", MySqlDbType.VarChar);
            MySqlParameter quantidade = new MySqlParameter("@quantidade", MySqlDbType.Int32);
            MySqlParameter preco = new MySqlParameter("@preco", MySqlDbType.Decimal);
            MySqlParameter imagem = new MySqlParameter("@imagem", MySqlDbType.MediumBlob);

            nome.Value = nomeProduto.Text;
            quantidade.Value = int.Parse(textBox2.Text);
            preco.Value = decimal.Parse(textBox3.Text);
            imagem.Value = foto;

            comando.Parameters.Add(nome);
            comando.Parameters.Add(quantidade);
            comando.Parameters.Add(preco);
            comando.Parameters.Add(imagem);

            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            conexao.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog.FileName;

                bmp = new Bitmap(nome);

                pictureBox1.Image = bmp;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
