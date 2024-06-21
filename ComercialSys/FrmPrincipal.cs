namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin login = new();
            //login.MdiParent = this;
            login.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            login.ShowDialog();

            tslUsuario.Text = Program.Usuario.Nome + " - " + Program.Usuario.Nivel.Nome;
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoria = new FrmCategoria();
            frmcategoria.MdiParent = this;
            frmcategoria.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPedido frmpedido = new FrmPedido();
            frmpedido.MdiParent = this;
            frmpedido.Show();
        }
    }
}
