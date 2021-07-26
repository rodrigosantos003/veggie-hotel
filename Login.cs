using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace VeggieHotel
{
    public partial class Login : Form
    {
        #region Variavaies
        string cs;
        string cmd;
        SqlConnection sqlcon;
        SqlDataAdapter sda;
        DataTable dtbl;
        #endregion

        public Login()
        {
            InitializeComponent();
        }

        private void execLogin()
        {
            cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"../..") + "\\BD_Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            cmd = "SELECT * FROM tbl_Login WHERE [Nome de Utilizador] = '" + txt_User.Text.Trim() + "'AND [Password] = '" + txt_Pass.Text.Trim() + "'";

            sqlcon = new SqlConnection(cs);
            sda = new SqlDataAdapter(cmd, cs);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                new MainScreen().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Introduza as informações corretas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_User.Clear();
                txt_Pass.Clear();
                txt_User.Focus();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text != "" && txt_Pass.Text != "")
                execLogin();
            else
                MessageBox.Show("Preencha os campos necessários!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void chkbx_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Pass.UseSystemPasswordChar == true)
                txt_Pass.UseSystemPasswordChar = false;
            else
                txt_Pass.UseSystemPasswordChar = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
