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

namespace SistemaHotel.Reservas
{
    public partial class FrmReservas : Form
    {

        //REFERENCIA DA CONEXAO
        SqlConnection Conexao = new SqlConnection(@"Data Source=" + FrmLogin.SERVERNAME + ";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
        private string strSQL;

        public void limparCampos()
        {
            txtDias.Text = "";
            txtNome.Text = "";
        }

        public void habilitarCampos()
        {
            txtDias.Enabled = true;
            txtNome.Enabled = true;
            cbQuarto.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtDias.Enabled = false;
            txtNome.Enabled = false;
            cbQuarto.Enabled = false;
        }


        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
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
                strSQL = "INSERT INTO hotel.reservas (hospede,quarto,data,dias) values (@HOSPEDE,@QUARTO,@DATA,@DIAS)";
                SqlCommand comando = new SqlCommand(strSQL, Conexao);
                DateTime data = calendario.SelectionStart;

                comando.Parameters.AddWithValue("@HOSPEDE", txtNome.Text);
                comando.Parameters.AddWithValue("@QUARTO", cbQuarto.Text);
                comando.Parameters.AddWithValue("@DATA", data);
                comando.Parameters.AddWithValue("@DIAS", txtDias.Text);

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
                btnSalvar.Enabled = false;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                try
                {
                    strSQL = "SELECT hospede,quarto,data,dias FROM hotel.reservas where hospede = " + "'" + txtBuscar.Text + "'";
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
                    strSQL = "SELECT * FROM hotel.reservas";
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
