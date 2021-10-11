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

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection(@"Data Source=GERENCIA\SQLEXPRESS;Initial Catalog=hotel;Persist Security Info=True;User ID=pim4;Password=pim4");
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Select();
            pnlLogin.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);

        }

        //Botão Login
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            Conexao.Open(); //Abrir a conexão
            String query = "SELECT * FROM hotel.usuarios where usuario = '" + txtUsuario.Text + "' AND senha = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                FrmMenu frmMenu = new FrmMenu();
                this.Hide();
                frmMenu.Show();
                Conexao.Close(); //Fechar a Conexão
            }

            else
            {
                MessageBox.Show("Erro ao Logar!", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = ""; //Limpa o campo Usuário
                txtSenha.Text = ""; //Limpa o campo Senha
                txtUsuario.Select(); // Cursor irá para o campo Usuário
            }
        }
        //Para centralizar o btnLogin
        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
