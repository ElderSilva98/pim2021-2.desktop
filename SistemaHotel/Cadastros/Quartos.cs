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
    public partial class FrmQuartos : Form
    {

        //REFERENCIA DA CONEXAO
        SqlConnection Conexao = new SqlConnection(@"Data Source=" + FrmLogin.SERVERNAME + ";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
        private string strSQL;


        public void habilitarCampos()
        {
            txtQuarto.Enabled = true;
            txtPessoas.Enabled = true;
            txtValor.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtQuarto.Enabled = false;
            txtPessoas.Enabled = false;
            txtValor.Enabled = false;
        }

        public void limparCampos()
        {
            txtQuarto.Text = "";
            txtPessoas.Text = "";
            txtValor.Text = "";
        }

        public FrmQuartos()
        {
            InitializeComponent();
        }

        private void FrmQuartos_Load(object sender, EventArgs e)
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
                strSQL = "INSERT INTO hotel.quartos (quarto,valor,pessoas) values (@QUARTO,@VALOR,@PESSOAS)";
                SqlCommand comando = new SqlCommand(strSQL, Conexao);
                DateTime data = DateTime.Now;

                comando.Parameters.AddWithValue("@QUARTO", txtQuarto.Text);
                comando.Parameters.AddWithValue("@VALOR", txtValor.Text);
                comando.Parameters.AddWithValue("@PESSOAS", txtPessoas.Text);

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
            if(txtBuscar.Text == "")
            {
                try
                {
                    strSQL = "SELECT quarto,valor,pessoas FROM hotel.quartos";
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
}
