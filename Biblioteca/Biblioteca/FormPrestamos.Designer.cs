namespace Biblioteca
{
    partial class FormPrestamos
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
            PnlTitulo = new Panel();
            LblTitulo = new Label();
            PnlDatos = new Panel();
            BtnCancelar = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            DTDevolucion = new DateTimePicker();
            DTPrestamo = new DateTimePicker();
            LblDevolucion = new Label();
            LblFprestamo = new Label();
            CBLibro = new ComboBox();
            LblLibro = new Label();
            CBUsuario = new ComboBox();
            Lblusuario = new Label();
            PnlLista = new Panel();
            DGPrestamos = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            PnlTitulo.SuspendLayout();
            PnlDatos.SuspendLayout();
            PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGPrestamos).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.DarkGreen;
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1350, 70);
            PnlTitulo.TabIndex = 1;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Trebuchet MS", 27.8490562F, FontStyle.Bold | FontStyle.Italic);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(431, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(490, 50);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE PRESTAMOS";
            // 
            // PnlDatos
            // 
            PnlDatos.BackColor = Color.White;
            PnlDatos.Controls.Add(BtnCancelar);
            PnlDatos.Controls.Add(BtnEliminar);
            PnlDatos.Controls.Add(BtnEditar);
            PnlDatos.Controls.Add(BtnGuardar);
            PnlDatos.Controls.Add(BtnNuevo);
            PnlDatos.Controls.Add(DTDevolucion);
            PnlDatos.Controls.Add(DTPrestamo);
            PnlDatos.Controls.Add(LblDevolucion);
            PnlDatos.Controls.Add(LblFprestamo);
            PnlDatos.Controls.Add(CBLibro);
            PnlDatos.Controls.Add(LblLibro);
            PnlDatos.Controls.Add(CBUsuario);
            PnlDatos.Controls.Add(Lblusuario);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 70);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1350, 350);
            PnlDatos.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnCancelar.Location = new Point(872, 250);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(83, 25);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnEliminar.Location = new Point(740, 250);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(83, 25);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnEditar.Location = new Point(613, 250);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(83, 25);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnGuardar.Location = new Point(494, 250);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(83, 25);
            BtnGuardar.TabIndex = 9;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnNuevo.Location = new Point(373, 250);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(83, 25);
            BtnNuevo.TabIndex = 8;
            BtnNuevo.Text = "NUEVO";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_click;
            // 
            // DTDevolucion
            // 
            DTDevolucion.Checked = false;
            DTDevolucion.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            DTDevolucion.Format = DateTimePickerFormat.Short;
            DTDevolucion.Location = new Point(550, 154);
            DTDevolucion.Name = "DTDevolucion";
            DTDevolucion.ShowCheckBox = true;
            DTDevolucion.Size = new Size(395, 25);
            DTDevolucion.TabIndex = 7;
            // 
            // DTPrestamo
            // 
            DTPrestamo.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            DTPrestamo.Format = DateTimePickerFormat.Short;
            DTPrestamo.Location = new Point(550, 118);
            DTPrestamo.Name = "DTPrestamo";
            DTPrestamo.Size = new Size(395, 25);
            DTPrestamo.TabIndex = 6;
            // 
            // LblDevolucion
            // 
            LblDevolucion.AutoSize = true;
            LblDevolucion.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblDevolucion.Location = new Point(323, 154);
            LblDevolucion.Name = "LblDevolucion";
            LblDevolucion.Size = new Size(167, 16);
            LblDevolucion.TabIndex = 5;
            LblDevolucion.Text = "FECHA DE DEVOLUCION:";
            // 
            // LblFprestamo
            // 
            LblFprestamo.AutoSize = true;
            LblFprestamo.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblFprestamo.Location = new Point(323, 118);
            LblFprestamo.Name = "LblFprestamo";
            LblFprestamo.Size = new Size(151, 16);
            LblFprestamo.TabIndex = 4;
            LblFprestamo.Text = "FECHA DE PRESTAMO:";
            // 
            // CBLibro
            // 
            CBLibro.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            CBLibro.FormattingEnabled = true;
            CBLibro.Location = new Point(505, 72);
            CBLibro.Name = "CBLibro";
            CBLibro.Size = new Size(440, 26);
            CBLibro.TabIndex = 3;
            // 
            // LblLibro
            // 
            LblLibro.AutoSize = true;
            LblLibro.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblLibro.Location = new Point(323, 72);
            LblLibro.Name = "LblLibro";
            LblLibro.Size = new Size(51, 16);
            LblLibro.TabIndex = 2;
            LblLibro.Text = "LIBRO:";
            // 
            // CBUsuario
            // 
            CBUsuario.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            CBUsuario.FormattingEnabled = true;
            CBUsuario.Location = new Point(505, 33);
            CBUsuario.Name = "CBUsuario";
            CBUsuario.Size = new Size(440, 26);
            CBUsuario.TabIndex = 1;
            // 
            // Lblusuario
            // 
            Lblusuario.AutoSize = true;
            Lblusuario.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            Lblusuario.Location = new Point(323, 33);
            Lblusuario.Name = "Lblusuario";
            Lblusuario.Size = new Size(70, 16);
            Lblusuario.TabIndex = 0;
            Lblusuario.Text = "USUARIO:";
            // 
            // PnlLista
            // 
            PnlLista.Controls.Add(DGPrestamos);
            PnlLista.Dock = DockStyle.Fill;
            PnlLista.Location = new Point(0, 420);
            PnlLista.Name = "PnlLista";
            PnlLista.Size = new Size(1350, 545);
            PnlLista.TabIndex = 3;
            // 
            // DGPrestamos
            // 
            DGPrestamos.AllowUserToAddRows = false;
            DGPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGPrestamos.BackgroundColor = Color.PeachPuff;
            DGPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPrestamos.Dock = DockStyle.Fill;
            DGPrestamos.Location = new Point(0, 0);
            DGPrestamos.MultiSelect = false;
            DGPrestamos.Name = "DGPrestamos";
            DGPrestamos.ReadOnly = true;
            DGPrestamos.RowHeadersWidth = 45;
            DGPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGPrestamos.Size = new Size(1350, 545);
            DGPrestamos.TabIndex = 0;
            DGPrestamos.CellDoubleClick += DGPrestamos_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 965);
            Controls.Add(PnlLista);
            Controls.Add(PnlDatos);
            Controls.Add(PnlTitulo);
            Name = "FormPrestamos";
            Text = "PRESTAMOS";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            PnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlDatos;
        private Panel PnlLista;
        private Label LblTitulo;
        private Label Lblusuario;
        private ComboBox CBLibro;
        private Label LblLibro;
        private ComboBox CBUsuario;
        private Label LblFprestamo;
        private DateTimePicker DTPrestamo;
        private Label LblDevolucion;
        private Button BtnCancelar;
        private Button BtnEliminar;
        private Button BtnEditar;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private DateTimePicker DTDevolucion;
        private DataGridView DGPrestamos;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}