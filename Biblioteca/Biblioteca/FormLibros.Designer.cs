namespace Biblioteca
{
    partial class FormLibros
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
            Pnltitulo = new Panel();
            LblGl = new Label();
            PnlBusqueda = new Panel();
            BtnBuscar = new Button();
            TxtBuscar = new TextBox();
            LblBusqueda = new Label();
            PnlDatos = new Panel();
            CBEditorial = new ComboBox();
            CBAutor = new ComboBox();
            textTitulo = new TextBox();
            label2 = new Label();
            TextUnidades = new TextBox();
            TextAño = new TextBox();
            TextCategoria = new TextBox();
            TextIsbn = new TextBox();
            TxtUnidades = new Label();
            TxtAnio = new Label();
            TxtCategoria = new Label();
            TxtEditorial = new Label();
            TxtAutor = new Label();
            LblTitulo = new Label();
            BtnBotones = new Panel();
            BtnCancelar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            DgLibros = new DataGridView();
            Pnltitulo.SuspendLayout();
            PnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            BtnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgLibros).BeginInit();
            SuspendLayout();
            // 
            // Pnltitulo
            // 
            Pnltitulo.BackColor = Color.DeepSkyBlue;
            Pnltitulo.Controls.Add(LblGl);
            Pnltitulo.Dock = DockStyle.Top;
            Pnltitulo.Location = new Point(0, 0);
            Pnltitulo.Margin = new Padding(11, 6, 11, 6);
            Pnltitulo.Name = "Pnltitulo";
            Pnltitulo.Size = new Size(1344, 74);
            Pnltitulo.TabIndex = 0;
            // 
            // LblGl
            // 
            LblGl.AutoSize = true;
            LblGl.Location = new Point(523, 9);
            LblGl.Name = "LblGl";
            LblGl.Size = new Size(359, 44);
            LblGl.TabIndex = 0;
            LblGl.Text = "GESTION DE LIBROS";
            LblGl.Click += label3_Click;
            // 
            // PnlBusqueda
            // 
            PnlBusqueda.BackColor = Color.WhiteSmoke;
            PnlBusqueda.Controls.Add(BtnBuscar);
            PnlBusqueda.Controls.Add(TxtBuscar);
            PnlBusqueda.Controls.Add(LblBusqueda);
            PnlBusqueda.Dock = DockStyle.Top;
            PnlBusqueda.Location = new Point(0, 74);
            PnlBusqueda.Name = "PnlBusqueda";
            PnlBusqueda.Size = new Size(1344, 55);
            PnlBusqueda.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.Font = new Font("SimSun", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = Color.Black;
            BtnBuscar.Location = new Point(940, 8);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(99, 34);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Font = new Font("Showcard Gothic", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(445, 9);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(463, 33);
            TxtBuscar.TabIndex = 1;
            // 
            // LblBusqueda
            // 
            LblBusqueda.AutoSize = true;
            LblBusqueda.BackColor = Color.Transparent;
            LblBusqueda.Font = new Font("SimSun", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBusqueda.ForeColor = Color.Black;
            LblBusqueda.Location = new Point(346, 12);
            LblBusqueda.Name = "LblBusqueda";
            LblBusqueda.Size = new Size(72, 27);
            LblBusqueda.TabIndex = 0;
            LblBusqueda.Text = "ISBN";
            // 
            // PnlDatos
            // 
            PnlDatos.Controls.Add(CBEditorial);
            PnlDatos.Controls.Add(CBAutor);
            PnlDatos.Controls.Add(textTitulo);
            PnlDatos.Controls.Add(label2);
            PnlDatos.Controls.Add(TextUnidades);
            PnlDatos.Controls.Add(TextAño);
            PnlDatos.Controls.Add(TextCategoria);
            PnlDatos.Controls.Add(TextIsbn);
            PnlDatos.Controls.Add(TxtUnidades);
            PnlDatos.Controls.Add(TxtAnio);
            PnlDatos.Controls.Add(TxtCategoria);
            PnlDatos.Controls.Add(TxtEditorial);
            PnlDatos.Controls.Add(TxtAutor);
            PnlDatos.Controls.Add(LblTitulo);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 129);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1344, 235);
            PnlDatos.TabIndex = 2;
            // 
            // CBEditorial
            // 
            CBEditorial.Font = new Font("Showcard Gothic", 8.773584F, FontStyle.Bold);
            CBEditorial.FormattingEnabled = true;
            CBEditorial.Location = new Point(470, 89);
            CBEditorial.Name = "CBEditorial";
            CBEditorial.Size = new Size(470, 25);
            CBEditorial.TabIndex = 17;
            // 
            // CBAutor
            // 
            CBAutor.Font = new Font("Simple Bold Jut Out", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            CBAutor.FormattingEnabled = true;
            CBAutor.Location = new Point(470, 64);
            CBAutor.Name = "CBAutor";
            CBAutor.Size = new Size(470, 26);
            CBAutor.TabIndex = 16;
            // 
            // textTitulo
            // 
            textTitulo.BorderStyle = BorderStyle.None;
            textTitulo.Font = new Font("Simple Bold Jut Out", 8.150944F);
            textTitulo.Location = new Point(470, 42);
            textTitulo.Multiline = true;
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(470, 24);
            textTitulo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simple Indust Shaded", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(315, 18);
            label2.Name = "label2";
            label2.Size = new Size(49, 24);
            label2.TabIndex = 13;
            label2.Text = "ISBN";
            label2.Click += label2_Click;
            // 
            // TextUnidades
            // 
            TextUnidades.BorderStyle = BorderStyle.None;
            TextUnidades.Font = new Font("Simple Bold Jut Out", 8.150944F);
            TextUnidades.Location = new Point(470, 162);
            TextUnidades.Multiline = true;
            TextUnidades.Name = "TextUnidades";
            TextUnidades.Size = new Size(470, 24);
            TextUnidades.TabIndex = 12;
            // 
            // TextAño
            // 
            TextAño.BorderStyle = BorderStyle.None;
            TextAño.Font = new Font("Simple Bold Jut Out", 8.150944F);
            TextAño.Location = new Point(470, 138);
            TextAño.Multiline = true;
            TextAño.Name = "TextAño";
            TextAño.Size = new Size(470, 24);
            TextAño.TabIndex = 11;
            TextAño.Text = " ";
            // 
            // TextCategoria
            // 
            TextCategoria.BorderStyle = BorderStyle.None;
            TextCategoria.Font = new Font("Simple Bold Jut Out", 8.150944F);
            TextCategoria.Location = new Point(470, 114);
            TextCategoria.Multiline = true;
            TextCategoria.Name = "TextCategoria";
            TextCategoria.Size = new Size(470, 24);
            TextCategoria.TabIndex = 10;
            // 
            // TextIsbn
            // 
            TextIsbn.BorderStyle = BorderStyle.None;
            TextIsbn.Font = new Font("Simple Bold Jut Out", 8.150944F);
            TextIsbn.Location = new Point(470, 18);
            TextIsbn.Multiline = true;
            TextIsbn.Name = "TextIsbn";
            TextIsbn.Size = new Size(470, 24);
            TextIsbn.TabIndex = 7;
            // 
            // TxtUnidades
            // 
            TxtUnidades.AutoSize = true;
            TxtUnidades.Font = new Font("Simple Indust Shaded", 8.150944F);
            TxtUnidades.ForeColor = Color.Black;
            TxtUnidades.Location = new Point(315, 162);
            TxtUnidades.Name = "TxtUnidades";
            TxtUnidades.Size = new Size(97, 24);
            TxtUnidades.TabIndex = 6;
            TxtUnidades.Text = "UNIDADES";
            // 
            // TxtAnio
            // 
            TxtAnio.AutoSize = true;
            TxtAnio.Font = new Font("Simple Indust Shaded", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            TxtAnio.ForeColor = Color.Black;
            TxtAnio.Location = new Point(315, 138);
            TxtAnio.Name = "TxtAnio";
            TxtAnio.Size = new Size(46, 24);
            TxtAnio.TabIndex = 5;
            TxtAnio.Text = "AÑO";
            TxtAnio.Click += TxtAnio_Click;
            // 
            // TxtCategoria
            // 
            TxtCategoria.AutoSize = true;
            TxtCategoria.Font = new Font("Simple Indust Shaded", 8.150944F);
            TxtCategoria.ForeColor = Color.Black;
            TxtCategoria.Location = new Point(315, 114);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(107, 24);
            TxtCategoria.TabIndex = 4;
            TxtCategoria.Text = "CATEGORIA";
            // 
            // TxtEditorial
            // 
            TxtEditorial.AutoSize = true;
            TxtEditorial.Font = new Font("Simple Indust Shaded", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            TxtEditorial.ForeColor = Color.Black;
            TxtEditorial.Location = new Point(315, 90);
            TxtEditorial.Name = "TxtEditorial";
            TxtEditorial.Size = new Size(98, 24);
            TxtEditorial.TabIndex = 3;
            TxtEditorial.Text = "EDITORIAL";
            // 
            // TxtAutor
            // 
            TxtAutor.AutoSize = true;
            TxtAutor.Font = new Font("Simple Indust Shaded", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            TxtAutor.ForeColor = Color.Black;
            TxtAutor.Location = new Point(315, 66);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(68, 24);
            TxtAutor.TabIndex = 1;
            TxtAutor.Text = "AUTOR";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Simple Indust Shaded", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 178);
            LblTitulo.ForeColor = Color.Black;
            LblTitulo.Location = new Point(315, 42);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(69, 24);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "TITULO";
            // 
            // BtnBotones
            // 
            BtnBotones.BackColor = Color.WhiteSmoke;
            BtnBotones.Controls.Add(BtnCancelar);
            BtnBotones.Controls.Add(BtnEliminar);
            BtnBotones.Controls.Add(BtnEditar);
            BtnBotones.Controls.Add(BtnGuardar);
            BtnBotones.Controls.Add(BtnNuevo);
            BtnBotones.ForeColor = Color.LightGray;
            BtnBotones.Location = new Point(409, 370);
            BtnBotones.Name = "BtnBotones";
            BtnBotones.Size = new Size(630, 65);
            BtnBotones.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Simple Bold Jut Out", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(510, 18);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 25);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Simple Bold Jut Out", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BtnEliminar.ForeColor = Color.Black;
            BtnEliminar.Location = new Point(401, 17);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(83, 25);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Simple Bold Jut Out", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BtnEditar.ForeColor = Color.Black;
            BtnEditar.Location = new Point(280, 18);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(83, 25);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Simple Bold Jut Out", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BtnGuardar.ForeColor = Color.Black;
            BtnGuardar.Location = new Point(156, 18);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(83, 25);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Simple Bold Jut Out", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 178);
            BtnNuevo.ForeColor = Color.Black;
            BtnNuevo.Location = new Point(36, 17);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(83, 25);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "NUEVO";
            BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // DgLibros
            // 
            DgLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgLibros.Location = new Point(205, 584);
            DgLibros.Name = "DgLibros";
            DgLibros.RowHeadersWidth = 45;
            DgLibros.Size = new Size(1014, 143);
            DgLibros.TabIndex = 4;
            DgLibros.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(106F, 106F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1344, 727);
            Controls.Add(DgLibros);
            Controls.Add(BtnBotones);
            Controls.Add(PnlDatos);
            Controls.Add(PnlBusqueda);
            Controls.Add(Pnltitulo);
            Font = new Font("Showcard Gothic", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(11, 6, 11, 6);
            Name = "FormLibros";
            Text = " ";
            Load += FormLibros_Load;
            Pnltitulo.ResumeLayout(false);
            Pnltitulo.PerformLayout();
            PnlBusqueda.ResumeLayout(false);
            PnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            BtnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnltitulo;
        private Label Lbltitulo;
        private Panel PnlBusqueda;
        private Label LblBusqueda;
        private Button BtnBuscar;
        private TextBox TxtBuscar;
        private Panel PnlDatos;
        private Label label1;
        private Label TxtAutor;
        private Label LblTitulo;
        private Label TxtUnidades;
        private Label TxtAnio;
        private Label TxtCategoria;
        private Label TxtEditorial;
        private Panel BtnBotones;
        private Button BtnCancelar;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private DataGridView DgLibros;
        private TextBox TextUnidades;
        private TextBox TextAño;
        private TextBox TextCategoria;
        private TextBox TextAutor;
        private TextBox TextEditorial;
        private TextBox TextIsbn;
        private Label label2;
        private Label LblGl;
        private TextBox textTitulo;
        private ComboBox CBEditorial;
        private ComboBox CBAutor;
    }
}