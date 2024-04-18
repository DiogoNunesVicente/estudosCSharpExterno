
namespace WinFormsAppAprendendoNaMarra
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            groupBox1 = new GroupBox();
            btnCadastro = new Button();
            txtSenha1 = new TextBox();
            txtSenha2 = new TextBox();
            txtNomeUsuario = new TextBox();
            label3 = new Label();
            labelSenha = new Label();
            labelNomeUsuario = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(btnCadastro);
            groupBox1.Controls.Add(txtSenha1);
            groupBox1.Controls.Add(txtSenha2);
            groupBox1.Controls.Add(txtNomeUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelSenha);
            groupBox1.Controls.Add(labelNomeUsuario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Transparent;
            btnCadastro.Location = new Point(102, 177);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(75, 24);
            btnCadastro.TabIndex = 6;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click_1;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(73, 95);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(131, 23);
            txtSenha1.TabIndex = 5;
            // 
            // txtSenha2
            // 
            txtSenha2.Location = new Point(73, 148);
            txtSenha2.Name = "txtSenha2";
            txtSenha2.Size = new Size(131, 23);
            txtSenha2.TabIndex = 4;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(73, 51);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(131, 23);
            txtNomeUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(59, 130);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite Sua Senha Novamente";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Location = new Point(90, 77);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(98, 15);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Digite Sua Senha ";
            // 
            // labelNomeUsuario
            // 
            labelNomeUsuario.AutoSize = true;
            labelNomeUsuario.BackColor = Color.Transparent;
            labelNomeUsuario.ForeColor = Color.Black;
            labelNomeUsuario.Location = new Point(90, 33);
            labelNomeUsuario.Name = "labelNomeUsuario";
            labelNomeUsuario.Size = new Size(99, 15);
            labelNomeUsuario.TabIndex = 0;
            labelNomeUsuario.Text = "Nome de Usuario";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 326);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 94);
            listBox1.TabIndex = 7;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 450);
            Controls.Add(groupBox1);
            Name = "FormCadastro";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSenha1;
        private TextBox txtSenha2;
        private TextBox txtNomeUsuario;
        private Label label3;
        private Label labelSenha;
        private Label labelNomeUsuario;
        private Button btnCadastro;
        private ListBox listBox1;
    }
}
