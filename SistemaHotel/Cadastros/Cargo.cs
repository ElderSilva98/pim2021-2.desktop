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
    public partial class FrmCargo : Form
    {
        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection(@"Data Source=GERENCIA\SQLEXPRESS;Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=91316896");

        string sql;
        SqlCommand cmd;
        string id;
        private DataSet dt;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";

            grid.Columns[0].Visible = false;

            grid.Columns[1].Width = 200;
        }
        private void Listar()
        {
            //Conexao.Open(); //Abrir a conexão
            //String query = "SELECT * FROM cargos order by cargo asc";
            //SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            //DataTable dt = new DataTable();
            //dp.Fill(dt);

            Conexao.Open();
            sql = "SELECT * FROM cargos order by cargo asc";
            cmd = new SqlCommand(sql, Conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            grid.DataSource = dt;
            Conexao.Close(); //Fechar a Conexão

            FormatarDG();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Enabled = true;

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();

        }
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
