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
        //CONSTANTES
        public const string SERVERNAME = "DESKTOP-91L4B2A";

        SqlDataReader read;
        SqlCommand cmdVerificar;


        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection(@"Data Source="+ SERVERNAME +";Initial Catalog=hotel;Persist Security Info=True;User ID=sa;Password=789456");
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

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void ChamarLogin()
        {
            if (txtUsuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Usuário", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a Senha", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            //AQUI VAI O CÓDIGO PARA O LOGIN
            Conexao.Open(); //Abrir a conexão
            cmdVerificar = new SqlCommand("SELECT * FROM hotel.usuarios where usuario = @usuario and senha = @senha", Conexao);
            cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
            read = cmdVerificar.ExecuteReader();

            if (read.HasRows)
            {


                {
                    while (read.Read())
                    {
                        Program.nomeUsuario = Convert.ToString(read["nome"]);
                        Program.cargoUsuario = Convert.ToString(read["cargo"]);
                    }

                    MessageBox.Show("Bem Vindo! " + Program.nomeUsuario, "Login Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMenu form = new FrmMenu();
                    //this.Hide();
                    Limpar();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Erro ao Logar!", "Dados Incorretos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                txtSenha.Text = "";
            }

            Conexao.Close();
        }


        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }

    }




}

