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
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GestaoMercado
{
    public partial class GerencialProdutos : Form
    {
        Bitmap bmp;
        public GerencialProdutos()
        {
            InitializeComponent();
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

        }

        private void salvar_Click(object sender, EventArgs e)
        {

            MemoryStream memory = new MemoryStream();

            bmp.Save(memory, ImageFormat.Bmp);

            byte[] foto = memory.ToArray();

            string stringDeConexao = "Server=localhost;Database=sistemaMercado;Trusted_Connection=True;";

            SqlConnection conexao = new SqlConnection(stringDeConexao);

            SqlCommand comando = new SqlCommand("insert into tb_produtos (nome,quantidade,preco,imagem) VALUES(@nome, @quantidade, @preco, @imagem)", conexao);

            SqlParameter nome = new SqlParameter("@nome", SqlDbType.VarChar);
            SqlParameter quantidade = new SqlParameter("@quantidade", SqlDbType.Int);
            SqlParameter preco = new SqlParameter("@preco", SqlDbType.Decimal);
            SqlParameter imagem = new SqlParameter("@imagem", SqlDbType.VarChar);

            nome.Value = nomeProduto.Text;
            quantidade.Value = textBox2.Text;
            preco.Value = textBox3.Text;
            imagem.Value = foto;

            comando.Parameters.Add(nome);
            comando.Parameters.Add(quantidade);
            comando.Parameters.Add(preco);
            comando.Parameters.Add(imagem);

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
    }
}
