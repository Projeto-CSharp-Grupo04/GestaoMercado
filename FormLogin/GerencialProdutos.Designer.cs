namespace GestaoMercado
{
    partial class GerencialProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nomeProduto = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            imageList1 = new ImageList(components);
            button3 = new Button();
            editar = new Button();
            excluir = new Button();
            pictureBox1 = new PictureBox();
            salvar = new Button();
            BuscarImagem = new Button();
            selecionarImagem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(30, 41);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(260, 23);
            nomeProduto.TabIndex = 1;
            nomeProduto.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(109, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Quantidade";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 134);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Preço";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(43, 225);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button3
            // 
            button3.Location = new Point(99, 225);
            button3.Name = "button3";
            button3.Size = new Size(50, 23);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            editar.Location = new Point(154, 225);
            editar.Name = "editar";
            editar.Size = new Size(50, 23);
            editar.TabIndex = 9;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            excluir.Location = new Point(210, 225);
            excluir.Name = "excluir";
            excluir.Size = new Size(50, 23);
            excluir.TabIndex = 10;
            excluir.Text = "Excluir";
            excluir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(326, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 171);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // salvar
            // 
            salvar.Location = new Point(471, 225);
            salvar.Name = "salvar";
            salvar.Size = new Size(75, 23);
            salvar.TabIndex = 12;
            salvar.Text = "Salvar";
            salvar.UseVisualStyleBackColor = true;
            salvar.Click += salvar_Click;
            // 
            // BuscarImagem
            // 
            BuscarImagem.Location = new Point(326, 225);
            BuscarImagem.Name = "BuscarImagem";
            BuscarImagem.Size = new Size(75, 23);
            BuscarImagem.TabIndex = 13;
            BuscarImagem.Text = "Buscar";
            BuscarImagem.UseVisualStyleBackColor = true;
            BuscarImagem.Click += button4_Click;
            // 
            // selecionarImagem
            // 
            selecionarImagem.Location = new Point(402, 225);
            selecionarImagem.Name = "selecionarImagem";
            selecionarImagem.Size = new Size(75, 23);
            selecionarImagem.TabIndex = 14;
            selecionarImagem.Text = "Selecionar";
            selecionarImagem.UseVisualStyleBackColor = true;
            selecionarImagem.Click += button4_Click_1;
            // 
            // GerencialProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 277);
            Controls.Add(selecionarImagem);
            Controls.Add(BuscarImagem);
            Controls.Add(salvar);
            Controls.Add(pictureBox1);
            Controls.Add(excluir);
            Controls.Add(editar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(nomeProduto);
            Controls.Add(label1);
            Name = "GerencialProdutos";
            Text = "Gerenciamento";
            Load += GerencialProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeProduto;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private ImageList imageList1;
        private Button button3;
        private Button editar;
        private Button excluir;
        private PictureBox pictureBox1;
        private Button salvar;
        private Button BuscarImagem;
        private Button selecionarImagem;
    }
}