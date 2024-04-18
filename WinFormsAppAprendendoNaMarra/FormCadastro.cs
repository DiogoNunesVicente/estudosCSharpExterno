namespace WinFormsAppAprendendoNaMarra
{
    public partial class FormCadastro : Form
    {
        cadastro cadastro = new cadastro();
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            cadastro = new cadastro();

            cadastro.Nome = txtNomeUsuario.Text;
            cadastro.Senha = txtSenha1.Text;
            cadastro.confirmarSenha = txtSenha2.Text;

            if (cadastro.Senha==cadastro.confirmarSenha){

                MessageBox.Show("cadastro realizado com sucesso");

                string DadosCadastro = "Nome:" + cadastro.Nome;

                listBox1.Items.Add(DadosCadastro);

             }
            else
            {
                MessageBox.Show("Não foi possivél realizar seu cadastro (Senhas diferentes)");
            }
           

            
        }
    }
}
