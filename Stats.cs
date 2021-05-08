using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace VeggieHotel
{
    public partial class Stats : Form
    {
        #region Variaveis
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "BD_Hotel.mdf;Integrated Security=True";
        SqlConnection sqlcon;
        SqlCommand cmd;
        #endregion
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT COUNT (*) FROM tbl_Reservas", sqlcon);
            sqlcon.Open();
            lbl_totalReservas.Text += cmd.ExecuteScalar();
            sqlcon.Close();

            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT COUNT (*) FROM tbl_Hospedes WHERE Status = '" + "Hospedado" + "'", sqlcon);
            sqlcon.Open();
            lbl_totalHospedes.Text += cmd.ExecuteScalar();
            sqlcon.Close();

            sqlcon = new SqlConnection(cs);
            cmd = new SqlCommand("SELECT COUNT (*) FROM tbl_Hospedes WHERE Status = '" + "Checked-Out" + "'", sqlcon);
            sqlcon.Open();
            lbl_totalCheckOuts.Text += cmd.ExecuteScalar();
            sqlcon.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
