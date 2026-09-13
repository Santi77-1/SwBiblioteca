namespace Biblioteca
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            PnlMenu = new Panel();
            BtnSalida = new Button();
            BtnReportes = new Button();
            BtnPrestamos = new Button();
            BtnEditoriales = new Button();
            BtnAutores = new Button();
            BtnUsuario = new Button();
            BtnLibros = new Button();
            BtnInicio = new Button();
            PnlLogo = new Panel();
            pictureLogo = new PictureBox();
            LblSubtitulo = new Label();
            LblTitulo = new Label();
            PnlSuperior = new Panel();
            PnlEstado = new Panel();
            PnlContenido = new Panel();
            PnlMenu.SuspendLayout();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = Color.PeachPuff;
            PnlMenu.Controls.Add(BtnSalida);
            PnlMenu.Controls.Add(BtnReportes);
            PnlMenu.Controls.Add(BtnPrestamos);
            PnlMenu.Controls.Add(BtnEditoriales);
            PnlMenu.Controls.Add(BtnAutores);
            PnlMenu.Controls.Add(BtnUsuario);
            PnlMenu.Controls.Add(BtnLibros);
            PnlMenu.Controls.Add(BtnInicio);
            PnlMenu.Controls.Add(PnlLogo);
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(454, 965);
            PnlMenu.TabIndex = 0;
            // 
            // BtnSalida
            // 
            BtnSalida.Cursor = Cursors.Hand;
            BtnSalida.FlatAppearance.BorderSize = 0;
            BtnSalida.FlatStyle = FlatStyle.Flat;
            BtnSalida.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnSalida.Location = new Point(3, 831);
            BtnSalida.Name = "BtnSalida";
            BtnSalida.Size = new Size(454, 59);
            BtnSalida.TabIndex = 10;
            BtnSalida.Text = "SALIDA";
            BtnSalida.UseVisualStyleBackColor = true;
            BtnSalida.Click += BtnSalida_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Cursor = Cursors.Hand;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnReportes.Location = new Point(0, 743);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(454, 59);
            BtnReportes.TabIndex = 9;
            BtnReportes.Text = "REPORTES";
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.Cursor = Cursors.Hand;
            BtnPrestamos.FlatAppearance.BorderSize = 0;
            BtnPrestamos.FlatStyle = FlatStyle.Flat;
            BtnPrestamos.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnPrestamos.Location = new Point(3, 653);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(454, 59);
            BtnPrestamos.TabIndex = 8;
            BtnPrestamos.Text = "PRESTAMOS";
            BtnPrestamos.UseVisualStyleBackColor = true;
            BtnPrestamos.Click += BtnPrestamos_Click;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.Cursor = Cursors.Hand;
            BtnEditoriales.FlatAppearance.BorderSize = 0;
            BtnEditoriales.FlatStyle = FlatStyle.Flat;
            BtnEditoriales.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnEditoriales.Location = new Point(3, 563);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(454, 59);
            BtnEditoriales.TabIndex = 7;
            BtnEditoriales.Text = "EDITORIALES";
            BtnEditoriales.UseVisualStyleBackColor = true;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.Cursor = Cursors.Hand;
            BtnAutores.FlatAppearance.BorderSize = 0;
            BtnAutores.FlatStyle = FlatStyle.Flat;
            BtnAutores.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnAutores.Location = new Point(3, 470);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(454, 59);
            BtnAutores.TabIndex = 6;
            BtnAutores.Text = "AUTORES";
            BtnAutores.UseVisualStyleBackColor = true;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.Cursor = Cursors.Hand;
            BtnUsuario.FlatAppearance.BorderSize = 0;
            BtnUsuario.FlatStyle = FlatStyle.Flat;
            BtnUsuario.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic);
            BtnUsuario.Location = new Point(3, 389);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(454, 59);
            BtnUsuario.TabIndex = 5;
            BtnUsuario.Text = "USUARIOS";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.Cursor = Cursors.Hand;
            BtnLibros.FlatAppearance.BorderSize = 0;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnLibros.Location = new Point(0, 307);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(454, 59);
            BtnLibros.TabIndex = 4;
            BtnLibros.Text = "LIBROS";
            BtnLibros.UseVisualStyleBackColor = true;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.AutoSize = true;
            BtnInicio.Cursor = Cursors.Hand;
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.Font = new Font("Unispace", 27.8490543F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnInicio.ForeColor = SystemColors.ControlText;
            BtnInicio.Location = new Point(0, 234);
            BtnInicio.Margin = new Padding(10, 0, 10, 0);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(454, 59);
            BtnInicio.TabIndex = 3;
            BtnInicio.Text = "INICIO";
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.DarkGreen;
            PnlLogo.Controls.Add(pictureLogo);
            PnlLogo.Controls.Add(LblSubtitulo);
            PnlLogo.Controls.Add(LblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(454, 234);
            PnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.ErrorImage = null;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.ImageLocation = "";
            pictureLogo.InitialImage = null;
            pictureLogo.Location = new Point(314, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(118, 198);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 2;
            pictureLogo.TabStop = false;
            pictureLogo.UseWaitCursor = true;
            pictureLogo.WaitOnLoad = true;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtitulo.ForeColor = Color.WhiteSmoke;
            LblSubtitulo.Location = new Point(12, 145);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(156, 25);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.Text = "Sietma de Gestion";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(3, 79);
            LblTitulo.Margin = new Padding(3, 0, 3, 5);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(317, 66);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "BIBLIOTECA";
            LblTitulo.Click += LblTitulo_Click;
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = Color.MintCream;
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(454, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(896, 70);
            PnlSuperior.TabIndex = 1;
            // 
            // PnlEstado
            // 
            PnlEstado.BackColor = Color.Silver;
            PnlEstado.Dock = DockStyle.Bottom;
            PnlEstado.Location = new Point(454, 925);
            PnlEstado.Name = "PnlEstado";
            PnlEstado.Size = new Size(896, 40);
            PnlEstado.TabIndex = 2;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = Color.White;
            PnlContenido.BorderStyle = BorderStyle.Fixed3D;
            PnlContenido.Dock = DockStyle.Fill;
            PnlContenido.Location = new Point(454, 70);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(896, 855);
            PnlContenido.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 965);
            Controls.Add(PnlContenido);
            Controls.Add(PnlEstado);
            Controls.Add(PnlSuperior);
            Controls.Add(PnlMenu);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion Biblioteca";
            WindowState = FormWindowState.Maximized;
            PnlMenu.ResumeLayout(false);
            PnlMenu.PerformLayout();
            PnlLogo.ResumeLayout(false);
            PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMenu;
        private Panel PnlSuperior;
        private Panel PnlEstado;
        private Panel PnlContenido;
        private Panel PnlLogo;
        private Label LblTitulo;
        private Label LblSubtitulo;
        private PictureBox pictureLogo;
        private Button BtnInicio;
        private Button BtnLibros;
        private Button BtnSalida;
        private Button BtnReportes;
        private Button BtnPrestamos;
        private Button BtnEditoriales;
        private Button BtnAutores;
        private Button BtnUsuario;
    }
}
