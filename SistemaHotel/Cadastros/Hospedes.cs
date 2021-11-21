using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmHospedes : Form
    {
        //REFERENCIA DA CONEXAO
        SqlConnection Conexao = new SqlConnection(@"Data Source=" + FrmLogin.SERVERNAME + ";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
        private string strSQL;


        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtCPF.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtCPF.Enabled = false;
        }

        public void limparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtCPF.Text = "";
        }

        public FrmHospedes()
        {
            InitializeComponent();
        }

        private void FrmHospedes_Load(object sender, EventArgs e)
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
                strSQL = "INSERT INTO hotel.hospedes (nome,cpf,endereco,telefone,data) values (@NOME,@CPF,@ENDERECO,@TELEFONE,@DATA)";
                SqlCommand comando = new SqlCommand(strSQL, Conexao);
                DateTime data = DateTime.Now;

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@CPF", txtCPF.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@DATA", data);

                Conexao.Open();
                comando.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                limparCampos();
                desabilitarCampos();
                btnSalvar.Enabled = false;
                Conexao.Close();
                strSQL = null;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "SELECT * FROM hotel.hospedes";
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
}
