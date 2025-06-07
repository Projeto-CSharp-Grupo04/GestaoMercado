namespace GestaoMercado;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        imageList1 = new ImageList(components);
        pictureBox1 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(117, 9);
        label1.Name = "label1";
        label1.Size = new Size(278, 37);
        label1.TabIndex = 0;
        label1.Text = "Acesso Administrativo";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F);
        label2.Location = new Point(266, 153);
        label2.Name = "label2";
        label2.Size = new Size(53, 20);
        label2.TabIndex = 1;
        label2.Text = "Login: ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F);
        label3.Location = new Point(266, 182);
        label3.Name = "label3";
        label3.Size = new Size(56, 20);
        label3.TabIndex = 2;
        label3.Text = "Senha: ";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(322, 179);
        textBox1.Name = "textBox1";
        textBox1.PasswordChar = '*';
        textBox1.Size = new Size(167, 23);
        textBox1.TabIndex = 3;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(322, 150);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(167, 23);
        textBox2.TabIndex = 4;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageSize = new Size(16, 16);
        imageList1.TransparentColor = Color.Transparent;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.merc1;
        pictureBox1.Location = new Point(0, 59);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(260, 255);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ButtonFace;
        button1.Location = new Point(322, 217);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 6;
        button1.Text = "Acessar";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.ButtonFace;
        button2.Location = new Point(403, 217);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 7;
        button2.Text = "Sair";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(505, 316);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private ImageList imageList1;
    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;
}
