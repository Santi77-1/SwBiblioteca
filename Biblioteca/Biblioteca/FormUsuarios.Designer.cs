namespace Biblioteca
{
    partial class FormUsuarios
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
            panel1 = new Panel();
            LblGl = new Label();
            panel2 = new Panel();
            BtnBuscar = new Button();
            TxtBusqueda = new TextBox();
            LblBusqueda = new Label();
            panel3 = new Panel();
            DGUsuarios = new DataGridView();
            BtnBotones = new Panel();
            BtnCancelar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            panel4 = new Panel();
            TXId = new TextBox();
            TXCorreo = new TextBox();
            TXTelefono = new TextBox();
            TXDocumento = new TextBox();
            TXApellido = new TextBox();
            TXNombre = new TextBox();
            LblNombre = new Label();
            TxtCORREO = new Label();
            TxtTelefonno = new Label();
            TxtDocumento = new Label();
            LblApellido = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGUsuarios).BeginInit();
            BtnBotones.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(LblGl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 110);
            panel1.TabIndex = 0;
            // 
            // LblGl
            // 
            LblGl.AutoSize = true;
            LblGl.Font = new Font("Trebuchet MS", 27.8490562F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblGl.ForeColor = Color.White;
            LblGl.Location = new Point(477, 30);
            LblGl.Name = "LblGl";
            LblGl.Size = new Size(451, 50);
            LblGl.TabIndex = 1;
            LblGl.Text = "GESTION DE USUARIOS";
            LblGl.Click += LblGl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(TxtBusqueda);
            panel2.Controls.Add(LblBusqueda);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 72);
            panel2.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.Font = new Font("Tempus Sans ITC", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = Color.Black;
            BtnBuscar.Location = new Point(1056, 22);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(99, 34);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Font = new Font("Palatino Linotype", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBusqueda.Location = new Point(505, 25);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(483, 28);
            TxtBusqueda.TabIndex = 2;
            // 
            // LblBusqueda
            // 
            LblBusqueda.AutoSize = true;
            LblBusqueda.BackColor = Color.Transparent;
            LblBusqueda.Font = new Font("SimSun", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBusqueda.ForeColor = Color.Black;
            LblBusqueda.Location = new Point(382, 25);
            LblBusqueda.Name = "LblBusqueda";
            LblBusqueda.Size = new Size(117, 27);
            LblBusqueda.TabIndex = 1;
            LblBusqueda.Text = "NOMBRE:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(DGUsuarios);
            panel3.Controls.Add(BtnBotones);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 783);
            panel3.TabIndex = 2;
            // 
            // DGUsuarios
            // 
            DGUsuarios.BackgroundColor = Color.PeachPuff;
            DGUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUsuarios.Location = new Point(402, 348);
            DGUsuarios.Name = "DGUsuarios";
            DGUsuarios.RowHeadersWidth = 45;
            DGUsuarios.Size = new Size(703, 322);
            DGUsuarios.TabIndex = 5;
            DGUsuarios.CellMouseClick += Cargar_Usuario_Seleccionado;
            // 
            // BtnBotones
            // 
            BtnBotones.BackColor = Color.MintCream;
            BtnBotones.Controls.Add(BtnCancelar);
            BtnBotones.Controls.Add(BtnEliminar);
            BtnBotones.Controls.Add(BtnEditar);
            BtnBotones.Controls.Add(BtnGuardar);
            BtnBotones.Controls.Add(BtnNuevo);
            BtnBotones.ForeColor = Color.LightGray;
            BtnBotones.Location = new Point(438, 268);
            BtnBotones.Name = "BtnBotones";
            BtnBotones.Size = new Size(630, 63);
            BtnBotones.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatStyle = FlatStyle.System;
            BtnCancelar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(510, 18);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 25);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.FlatStyle = FlatStyle.System;
            BtnEliminar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.Black;
            BtnEliminar.Location = new Point(401, 17);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(83, 25);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.FlatStyle = FlatStyle.System;
            BtnEditar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnEditar.ForeColor = Color.Black;
            BtnEditar.Location = new Point(280, 18);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(83, 25);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.FlatStyle = FlatStyle.System;
            BtnGuardar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.Black;
            BtnGuardar.Location = new Point(156, 18);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(83, 25);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.FlatStyle = FlatStyle.System;
            BtnNuevo.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnNuevo.ForeColor = Color.Black;
            BtnNuevo.Location = new Point(36, 17);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(83, 25);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "NUEVO";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(TXId);
            panel4.Controls.Add(TXCorreo);
            panel4.Controls.Add(TXTelefono);
            panel4.Controls.Add(TXDocumento);
            panel4.Controls.Add(TXApellido);
            panel4.Controls.Add(TXNombre);
            panel4.Controls.Add(LblNombre);
            panel4.Controls.Add(TxtCORREO);
            panel4.Controls.Add(TxtTelefonno);
            panel4.Controls.Add(TxtDocumento);
            panel4.Controls.Add(LblApellido);
            panel4.Location = new Point(0, 182);
            panel4.Name = "panel4";
            panel4.Size = new Size(1350, 262);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // TXId
            // 
            TXId.BackColor = Color.White;
            TXId.BorderStyle = BorderStyle.None;
            TXId.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXId.ForeColor = Color.White;
            TXId.Location = new Point(7, 27);
            TXId.Multiline = true;
            TXId.Name = "TXId";
            TXId.Size = new Size(19, 24);
            TXId.TabIndex = 26;
            // 
            // TXCorreo
            // 
            TXCorreo.BorderStyle = BorderStyle.None;
            TXCorreo.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXCorreo.Location = new Point(518, 210);
            TXCorreo.Multiline = true;
            TXCorreo.Name = "TXCorreo";
            TXCorreo.Size = new Size(470, 24);
            TXCorreo.TabIndex = 25;
            // 
            // TXTelefono
            // 
            TXTelefono.BorderStyle = BorderStyle.None;
            TXTelefono.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXTelefono.Location = new Point(518, 168);
            TXTelefono.Multiline = true;
            TXTelefono.Name = "TXTelefono";
            TXTelefono.Size = new Size(470, 24);
            TXTelefono.TabIndex = 24;
            // 
            // TXDocumento
            // 
            TXDocumento.BorderStyle = BorderStyle.None;
            TXDocumento.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXDocumento.Location = new Point(518, 122);
            TXDocumento.Multiline = true;
            TXDocumento.Name = "TXDocumento";
            TXDocumento.Size = new Size(470, 24);
            TXDocumento.TabIndex = 23;
            TXDocumento.TextChanged += textBox2_TextChanged;
            // 
            // TXApellido
            // 
            TXApellido.BorderStyle = BorderStyle.None;
            TXApellido.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXApellido.Location = new Point(518, 76);
            TXApellido.Multiline = true;
            TXApellido.Name = "TXApellido";
            TXApellido.Size = new Size(470, 24);
            TXApellido.TabIndex = 22;
            // 
            // TXNombre
            // 
            TXNombre.BorderStyle = BorderStyle.None;
            TXNombre.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXNombre.Location = new Point(518, 34);
            TXNombre.Multiline = true;
            TXNombre.Name = "TXNombre";
            TXNombre.Size = new Size(470, 24);
            TXNombre.TabIndex = 21;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblNombre.ForeColor = Color.Black;
            LblNombre.Location = new Point(416, 35);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(61, 16);
            LblNombre.TabIndex = 20;
            LblNombre.Text = "NOMBRE";
            LblNombre.Click += LblNombre_Click;
            // 
            // TxtCORREO
            // 
            TxtCORREO.AutoSize = true;
            TxtCORREO.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            TxtCORREO.ForeColor = Color.Black;
            TxtCORREO.Location = new Point(416, 211);
            TxtCORREO.Name = "TxtCORREO";
            TxtCORREO.Size = new Size(60, 16);
            TxtCORREO.TabIndex = 17;
            TxtCORREO.Text = "CORREO";
            // 
            // TxtTelefonno
            // 
            TxtTelefonno.AutoSize = true;
            TxtTelefonno.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            TxtTelefonno.ForeColor = Color.Black;
            TxtTelefonno.Location = new Point(416, 169);
            TxtTelefonno.Name = "TxtTelefonno";
            TxtTelefonno.Size = new Size(76, 16);
            TxtTelefonno.TabIndex = 16;
            TxtTelefonno.Text = "TELEFONO";
            // 
            // TxtDocumento
            // 
            TxtDocumento.AutoSize = true;
            TxtDocumento.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            TxtDocumento.ForeColor = Color.Black;
            TxtDocumento.Location = new Point(416, 123);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(91, 16);
            TxtDocumento.TabIndex = 15;
            TxtDocumento.Text = "DOCUMENTO";
            TxtDocumento.Click += TxtDocumento_Click;
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblApellido.ForeColor = Color.Black;
            LblApellido.Location = new Point(416, 77);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(68, 16);
            LblApellido.TabIndex = 14;
            LblApellido.Text = "APELLIDO";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 965);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGUsuarios).EndInit();
            BtnBotones.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LblGl;
        private Label LblBusqueda;
        private TextBox TxtBusqueda;
        private Button BtnBuscar;
        private Label LblNombre;
        private Label TxtCORREO;
        private Label TxtTelefonno;
        private Label TxtDocumento;
        private Label LblApellido;
        private TextBox textTitulo;
        private TextBox TXNombre;
        private Panel BtnBotones;
        private Button BtnCancelar;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private TextBox TXCorreo;
        private TextBox TXTelefono;
        private TextBox TXDocumento;
        private TextBox TXApellido;
        private DataGridView DGUsuarios;
        private TextBox TXId;
    }
}