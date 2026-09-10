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
            PnlMenu.BackColor = Color.White;
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
            PnlMenu.Size = new Size(229, 450);
            PnlMenu.TabIndex = 0;
            // 
            // BtnSalida
            // 
            BtnSalida.Dock = DockStyle.Top;
            BtnSalida.FlatAppearance.BorderSize = 0;
            BtnSalida.FlatStyle = FlatStyle.Flat;
            BtnSalida.Location = new Point(0, 400);
            BtnSalida.Name = "BtnSalida";
            BtnSalida.Size = new Size(229, 50);
            BtnSalida.TabIndex = 10;
            BtnSalida.Text = "SALIDA";
            BtnSalida.UseVisualStyleBackColor = true;
            BtnSalida.Click += BtnSalida_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Location = new Point(0, 360);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(229, 40);
            BtnReportes.TabIndex = 9;
            BtnReportes.Text = "REPORTES";
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.Dock = DockStyle.Top;
            BtnPrestamos.FlatAppearance.BorderSize = 0;
            BtnPrestamos.FlatStyle = FlatStyle.Flat;
            BtnPrestamos.Location = new Point(0, 320);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(229, 40);
            BtnPrestamos.TabIndex = 8;
            BtnPrestamos.Text = "PRESTAMOS";
            BtnPrestamos.UseVisualStyleBackColor = true;
            BtnPrestamos.Click += BtnPrestamos_Click;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.Dock = DockStyle.Top;
            BtnEditoriales.FlatAppearance.BorderSize = 0;
            BtnEditoriales.FlatStyle = FlatStyle.Flat;
            BtnEditoriales.Location = new Point(0, 280);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(229, 40);
            BtnEditoriales.TabIndex = 7;
            BtnEditoriales.Text = "EDITORIALES";
            BtnEditoriales.UseVisualStyleBackColor = true;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.Dock = DockStyle.Top;
            BtnAutores.FlatAppearance.BorderSize = 0;
            BtnAutores.FlatStyle = FlatStyle.Flat;
            BtnAutores.Location = new Point(0, 240);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(229, 40);
            BtnAutores.TabIndex = 6;
            BtnAutores.Text = "AUTORES";
            BtnAutores.UseVisualStyleBackColor = true;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.Dock = DockStyle.Top;
            BtnUsuario.FlatAppearance.BorderSize = 0;
            BtnUsuario.FlatStyle = FlatStyle.Flat;
            BtnUsuario.Location = new Point(0, 200);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(229, 40);
            BtnUsuario.TabIndex = 5;
            BtnUsuario.Text = "USUARIOS";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.FlatAppearance.BorderSize = 0;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.Location = new Point(0, 160);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(229, 40);
            BtnLibros.TabIndex = 4;
            BtnLibros.Text = "LIBROS";
            BtnLibros.UseVisualStyleBackColor = true;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.AutoSize = true;
            BtnInicio.Dock = DockStyle.Top;
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.FlatStyle = FlatStyle.Flat;
            BtnInicio.ForeColor = SystemColors.ControlText;
            BtnInicio.Location = new Point(0, 120);
            BtnInicio.Margin = new Padding(10, 0, 10, 0);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(229, 40);
            BtnInicio.TabIndex = 3;
            BtnInicio.Text = "INICIO";
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.MidnightBlue;
            PnlLogo.Controls.Add(pictureLogo);
            PnlLogo.Controls.Add(LblSubtitulo);
            PnlLogo.Controls.Add(LblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(229, 120);
            PnlLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.ErrorImage = null;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.ImageLocation = "";
            pictureLogo.InitialImage = null;
            pictureLogo.Location = new Point(123, 47);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(74, 62);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 2;
            pictureLogo.TabStop = false;
            pictureLogo.UseWaitCursor = true;
            pictureLogo.WaitOnLoad = true;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.Font = new Font("Segoe UI", 8.830189F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtitulo.ForeColor = Color.WhiteSmoke;
            LblSubtitulo.Location = new Point(3, 44);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(114, 17);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.Text = "Sietma de Gestion";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Snap ITC", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(0, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(226, 35);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "BIBLIOTECA";
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = Color.LightCyan;
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(229, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(571, 70);
            PnlSuperior.TabIndex = 1;
            // 
            // PnlEstado
            // 
            PnlEstado.BackColor = Color.Silver;
            PnlEstado.Dock = DockStyle.Bottom;
            PnlEstado.Location = new Point(229, 410);
            PnlEstado.Name = "PnlEstado";
            PnlEstado.Size = new Size(571, 40);
            PnlEstado.TabIndex = 2;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = Color.WhiteSmoke;
            PnlContenido.Dock = DockStyle.Fill;
            PnlContenido.Location = new Point(229, 70);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(571, 340);
            PnlContenido.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
