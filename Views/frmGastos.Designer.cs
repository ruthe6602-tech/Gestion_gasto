 using System;
namespace gastos.Views
{
    partial class frmGastos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.NumericUpDown();
            this.datefecha = new System.Windows.Forms.DateTimePicker();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxmetodopago = new System.Windows.Forms.ComboBox();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxcategoria1 = new System.Windows.Forms.ComboBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvtablagastos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EstadoSistema = new System.Windows.Forms.StatusStrip();
            this.lblEstatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablagastos)).BeginInit();
            this.EstadoSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR GASTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(40, 280);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmonto.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(300, 26);
            this.txtmonto.TabIndex = 6;
            // 
            // datefecha
            // 
            this.datefecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefecha.Location = new System.Drawing.Point(40, 346);
            this.datefecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datefecha.MinDate = new System.DateTime(2026, 9, 28, 0, 0, 0, 0);
            this.datefecha.Name = "datefecha";
            this.datefecha.Size = new System.Drawing.Size(298, 26);
            this.datefecha.TabIndex = 7;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(40, 135);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(298, 26);
            this.txtdescripcion.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Método de pago";
            // 
            // cbxmetodopago
            // 
            this.cbxmetodopago.FormattingEnabled = true;
            this.cbxmetodopago.Location = new System.Drawing.Point(44, 449);
            this.cbxmetodopago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxmetodopago.Name = "cbxmetodopago";
            this.cbxmetodopago.Size = new System.Drawing.Size(295, 28);
            this.cbxmetodopago.TabIndex = 12;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(40, 203);
            this.cbxcategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(298, 28);
            this.cbxcategoria.TabIndex = 13;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguardar.Location = new System.Drawing.Point(40, 514);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(146, 68);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlimpiar.Location = new System.Drawing.Point(195, 514);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(130, 68);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxcategoria1);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.dgvtablagastos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(494, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 668);
            this.panel1.TabIndex = 16;
            // 
            // cbxcategoria1
            // 
            this.cbxcategoria1.FormattingEnabled = true;
            this.cbxcategoria1.Location = new System.Drawing.Point(466, 58);
            this.cbxcategoria1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxcategoria1.Name = "cbxcategoria1";
            this.cbxcategoria1.Size = new System.Drawing.Size(180, 28);
            this.cbxcategoria1.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(102, 602);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(21, 20);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "...";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btneliminar.Location = new System.Drawing.Point(405, 549);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(144, 52);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btneditar.Location = new System.Drawing.Point(189, 549);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(159, 52);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(135, 62);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(202, 26);
            this.txtbuscar.TabIndex = 5;
            // 
            // dgvtablagastos
            // 
            this.dgvtablagastos.AllowUserToAddRows = false;
            this.dgvtablagastos.AllowUserToDeleteRows = false;
            this.dgvtablagastos.AllowUserToResizeRows = false;
            this.dgvtablagastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtablagastos.Location = new System.Drawing.Point(44, 145);
            this.dgvtablagastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvtablagastos.Name = "dgvtablagastos";
            this.dgvtablagastos.RowHeadersWidth = 62;
            this.dgvtablagastos.Size = new System.Drawing.Size(676, 369);
            this.dgvtablagastos.TabIndex = 4;
            this.dgvtablagastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablagastos_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 602);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 39);
            this.label9.TabIndex = 2;
            this.label9.Text = "GASTOS REGISTRADOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar:";
            // 
            // EstadoSistema
            // 
            this.EstadoSistema.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.EstadoSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstatus});
            this.EstadoSistema.Location = new System.Drawing.Point(0, 774);
            this.EstadoSistema.Name = "EstadoSistema";
            this.EstadoSistema.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.EstadoSistema.Size = new System.Drawing.Size(1256, 32);
            this.EstadoSistema.TabIndex = 17;
            this.EstadoSistema.Text = "statusStrip1";
            // 
            // lblEstatus
            // 
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(36, 25);
            this.lblEstatus.Text = "......";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 806);
            this.Controls.Add(this.EstadoSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.cbxmetodopago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.datefecha);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGastos";
            this.Text = "GESTIONAR GASTOS";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmonto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablagastos)).EndInit();
            this.EstadoSistema.ResumeLayout(false);
            this.EstadoSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtmonto;
        private System.Windows.Forms.DateTimePicker datefecha;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxmetodopago;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvtablagastos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbxcategoria1;
        private System.Windows.Forms.StatusStrip EstadoSistema;
        private System.Windows.Forms.ToolStripStatusLabel lblEstatus;
    }
}