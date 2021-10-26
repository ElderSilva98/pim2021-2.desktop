using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaHotel.Cadastros
{
    public partial class FrmUsuarios : Form
    {
        //REFERENCIA DA CONEXAO
        SqlConnection Conexao = new SqlConnection(@"Data Source=" + FrmLogin.SERVERNAME + ";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
        private string strSQL;


        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            cbCargo.Enabled = true;
            txtSenha.Enabled = true;

        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            cbCargo.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            cbCargo.SelectedIndex = 0;
            txtSenha.Text = "";
        }

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                try
                {
                    strSQL = "INSERT INTO hotel.usuarios (nome,cargo,usuario,senha,data) values (@NOME,@CARGO,@USUARIO,@SENHA,@DATA)";
                    SqlCommand comando = new SqlCommand(strSQL, Conexao);
                    DateTime data = DateTime.Now;

                    comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("@CARGO", cbCargo.SelectedItem);
                    comando.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                    comando.Parameters.AddWithValue("@DATA", data);

                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    limparCampos();
                    desabilitarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                    strSQL = null;
                   
                }
            

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscarNome.Text != "")
            {
                try
                {
                    strSQL = "SELECT * FROM hotel.usuarios where nome = " + "'"+txtBuscarNome.Text+"'";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexao);

                    Conexao.Open();
                    da.Fill(ds);
                    grid.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                    strSQL = null;
                }
            }
            else
            {
                try
                {
                    strSQL = "SELECT * FROM hotel.usuarios";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(strSQL, Conexao);

                    Conexao.Open();
                    da.Fill(ds);
                    grid.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                    strSQL = null;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.SelectedRows != null)
            {
                btnEditar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
