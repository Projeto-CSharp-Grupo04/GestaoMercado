namespace GestaoMercado;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if ((textBox2.Text == "adm") && (textBox1.Text == "123"))
        {
            GerencialProdutos gerencial = new GerencialProdutos();
            gerencial.Show();

            this.Hide();
        }
        else
        {
            MessageBox.Show("Login ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
