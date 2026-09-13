namespace Biblioteca
{
    partial class FormReportes
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
            PnlOpiones = new Panel();
            BtnLimpiar = new Button();
            BtnGenerar = new Button();
            CBTiporeporte = new ComboBox();
            LblTiporepote = new Label();
            PnlLista = new Panel();
            DGReporte = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlOpiones.SuspendLayout();
            PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGReporte).BeginInit();
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
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Trebuchet MS", 27.8490562F, FontStyle.Bold | FontStyle.Italic);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(491, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(463, 50);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE REPORTES";
            // 
            // PnlOpiones
            // 
            PnlOpiones.BackColor = Color.White;
            PnlOpiones.Controls.Add(BtnLimpiar);
            PnlOpiones.Controls.Add(BtnGenerar);
            PnlOpiones.Controls.Add(CBTiporeporte);
            PnlOpiones.Controls.Add(LblTiporepote);
            PnlOpiones.Dock = DockStyle.Top;
            PnlOpiones.Font = new Font("Segoe UI Symbol", 21.73585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PnlOpiones.Location = new Point(0, 70);
            PnlOpiones.Name = "PnlOpiones";
            PnlOpiones.Size = new Size(1350, 240);
            PnlOpiones.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnLimpiar.Location = new Point(865, 117);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(135, 50);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "LIMPIAR";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnGenerar
            // 
            BtnGenerar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnGenerar.Location = new Point(513, 117);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(155, 50);
            BtnGenerar.TabIndex = 10;
            BtnGenerar.Text = "GENERAR REPORTE";
            BtnGenerar.UseVisualStyleBackColor = true;
            BtnGenerar.Click += BtnGenerar_Click;
            // 
            // CBTiporeporte
            // 
            CBTiporeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTiporeporte.Font = new Font("Palatino Linotype", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBTiporeporte.FormattingEnabled = true;
            CBTiporeporte.Location = new Point(513, 55);
            CBTiporeporte.Name = "CBTiporeporte";
            CBTiporeporte.Size = new Size(487, 32);
            CBTiporeporte.TabIndex = 1;
            // 
            // LblTiporepote
            // 
            LblTiporepote.AutoSize = true;
            LblTiporepote.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTiporepote.Location = new Point(265, 57);
            LblTiporepote.Name = "LblTiporepote";
            LblTiporepote.Size = new Size(230, 25);
            LblTiporepote.TabIndex = 0;
            LblTiporepote.Text = "TIPO DE REPORTE:";
            // 
            // PnlLista
            // 
            PnlLista.Controls.Add(DGReporte);
            PnlLista.Dock = DockStyle.Fill;
            PnlLista.Location = new Point(0, 310);
            PnlLista.Name = "PnlLista";
            PnlLista.Size = new Size(1350, 655);
            PnlLista.TabIndex = 2;
            // 
            // DGReporte
            // 
            DGReporte.AllowUserToAddRows = false;
            DGReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGReporte.BackgroundColor = Color.PeachPuff;
            DGReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGReporte.Dock = DockStyle.Fill;
            DGReporte.Location = new Point(0, 0);
            DGReporte.MultiSelect = false;
            DGReporte.Name = "DGReporte";
            DGReporte.ReadOnly = true;
            DGReporte.RowHeadersWidth = 45;
            DGReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGReporte.Size = new Size(1350, 655);
            DGReporte.TabIndex = 0;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 965);
            Controls.Add(PnlLista);
            Controls.Add(PnlOpiones);
            Controls.Add(PnlTitulo);
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormReportes";
            WindowState = FormWindowState.Maximized;
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            PnlOpiones.ResumeLayout(false);
            PnlOpiones.PerformLayout();
            PnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlOpiones;
        private Panel PnlLista;
        private Label LblTitulo;
        private ComboBox CBTiporeporte;
        private Label LblTiporepote;
        private Button BtnGuardar;
        private Button BtnGenerar;
        private Button BtnLimpiar;
        private DataGridView DGReporte;
    }
}