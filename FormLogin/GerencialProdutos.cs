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

            const string string_conexao = @"";

            SqlConnection conexao = new SqlConnection();




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog.FileName;
                // Aqui você pode usar o nome do arquivo como quiser
                MessageBox.Show("Arquivo selecionado: " + nome);
            }
        }
    }
}
