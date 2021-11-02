using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImgEstoque_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFornecedores form = new Cadastros.FrmFornecedores();
            form.Show();
        }

        private void HóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmHospedes form = new Cadastros.FrmHospedes();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmVendas form = new Movimentacoes.FrmVendas();
            form.Show();
        }

        private void NovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmEstoque form = new Produtos.FrmEstoque();
            form.Show();
        }

        private void EstoqueBaixoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmEstoqueBaixo form = new Produtos.FrmEstoqueBaixo();
            form.Show();
        }

        private void QuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmQuartos form = new Cadastros.FrmQuartos();
            form.Show();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmUsuarios usuarios = new Cadastros.FrmUsuarios();
            usuarios.Show();
        }

        private void ServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmServicos form = new Cadastros.FrmServicos();
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Reservas.FrmConsultarReservas form = new Reservas.FrmConsultarReservas();
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Reservas.FrmReservas form = new Reservas.FrmReservas();
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Reservas.FrmCheckIn form = new Reservas.FrmCheckIn();
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Reservas.FrmCheckOut form = new Reservas.FrmCheckOut();
            form.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.FrmCheckOut form = new Reservas.FrmCheckOut();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuSair_Click(object sender, EventArgs e)
        {

        }
    }
}
