
namespace VeggieHotel
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panel_Reservas = new System.Windows.Forms.Panel();
            this.btn_CriarReserva = new System.Windows.Forms.Button();
            this.criarData = new System.Windows.Forms.DateTimePicker();
            this.txt_criarDescricao = new System.Windows.Forms.TextBox();
            this.txt_criarEmail = new System.Windows.Forms.TextBox();
            this.txt_criarTelefone = new System.Windows.Forms.TextBox();
            this.txt_criarNome = new System.Windows.Forms.TextBox();
            this.lbl_CriarReserva = new System.Windows.Forms.Label();
            this.dgv_Reservas = new System.Windows.Forms.DataGridView();
            this.lbl_VerReservas = new System.Windows.Forms.Label();
            this.flp_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Reservas = new System.Windows.Forms.Button();
            this.btn_EntradaSaida = new System.Windows.Forms.Button();
            this.btn_Horarios = new System.Windows.Forms.Button();
            this.btn_Contactos = new System.Windows.Forms.Button();
            this.btn_Localizacao = new System.Windows.Forms.Button();
            this.panel_Hospedes = new System.Windows.Forms.Panel();
            this.lbl_Saida = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.txt_pesquisarHospede = new System.Windows.Forms.TextBox();
            this.combo_Quarto = new System.Windows.Forms.ComboBox();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.txt_entradaOutros = new System.Windows.Forms.TextBox();
            this.txt_entradaEmail = new System.Windows.Forms.TextBox();
            this.txt_entradaTelefone = new System.Windows.Forms.TextBox();
            this.txt_entradaNome = new System.Windows.Forms.TextBox();
            this.lbl_Entrada = new System.Windows.Forms.Label();
            this.dgv_Hospedes = new System.Windows.Forms.DataGridView();
            this.panel_Contactos = new System.Windows.Forms.Panel();
            this.linkLbl_Instagram = new System.Windows.Forms.LinkLabel();
            this.linkLbl_Site = new System.Windows.Forms.LinkLabel();
            this.linkLbl_Email = new System.Windows.Forms.LinkLabel();
            this.lbl_Contactos = new System.Windows.Forms.Label();
            this.panel_Localizacao = new System.Windows.Forms.Panel();
            this.pb_Map = new System.Windows.Forms.PictureBox();
            this.lbl_Coordenadas = new System.Windows.Forms.Label();
            this.lbl_Morada = new System.Windows.Forms.Label();
            this.lbl_Localizacao = new System.Windows.Forms.Label();
            this.panel_Horarios = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Stats = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_Reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).BeginInit();
            this.flp_Menu.SuspendLayout();
            this.panel_Hospedes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospedes)).BeginInit();
            this.panel_Contactos.SuspendLayout();
            this.panel_Localizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Reservas
            // 
            this.panel_Reservas.Controls.Add(this.btn_CriarReserva);
            this.panel_Reservas.Controls.Add(this.criarData);
            this.panel_Reservas.Controls.Add(this.txt_criarDescricao);
            this.panel_Reservas.Controls.Add(this.txt_criarEmail);
            this.panel_Reservas.Controls.Add(this.txt_criarTelefone);
            this.panel_Reservas.Controls.Add(this.txt_criarNome);
            this.panel_Reservas.Controls.Add(this.lbl_CriarReserva);
            this.panel_Reservas.Controls.Add(this.dgv_Reservas);
            this.panel_Reservas.Controls.Add(this.lbl_VerReservas);
            this.panel_Reservas.Enabled = false;
            this.panel_Reservas.Location = new System.Drawing.Point(0, 100);
            this.panel_Reservas.Name = "panel_Reservas";
            this.panel_Reservas.Size = new System.Drawing.Size(1000, 900);
            this.panel_Reservas.TabIndex = 1;
            this.panel_Reservas.Tag = "tab";
            this.panel_Reservas.Visible = false;
            // 
            // btn_CriarReserva
            // 
            this.btn_CriarReserva.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_CriarReserva.FlatAppearance.BorderSize = 3;
            this.btn_CriarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CriarReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarReserva.ForeColor = System.Drawing.Color.Beige;
            this.btn_CriarReserva.Location = new System.Drawing.Point(428, 311);
            this.btn_CriarReserva.Name = "btn_CriarReserva";
            this.btn_CriarReserva.Size = new System.Drawing.Size(145, 63);
            this.btn_CriarReserva.TabIndex = 15;
            this.btn_CriarReserva.Text = "Criar";
            this.btn_CriarReserva.UseVisualStyleBackColor = true;
            this.btn_CriarReserva.Click += new System.EventHandler(this.btn_CriarReserva_Click);
            // 
            // criarData
            // 
            this.criarData.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.criarData.Location = new System.Drawing.Point(159, 160);
            this.criarData.MinDate = new System.DateTime(2021, 1, 25, 0, 0, 0, 0);
            this.criarData.Name = "criarData";
            this.criarData.Size = new System.Drawing.Size(200, 22);
            this.criarData.TabIndex = 14;
            // 
            // txt_criarDescricao
            // 
            this.txt_criarDescricao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criarDescricao.Location = new System.Drawing.Point(412, 148);
            this.txt_criarDescricao.Multiline = true;
            this.txt_criarDescricao.Name = "txt_criarDescricao";
            this.txt_criarDescricao.Size = new System.Drawing.Size(453, 102);
            this.txt_criarDescricao.TabIndex = 13;
            this.txt_criarDescricao.Tag = "Descrição";
            this.txt_criarDescricao.Text = "Descrição";
            this.txt_criarDescricao.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_criarDescricao.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_criarEmail
            // 
            this.txt_criarEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criarEmail.Location = new System.Drawing.Point(665, 86);
            this.txt_criarEmail.Name = "txt_criarEmail";
            this.txt_criarEmail.Size = new System.Drawing.Size(200, 28);
            this.txt_criarEmail.TabIndex = 12;
            this.txt_criarEmail.Tag = "E-mail";
            this.txt_criarEmail.Text = "E-mail";
            this.txt_criarEmail.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_criarEmail.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_criarTelefone
            // 
            this.txt_criarTelefone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criarTelefone.Location = new System.Drawing.Point(412, 86);
            this.txt_criarTelefone.Name = "txt_criarTelefone";
            this.txt_criarTelefone.Size = new System.Drawing.Size(200, 28);
            this.txt_criarTelefone.TabIndex = 11;
            this.txt_criarTelefone.Tag = "Telefone";
            this.txt_criarTelefone.Text = "Telefone";
            this.txt_criarTelefone.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_criarTelefone.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_criarNome
            // 
            this.txt_criarNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_criarNome.Location = new System.Drawing.Point(159, 86);
            this.txt_criarNome.Name = "txt_criarNome";
            this.txt_criarNome.Size = new System.Drawing.Size(200, 28);
            this.txt_criarNome.TabIndex = 10;
            this.txt_criarNome.Tag = "Nome";
            this.txt_criarNome.Text = "Nome";
            this.txt_criarNome.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_criarNome.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // lbl_CriarReserva
            // 
            this.lbl_CriarReserva.AutoSize = true;
            this.lbl_CriarReserva.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarReserva.ForeColor = System.Drawing.Color.White;
            this.lbl_CriarReserva.Location = new System.Drawing.Point(407, 33);
            this.lbl_CriarReserva.Name = "lbl_CriarReserva";
            this.lbl_CriarReserva.Size = new System.Drawing.Size(186, 28);
            this.lbl_CriarReserva.TabIndex = 9;
            this.lbl_CriarReserva.Text = "Criar Reservas:";
            // 
            // dgv_Reservas
            // 
            this.dgv_Reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Reservas.Location = new System.Drawing.Point(0, 527);
            this.dgv_Reservas.Name = "dgv_Reservas";
            this.dgv_Reservas.RowHeadersWidth = 51;
            this.dgv_Reservas.RowTemplate.Height = 24;
            this.dgv_Reservas.Size = new System.Drawing.Size(1000, 373);
            this.dgv_Reservas.TabIndex = 1;
            // 
            // lbl_VerReservas
            // 
            this.lbl_VerReservas.AutoSize = true;
            this.lbl_VerReservas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VerReservas.ForeColor = System.Drawing.Color.White;
            this.lbl_VerReservas.Location = new System.Drawing.Point(381, 487);
            this.lbl_VerReservas.Name = "lbl_VerReservas";
            this.lbl_VerReservas.Size = new System.Drawing.Size(239, 28);
            this.lbl_VerReservas.TabIndex = 0;
            this.lbl_VerReservas.Text = "Consultar Reservas:";
            // 
            // flp_Menu
            // 
            this.flp_Menu.Controls.Add(this.btn_Reservas);
            this.flp_Menu.Controls.Add(this.btn_EntradaSaida);
            this.flp_Menu.Controls.Add(this.btn_Horarios);
            this.flp_Menu.Controls.Add(this.btn_Contactos);
            this.flp_Menu.Controls.Add(this.btn_Localizacao);
            this.flp_Menu.Location = new System.Drawing.Point(0, 0);
            this.flp_Menu.Name = "flp_Menu";
            this.flp_Menu.Size = new System.Drawing.Size(933, 100);
            this.flp_Menu.TabIndex = 2;
            // 
            // btn_Reservas
            // 
            this.btn_Reservas.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Reservas.FlatAppearance.BorderSize = 2;
            this.btn_Reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reservas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reservas.ForeColor = System.Drawing.Color.Beige;
            this.btn_Reservas.Location = new System.Drawing.Point(3, 3);
            this.btn_Reservas.Name = "btn_Reservas";
            this.btn_Reservas.Size = new System.Drawing.Size(180, 88);
            this.btn_Reservas.TabIndex = 0;
            this.btn_Reservas.Text = "Reservas";
            this.btn_Reservas.UseVisualStyleBackColor = true;
            this.btn_Reservas.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_EntradaSaida
            // 
            this.btn_EntradaSaida.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_EntradaSaida.FlatAppearance.BorderSize = 2;
            this.btn_EntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EntradaSaida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EntradaSaida.ForeColor = System.Drawing.Color.Beige;
            this.btn_EntradaSaida.Location = new System.Drawing.Point(189, 3);
            this.btn_EntradaSaida.Name = "btn_EntradaSaida";
            this.btn_EntradaSaida.Size = new System.Drawing.Size(180, 88);
            this.btn_EntradaSaida.TabIndex = 1;
            this.btn_EntradaSaida.Text = "Entrada/Saída Hóspedes";
            this.btn_EntradaSaida.UseVisualStyleBackColor = true;
            this.btn_EntradaSaida.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Horarios
            // 
            this.btn_Horarios.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Horarios.FlatAppearance.BorderSize = 2;
            this.btn_Horarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Horarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Horarios.ForeColor = System.Drawing.Color.Beige;
            this.btn_Horarios.Location = new System.Drawing.Point(375, 3);
            this.btn_Horarios.Name = "btn_Horarios";
            this.btn_Horarios.Size = new System.Drawing.Size(180, 88);
            this.btn_Horarios.TabIndex = 2;
            this.btn_Horarios.Text = "Horários";
            this.btn_Horarios.UseVisualStyleBackColor = true;
            this.btn_Horarios.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Contactos
            // 
            this.btn_Contactos.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Contactos.FlatAppearance.BorderSize = 2;
            this.btn_Contactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contactos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contactos.ForeColor = System.Drawing.Color.Beige;
            this.btn_Contactos.Location = new System.Drawing.Point(561, 3);
            this.btn_Contactos.Name = "btn_Contactos";
            this.btn_Contactos.Size = new System.Drawing.Size(180, 88);
            this.btn_Contactos.TabIndex = 3;
            this.btn_Contactos.Text = "Contactos";
            this.btn_Contactos.UseVisualStyleBackColor = true;
            this.btn_Contactos.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_Localizacao
            // 
            this.btn_Localizacao.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Localizacao.FlatAppearance.BorderSize = 2;
            this.btn_Localizacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Localizacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Localizacao.ForeColor = System.Drawing.Color.Beige;
            this.btn_Localizacao.Location = new System.Drawing.Point(747, 3);
            this.btn_Localizacao.Name = "btn_Localizacao";
            this.btn_Localizacao.Size = new System.Drawing.Size(180, 88);
            this.btn_Localizacao.TabIndex = 4;
            this.btn_Localizacao.Text = "Localização";
            this.btn_Localizacao.UseVisualStyleBackColor = true;
            this.btn_Localizacao.Click += new System.EventHandler(this.button_Click);
            // 
            // panel_Hospedes
            // 
            this.panel_Hospedes.Controls.Add(this.lbl_Saida);
            this.panel_Hospedes.Controls.Add(this.btn_CheckOut);
            this.panel_Hospedes.Controls.Add(this.txt_pesquisarHospede);
            this.panel_Hospedes.Controls.Add(this.combo_Quarto);
            this.panel_Hospedes.Controls.Add(this.btn_CheckIn);
            this.panel_Hospedes.Controls.Add(this.txt_entradaOutros);
            this.panel_Hospedes.Controls.Add(this.txt_entradaEmail);
            this.panel_Hospedes.Controls.Add(this.txt_entradaTelefone);
            this.panel_Hospedes.Controls.Add(this.txt_entradaNome);
            this.panel_Hospedes.Controls.Add(this.lbl_Entrada);
            this.panel_Hospedes.Controls.Add(this.dgv_Hospedes);
            this.panel_Hospedes.Enabled = false;
            this.panel_Hospedes.Location = new System.Drawing.Point(0, 100);
            this.panel_Hospedes.Name = "panel_Hospedes";
            this.panel_Hospedes.Size = new System.Drawing.Size(1000, 900);
            this.panel_Hospedes.TabIndex = 16;
            this.panel_Hospedes.Tag = "tab";
            this.panel_Hospedes.Visible = false;
            // 
            // lbl_Saida
            // 
            this.lbl_Saida.AutoSize = true;
            this.lbl_Saida.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saida.ForeColor = System.Drawing.Color.White;
            this.lbl_Saida.Location = new System.Drawing.Point(375, 466);
            this.lbl_Saida.Name = "lbl_Saida";
            this.lbl_Saida.Size = new System.Drawing.Size(245, 28);
            this.lbl_Saida.TabIndex = 0;
            this.lbl_Saida.Text = "Saída de Hospedes:";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_CheckOut.FlatAppearance.BorderSize = 3;
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.ForeColor = System.Drawing.Color.Beige;
            this.btn_CheckOut.Location = new System.Drawing.Point(611, 518);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(145, 43);
            this.btn_CheckOut.TabIndex = 18;
            this.btn_CheckOut.Text = "Check-Out";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // txt_pesquisarHospede
            // 
            this.txt_pesquisarHospede.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisarHospede.Location = new System.Drawing.Point(225, 527);
            this.txt_pesquisarHospede.Name = "txt_pesquisarHospede";
            this.txt_pesquisarHospede.Size = new System.Drawing.Size(339, 28);
            this.txt_pesquisarHospede.TabIndex = 17;
            this.txt_pesquisarHospede.Tag = "Pesquisar Hóspede";
            this.txt_pesquisarHospede.Text = "Pesquisar Hóspede";
            this.txt_pesquisarHospede.TextChanged += new System.EventHandler(this.txt_pesquisarHospede_TextChanged);
            this.txt_pesquisarHospede.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_pesquisarHospede.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // combo_Quarto
            // 
            this.combo_Quarto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Quarto.FormattingEnabled = true;
            this.combo_Quarto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combo_Quarto.Location = new System.Drawing.Point(146, 166);
            this.combo_Quarto.Name = "combo_Quarto";
            this.combo_Quarto.Size = new System.Drawing.Size(200, 29);
            this.combo_Quarto.TabIndex = 16;
            this.combo_Quarto.Tag = "Quarto";
            this.combo_Quarto.Text = "Quarto";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_CheckIn.FlatAppearance.BorderSize = 3;
            this.btn_CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.ForeColor = System.Drawing.Color.Beige;
            this.btn_CheckIn.Location = new System.Drawing.Point(425, 311);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(145, 63);
            this.btn_CheckIn.TabIndex = 15;
            this.btn_CheckIn.Text = "Check-In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // txt_entradaOutros
            // 
            this.txt_entradaOutros.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entradaOutros.Location = new System.Drawing.Point(399, 162);
            this.txt_entradaOutros.Multiline = true;
            this.txt_entradaOutros.Name = "txt_entradaOutros";
            this.txt_entradaOutros.Size = new System.Drawing.Size(453, 102);
            this.txt_entradaOutros.TabIndex = 13;
            this.txt_entradaOutros.Tag = "Outros";
            this.txt_entradaOutros.Text = "Outros";
            this.txt_entradaOutros.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_entradaOutros.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_entradaEmail
            // 
            this.txt_entradaEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entradaEmail.Location = new System.Drawing.Point(652, 100);
            this.txt_entradaEmail.Name = "txt_entradaEmail";
            this.txt_entradaEmail.Size = new System.Drawing.Size(200, 28);
            this.txt_entradaEmail.TabIndex = 12;
            this.txt_entradaEmail.Tag = "E-mail";
            this.txt_entradaEmail.Text = "E-mail";
            this.txt_entradaEmail.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_entradaEmail.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_entradaTelefone
            // 
            this.txt_entradaTelefone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entradaTelefone.Location = new System.Drawing.Point(399, 100);
            this.txt_entradaTelefone.Name = "txt_entradaTelefone";
            this.txt_entradaTelefone.Size = new System.Drawing.Size(200, 28);
            this.txt_entradaTelefone.TabIndex = 11;
            this.txt_entradaTelefone.Tag = "Telefone";
            this.txt_entradaTelefone.Text = "Telefone";
            this.txt_entradaTelefone.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_entradaTelefone.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // txt_entradaNome
            // 
            this.txt_entradaNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entradaNome.Location = new System.Drawing.Point(146, 100);
            this.txt_entradaNome.Name = "txt_entradaNome";
            this.txt_entradaNome.Size = new System.Drawing.Size(200, 28);
            this.txt_entradaNome.TabIndex = 10;
            this.txt_entradaNome.Tag = "Nome";
            this.txt_entradaNome.Text = "Nome";
            this.txt_entradaNome.Enter += new System.EventHandler(this.textBox_ChangeText);
            this.txt_entradaNome.Leave += new System.EventHandler(this.textBox_ChangeText);
            // 
            // lbl_Entrada
            // 
            this.lbl_Entrada.AutoSize = true;
            this.lbl_Entrada.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Entrada.ForeColor = System.Drawing.Color.White;
            this.lbl_Entrada.Location = new System.Drawing.Point(363, 33);
            this.lbl_Entrada.Name = "lbl_Entrada";
            this.lbl_Entrada.Size = new System.Drawing.Size(268, 28);
            this.lbl_Entrada.TabIndex = 9;
            this.lbl_Entrada.Text = "Entrada de Hospedes:";
            // 
            // dgv_Hospedes
            // 
            this.dgv_Hospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hospedes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Hospedes.Location = new System.Drawing.Point(0, 588);
            this.dgv_Hospedes.Name = "dgv_Hospedes";
            this.dgv_Hospedes.RowHeadersWidth = 51;
            this.dgv_Hospedes.RowTemplate.Height = 24;
            this.dgv_Hospedes.Size = new System.Drawing.Size(1000, 312);
            this.dgv_Hospedes.TabIndex = 1;
            this.dgv_Hospedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hospedes_CellClick);
            // 
            // panel_Contactos
            // 
            this.panel_Contactos.Controls.Add(this.linkLbl_Instagram);
            this.panel_Contactos.Controls.Add(this.linkLbl_Site);
            this.panel_Contactos.Controls.Add(this.linkLbl_Email);
            this.panel_Contactos.Controls.Add(this.lbl_Contactos);
            this.panel_Contactos.Enabled = false;
            this.panel_Contactos.ForeColor = System.Drawing.Color.White;
            this.panel_Contactos.Location = new System.Drawing.Point(0, 103);
            this.panel_Contactos.Name = "panel_Contactos";
            this.panel_Contactos.Size = new System.Drawing.Size(1000, 897);
            this.panel_Contactos.TabIndex = 17;
            this.panel_Contactos.Tag = "tab";
            this.panel_Contactos.Visible = false;
            // 
            // linkLbl_Instagram
            // 
            this.linkLbl_Instagram.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLbl_Instagram.AutoSize = true;
            this.linkLbl_Instagram.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Instagram.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_Instagram.ForeColor = System.Drawing.Color.White;
            this.linkLbl_Instagram.LinkColor = System.Drawing.Color.White;
            this.linkLbl_Instagram.Location = new System.Drawing.Point(345, 490);
            this.linkLbl_Instagram.Name = "linkLbl_Instagram";
            this.linkLbl_Instagram.Size = new System.Drawing.Size(311, 23);
            this.linkLbl_Instagram.TabIndex = 4;
            this.linkLbl_Instagram.TabStop = true;
            this.linkLbl_Instagram.Text = "📷 instagram.com/veggiehotel";
            this.linkLbl_Instagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_Instagram_LinkClicked);
            // 
            // linkLbl_Site
            // 
            this.linkLbl_Site.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLbl_Site.AutoSize = true;
            this.linkLbl_Site.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Site.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_Site.ForeColor = System.Drawing.Color.White;
            this.linkLbl_Site.LinkColor = System.Drawing.Color.White;
            this.linkLbl_Site.Location = new System.Drawing.Point(270, 182);
            this.linkLbl_Site.Name = "linkLbl_Site";
            this.linkLbl_Site.Size = new System.Drawing.Size(461, 23);
            this.linkLbl_Site.TabIndex = 3;
            this.linkLbl_Site.TabStop = true;
            this.linkLbl_Site.Text = "🌐 brunaquintinoepm.wixsite.com/veggiehotel";
            this.linkLbl_Site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_Site_LinkClicked);
            // 
            // linkLbl_Email
            // 
            this.linkLbl_Email.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLbl_Email.AutoSize = true;
            this.linkLbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_Email.ForeColor = System.Drawing.Color.White;
            this.linkLbl_Email.LinkColor = System.Drawing.Color.White;
            this.linkLbl_Email.Location = new System.Drawing.Point(336, 336);
            this.linkLbl_Email.Name = "linkLbl_Email";
            this.linkLbl_Email.Size = new System.Drawing.Size(329, 23);
            this.linkLbl_Email.TabIndex = 2;
            this.linkLbl_Email.TabStop = true;
            this.linkLbl_Email.Text = "📧 veggiehotelisboa@gmail.com";
            this.linkLbl_Email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_Email_LinkClicked);
            // 
            // lbl_Contactos
            // 
            this.lbl_Contactos.AutoSize = true;
            this.lbl_Contactos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contactos.ForeColor = System.Drawing.Color.White;
            this.lbl_Contactos.Location = new System.Drawing.Point(435, 33);
            this.lbl_Contactos.Name = "lbl_Contactos";
            this.lbl_Contactos.Size = new System.Drawing.Size(131, 28);
            this.lbl_Contactos.TabIndex = 0;
            this.lbl_Contactos.Text = "Contactos";
            // 
            // panel_Localizacao
            // 
            this.panel_Localizacao.Controls.Add(this.pb_Map);
            this.panel_Localizacao.Controls.Add(this.lbl_Coordenadas);
            this.panel_Localizacao.Controls.Add(this.lbl_Morada);
            this.panel_Localizacao.Controls.Add(this.lbl_Localizacao);
            this.panel_Localizacao.Enabled = false;
            this.panel_Localizacao.ForeColor = System.Drawing.Color.White;
            this.panel_Localizacao.Location = new System.Drawing.Point(3, 103);
            this.panel_Localizacao.Name = "panel_Localizacao";
            this.panel_Localizacao.Size = new System.Drawing.Size(997, 897);
            this.panel_Localizacao.TabIndex = 18;
            this.panel_Localizacao.Tag = "tab";
            this.panel_Localizacao.Visible = false;
            // 
            // pb_Map
            // 
            this.pb_Map.Image = global::VeggieHotel.Properties.Resources.map;
            this.pb_Map.Location = new System.Drawing.Point(100, 282);
            this.pb_Map.Name = "pb_Map";
            this.pb_Map.Size = new System.Drawing.Size(796, 515);
            this.pb_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Map.TabIndex = 3;
            this.pb_Map.TabStop = false;
            this.pb_Map.Click += new System.EventHandler(this.pb_Map_Click);
            // 
            // lbl_Coordenadas
            // 
            this.lbl_Coordenadas.AutoSize = true;
            this.lbl_Coordenadas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Coordenadas.Location = new System.Drawing.Point(281, 224);
            this.lbl_Coordenadas.Name = "lbl_Coordenadas";
            this.lbl_Coordenadas.Size = new System.Drawing.Size(434, 23);
            this.lbl_Coordenadas.TabIndex = 2;
            this.lbl_Coordenadas.Text = "38.7670974,-9.1044878,3a,75y,271.62h,93.21t";
            // 
            // lbl_Morada
            // 
            this.lbl_Morada.AutoSize = true;
            this.lbl_Morada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Morada.Location = new System.Drawing.Point(389, 133);
            this.lbl_Morada.Name = "lbl_Morada";
            this.lbl_Morada.Size = new System.Drawing.Size(236, 23);
            this.lbl_Morada.TabIndex = 1;
            this.lbl_Morada.Text = "Av. Infante D. Henrique";
            // 
            // lbl_Localizacao
            // 
            this.lbl_Localizacao.AutoSize = true;
            this.lbl_Localizacao.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Localizacao.ForeColor = System.Drawing.Color.White;
            this.lbl_Localizacao.Location = new System.Drawing.Point(421, 33);
            this.lbl_Localizacao.Name = "lbl_Localizacao";
            this.lbl_Localizacao.Size = new System.Drawing.Size(154, 28);
            this.lbl_Localizacao.TabIndex = 0;
            this.lbl_Localizacao.Text = "Localização";
            // 
            // panel_Horarios
            // 
            this.panel_Horarios.Enabled = false;
            this.panel_Horarios.Location = new System.Drawing.Point(3, 103);
            this.panel_Horarios.Name = "panel_Horarios";
            this.panel_Horarios.Size = new System.Drawing.Size(997, 897);
            this.panel_Horarios.TabIndex = 18;
            this.panel_Horarios.Tag = "tab";
            this.panel_Horarios.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(167, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(407, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "📧 epmbruna.quintino@epmontijo.edu.pt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "📞 (+351) 967 502 737";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contactos";
            // 
            // btn_Stats
            // 
            this.btn_Stats.BackgroundImage = global::VeggieHotel.Properties.Resources.dollar_stats_icon;
            this.btn_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stats.FlatAppearance.BorderSize = 0;
            this.btn_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stats.Location = new System.Drawing.Point(939, 5);
            this.btn_Stats.Name = "btn_Stats";
            this.btn_Stats.Size = new System.Drawing.Size(55, 40);
            this.btn_Stats.TabIndex = 19;
            this.btn_Stats.UseVisualStyleBackColor = true;
            this.btn_Stats.Click += new System.EventHandler(this.btn_Stats_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::VeggieHotel.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(939, 51);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(55, 40);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btn_Stats);
            this.Controls.Add(this.flp_Menu);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel_Contactos);
            this.Controls.Add(this.panel_Hospedes);
            this.Controls.Add(this.panel_Reservas);
            this.Controls.Add(this.panel_Horarios);
            this.Controls.Add(this.panel_Localizacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veggie Hotel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.panel_Reservas.ResumeLayout(false);
            this.panel_Reservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservas)).EndInit();
            this.flp_Menu.ResumeLayout(false);
            this.panel_Hospedes.ResumeLayout(false);
            this.panel_Hospedes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hospedes)).EndInit();
            this.panel_Contactos.ResumeLayout(false);
            this.panel_Contactos.PerformLayout();
            this.panel_Localizacao.ResumeLayout(false);
            this.panel_Localizacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Reservas;
        private System.Windows.Forms.FlowLayoutPanel flp_Menu;
        private System.Windows.Forms.Label lbl_CriarReserva;
        private System.Windows.Forms.TextBox txt_criarNome;
        private System.Windows.Forms.TextBox txt_criarTelefone;
        private System.Windows.Forms.TextBox txt_criarEmail;
        private System.Windows.Forms.DateTimePicker criarData;
        private System.Windows.Forms.TextBox txt_criarDescricao;
        private System.Windows.Forms.Button btn_CriarReserva;
        private System.Windows.Forms.Label lbl_VerReservas;
        private System.Windows.Forms.DataGridView dgv_Reservas;
        private System.Windows.Forms.Panel panel_Hospedes;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.TextBox txt_entradaOutros;
        private System.Windows.Forms.TextBox txt_entradaEmail;
        private System.Windows.Forms.TextBox txt_entradaTelefone;
        private System.Windows.Forms.TextBox txt_entradaNome;
        private System.Windows.Forms.Label lbl_Entrada;
        private System.Windows.Forms.DataGridView dgv_Hospedes;
        private System.Windows.Forms.Label lbl_Saida;
        private System.Windows.Forms.ComboBox combo_Quarto;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.TextBox txt_pesquisarHospede;
        private System.Windows.Forms.Panel panel_Contactos;
        private System.Windows.Forms.Label lbl_Contactos;
        private System.Windows.Forms.LinkLabel linkLbl_Email;
        private System.Windows.Forms.Panel panel_Horarios;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reservas;
        private System.Windows.Forms.Button btn_EntradaSaida;
        private System.Windows.Forms.Button btn_Horarios;
        private System.Windows.Forms.Button btn_Contactos;
        private System.Windows.Forms.Button btn_Localizacao;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Stats;
        private System.Windows.Forms.Panel panel_Localizacao;
        private System.Windows.Forms.Label lbl_Localizacao;
        private System.Windows.Forms.PictureBox pb_Map;
        private System.Windows.Forms.Label lbl_Coordenadas;
        private System.Windows.Forms.Label lbl_Morada;
        private System.Windows.Forms.LinkLabel linkLbl_Instagram;
        private System.Windows.Forms.LinkLabel linkLbl_Site;
    }
}