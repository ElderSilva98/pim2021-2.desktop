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
    public partial class FrmServicos : Form
    {

        //REFERENCIA DA CONEXAO
        SqlConnection Conexao = new SqlConnection(@"Data Source=" + FrmLogin.SERVERNAME + ";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
        private string strSQL;


        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtValor.Enabled = false;
        }

        public void limparCampos()
        {
            txtNome.Text = "";
            txtValor.Text = "";
        }

        public FrmServicos()
        {
            InitializeComponent();
        }

        private void FrmServicos_Load(object sender, EventArgs e)
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
                strSQL = "INSERT INTO hotel.servicos (nome,valor) values (@NOME,@VALOR)";
                SqlCommand comando = new SqlCommand(strSQL, Conexao);
                DateTime data = DateTime.Now;

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);

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
                strSQL = "SELECT * FROM hotel.servicos";
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
