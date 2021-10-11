﻿
namespace SistemaHotel.Reservas
{
    partial class FrmConsultarReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarReservas));
            this.btnRel = new System.Windows.Forms.Button();
            this.dtBuscarReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.dtBuscarInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRel
            // 
            this.btnRel.BackColor = System.Drawing.Color.Transparent;
            this.btnRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRel.BackgroundImage")));
            this.btnRel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRel.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRel.Location = new System.Drawing.Point(1189, 36);
            this.btnRel.Name = "btnRel";
            this.btnRel.Size = new System.Drawing.Size(25, 25);
            this.btnRel.TabIndex = 144;
            this.btnRel.UseVisualStyleBackColor = false;
            // 
            // dtBuscarReserva
            // 
            this.dtBuscarReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscarReserva.Location = new System.Drawing.Point(819, 29);
            this.dtBuscarReserva.Name = "dtBuscarReserva";
            this.dtBuscarReserva.Size = new System.Drawing.Size(93, 20);
            this.dtBuscarReserva.TabIndex = 143;
            this.dtBuscarReserva.Value = new System.DateTime(2021, 10, 5, 13, 44, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Data Reserva:";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(264, 28);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(111, 20);
            this.txtBuscarNome.TabIndex = 141;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Confirmada",
            "Cancelada"});
            this.cbStatus.Location = new System.Drawing.Point(80, 29);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(104, 21);
            this.cbStatus.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Nome:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(1160, 36);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 25);
            this.btnRemove.TabIndex = 137;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.Transparent;
            this.btnPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPago.BackgroundImage")));
            this.btnPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Location = new System.Drawing.Point(1131, 36);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(25, 25);
            this.btnPago.TabIndex = 136;
            this.btnPago.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.SystemColors.Control;
            this.grid.Location = new System.Drawing.Point(27, 65);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1187, 328);
            this.grid.TabIndex = 135;
            // 
            // dtBuscarInicioReserva
            // 
            this.dtBuscarInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscarInicioReserva.Location = new System.Drawing.Point(595, 29);
            this.dtBuscarInicioReserva.Name = "dtBuscarInicioReserva";
            this.dtBuscarInicioReserva.Size = new System.Drawing.Size(93, 20);
            this.dtBuscarInicioReserva.TabIndex = 134;
            this.dtBuscarInicioReserva.Value = new System.DateTime(2021, 10, 5, 13, 44, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Data Inicio Reserva:";
            // 
            // FrmConsultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 420);
            this.Controls.Add(this.btnRel);
            this.Controls.Add(this.dtBuscarReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarNome);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.dtBuscarInicioReserva);
            this.Controls.Add(this.label3);
            this.Name = "FrmConsultarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRel;
        private System.Windows.Forms.DateTimePicker dtBuscarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DateTimePicker dtBuscarInicioReserva;
        private System.Windows.Forms.Label label3;
    }
}