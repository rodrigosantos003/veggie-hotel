using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeggieHotel
{
    public partial class MainScreen : Form
    {
        #region Variaveis
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath("@../..") + "\\BD_Hotel.mdf;Integrated Security=True";
        SqlConnection sqlcon;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dtbl;

        int ID = 0;
        #endregion

        public MainScreen()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "btn_Reservas":
                    Reservas();
                    break;

                case "btn_EntradaSaida":
                    Entradas_Saidas();
                    break;

                case "btn_Horarios":
                    Horarios();
                    break;

                case "btn_Contactos":
                    Contactos();
                    break;

                case "btn_Localizacao":
                    Localizacao();
                    break;
            }
        }

        private void ativarPanel(Panel x)
        {
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                if (panel.Tag == "tab")
                {
                    panel.Enabled = false;
                    panel.Visible = false;
                }
            }

            x.Enabled = true;
            x.Visible = true;
        }

        private void textBox_ChangeText(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            string defaultText = textbox.Tag.ToString();

            if (textbox.Text == defaultText)
                textbox.Text = "";
            else if (textbox.Text == "")
                textbox.Text = defaultText;
        }

        private void Reservas()
        {
            ativarPanel(panel_Reservas);

            criarData.MinDate = DateTime.Now;

            sqlcon = new SqlConnection(cs);
            sda = new SqlDataAdapter("SELECT * FROM tbl_Reservas", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Reservas.DataSource = dtbl;
        }

        private void btn_CriarReserva_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO [tbl_Reservas] ([Nome], [Telefone], [E-mail], [Data], [Descrição]) VALUES (@Nome, @Telefone, @Email, @Data, @Desc)", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@Nome", txt_criarNome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txt_criarTelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txt_criarEmail.Text);
            cmd.Parameters.AddWithValue("@Data", criarData.Text);
            cmd.Parameters.AddWithValue("@Desc", txt_criarDescricao.Text);
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Reserva criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reservas();

            txt_criarNome.Text = txt_criarNome.Tag.ToString();
            txt_criarTelefone.Text = txt_criarTelefone.Tag.ToString();
            txt_criarEmail.Text = txt_criarEmail.Tag.ToString();
            txt_criarDescricao.Text = txt_criarDescricao.Tag.ToString();
        }

        private void Entradas_Saidas()
        {
            ativarPanel(panel_Hospedes);

            criarData.MinDate = DateTime.Now;

            sqlcon = new SqlConnection(cs);
            sda = new SqlDataAdapter("SELECT * FROM tbl_Hospedes WHERE Status = '" + "Hospedado" + "'", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Hospedes.DataSource = dtbl;
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO [tbl_Hospedes] ([Nome], [Telefone], [E-mail], [Quarto], [Outros], [Status]) VALUES (@Nome, @Telefone, @Email, @Quarto, @Outros, @Status)", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@Nome", txt_entradaNome.Text);
            cmd.Parameters.AddWithValue("@Telefone", txt_entradaTelefone.Text);
            cmd.Parameters.AddWithValue("@Email", txt_entradaEmail.Text);
            cmd.Parameters.AddWithValue("@Quarto", combo_Quarto.Text);
            cmd.Parameters.AddWithValue("@Outros", txt_entradaOutros.Text);
            cmd.Parameters.AddWithValue("@Status", "Hospedado");
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Check-In efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Entradas_Saidas();

            txt_entradaNome.Text = txt_entradaNome.Tag.ToString();
            txt_entradaTelefone.Text = txt_entradaTelefone.Tag.ToString();
            txt_entradaEmail.Text = txt_entradaEmail.Tag.ToString();
            txt_entradaOutros.Text = txt_entradaOutros.Tag.ToString();
            combo_Quarto.Text = combo_Quarto.Tag.ToString();
        }

        private void txt_pesquisarHospede_TextChanged(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            sqlcon.Open();
            sda = new SqlDataAdapter("SELECT * FROM tbl_Hospedes WHERE Status = '" + "Hospedado" + "'AND Nome LIKE '" + txt_pesquisarHospede.Text + "%'", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Hospedes.DataSource = dtbl;
            sqlcon.Close();
        }

        private void dgv_Hospedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgv_Hospedes.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("UPDATE [tbl_Hospedes] SET Status=@Status WHERE Id=@Id", sqlcon);
            sqlcon.Open();
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Status", "Checked-Out");
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Check-Out efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Entradas_Saidas();

            txt_pesquisarHospede.Text = txt_pesquisarHospede.Tag.ToString();
        }

        private void Horarios()
        {
            ativarPanel(panel_Horarios);

            panel_Horarios.BackgroundImage = Properties.Resources.horario;
            panel_Horarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Contactos()
        {
            ativarPanel(panel_Contactos);
        }

        private void linkLbl_Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:veggiehotelisboa@gmail.com");
        }

        private void Localizacao()
        {
            ativarPanel(panel_Localizacao);
        }

        private void pb_Map_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/maps/12mcWFEBo8tK9obu6");
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            new Stats().ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLbl_Site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://brunaquintinoepm.wixsite.com/veggiehotel");
        }

        private void linkLbl_Instagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://instagram.com/veggiehotel");
        }
    }
}