using BLL;
namespace ListaTel
{
    public partial class Form1 : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Dados Tele = new Dados();
            Tele.Nome = txtNome.Text;
            Tele.Telefone = txtTel.Text;

            Repositorio.Incluir(Tele);
            MessageBox.Show("Adicionado");

            txtNome.Text = "";
            txtTel.Text = "";

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listListaTel.Items.Clear();
            foreach (var al in Repositorio.Tele)
            {
                listListaTel.Items.Add(al);
            }
        }

        private void lblList_Click(object sender, EventArgs e)
        {

        }
    }
}