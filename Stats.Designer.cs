
namespace VeggieHotel
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.lbl_totalCheckOuts = new System.Windows.Forms.Label();
            this.lbl_totalHospedes = new System.Windows.Forms.Label();
            this.lbl_totalReservas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_totalCheckOuts
            // 
            this.lbl_totalCheckOuts.AutoSize = true;
            this.lbl_totalCheckOuts.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCheckOuts.ForeColor = System.Drawing.Color.White;
            this.lbl_totalCheckOuts.Location = new System.Drawing.Point(11, 109);
            this.lbl_totalCheckOuts.Name = "lbl_totalCheckOuts";
            this.lbl_totalCheckOuts.Size = new System.Drawing.Size(264, 28);
            this.lbl_totalCheckOuts.TabIndex = 7;
            this.lbl_totalCheckOuts.Text = "Total de Check-Outs: ";
            // 
            // lbl_totalHospedes
            // 
            this.lbl_totalHospedes.AutoSize = true;
            this.lbl_totalHospedes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalHospedes.ForeColor = System.Drawing.Color.White;
            this.lbl_totalHospedes.Location = new System.Drawing.Point(11, 59);
            this.lbl_totalHospedes.Name = "lbl_totalHospedes";
            this.lbl_totalHospedes.Size = new System.Drawing.Size(240, 28);
            this.lbl_totalHospedes.TabIndex = 6;
            this.lbl_totalHospedes.Text = "Total de Hospedes: ";
            // 
            // lbl_totalReservas
            // 
            this.lbl_totalReservas.AutoSize = true;
            this.lbl_totalReservas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalReservas.ForeColor = System.Drawing.Color.White;
            this.lbl_totalReservas.Location = new System.Drawing.Point(11, 10);
            this.lbl_totalReservas.Name = "lbl_totalReservas";
            this.lbl_totalReservas.Size = new System.Drawing.Size(228, 28);
            this.lbl_totalReservas.TabIndex = 5;
            this.lbl_totalReservas.Text = "Total de Reservas: ";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(119)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(482, 151);
            this.Controls.Add(this.lbl_totalCheckOuts);
            this.Controls.Add(this.lbl_totalHospedes);
            this.Controls.Add(this.lbl_totalReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_totalCheckOuts;
        private System.Windows.Forms.Label lbl_totalHospedes;
        private System.Windows.Forms.Label lbl_totalReservas;
    }
}