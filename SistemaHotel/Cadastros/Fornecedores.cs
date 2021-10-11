using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }
        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";

            grid.Columns[2].HeaderText = "Endereço";
            grid.Columns[3].HeaderText = "Telefone";


            grid.Columns[0].Visible = false;

            //grid.Columns[1].Width = 200;
        }
        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void habilitarCampos()
        {
            txtNome.Enabled = true;

            txtEndereco.Enabled = true;

            txtTelefone.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;

            txtEndereco.Enabled = false;

            txtTelefone.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";

            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

      

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                //CÓDIGO DO BOTÃO PARA EXCLUIR
                

                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }
    }
}
