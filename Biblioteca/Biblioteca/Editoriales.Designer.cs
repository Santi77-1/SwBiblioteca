namespace Biblioteca
{
    partial class FormEditoriales
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            LblGl = new Label();
            panel2 = new Panel();
            TXId = new TextBox();
            LblNombre = new Label();
            TXNombre = new TextBox();
            panel3 = new Panel();
            DGEditoriales = new DataGridView();
            BtnBotones = new Panel();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGEditoriales).BeginInit();
            BtnBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(LblGl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 83);
            panel1.TabIndex = 0;
            // 
            // LblGl
            // 
            LblGl.AutoSize = true;
            LblGl.Font = new Font("Trebuchet MS", 27.8490562F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblGl.ForeColor = SystemColors.ButtonHighlight;
            LblGl.Location = new Point(477, 16);
            LblGl.Name = "LblGl";
            LblGl.Size = new Size(508, 50);
            LblGl.TabIndex = 1;
            LblGl.Text = "GESTION DE EDITORIALES";
            LblGl.Click += LblGl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(TXId);
            panel2.Controls.Add(LblNombre);
            panel2.Controls.Add(TXNombre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 149);
            panel2.TabIndex = 1;
            // 
            // TXId
            // 
            TXId.BorderStyle = BorderStyle.None;
            TXId.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXId.ForeColor = Color.White;
            TXId.Location = new Point(140, 27);
            TXId.Multiline = true;
            TXId.Name = "TXId";
            TXId.Size = new Size(35, 24);
            TXId.TabIndex = 20;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Verdana", 8.830189F, FontStyle.Italic);
            LblNombre.ForeColor = Color.Black;
            LblNombre.Location = new Point(363, 54);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(61, 16);
            LblNombre.TabIndex = 18;
            LblNombre.Text = "NOMBRE";
            // 
            // TXNombre
            // 
            TXNombre.BorderStyle = BorderStyle.None;
            TXNombre.Font = new Font("Palatino Linotype", 8.830189F, FontStyle.Bold);
            TXNombre.Location = new Point(518, 46);
            TXNombre.Multiline = true;
            TXNombre.Name = "TXNombre";
            TXNombre.Size = new Size(470, 24);
            TXNombre.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(DGEditoriales);
            panel3.Controls.Add(BtnBotones);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 733);
            panel3.TabIndex = 2;
            // 
            // DGEditoriales
            // 
            DGEditoriales.AccessibleRole = AccessibleRole.None;
            DGEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGEditoriales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGEditoriales.BackgroundColor = Color.PeachPuff;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Simple Bold Jut Out", 10.7735844F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGEditoriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new Font("Simple Bold Jut Out", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 178);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGEditoriales.DefaultCellStyle = dataGridViewCellStyle6;
            DGEditoriales.Location = new Point(424, 173);
            DGEditoriales.Name = "DGEditoriales";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Simple Bold Jut Out", 10.7735844F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGEditoriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGEditoriales.RowHeadersWidth = 45;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            DGEditoriales.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DGEditoriales.Size = new Size(536, 356);
            DGEditoriales.TabIndex = 5;
            DGEditoriales.CellMouseDoubleClick += Cargar_Autor_Seleccionado;
            // 
            // BtnBotones
            // 
            BtnBotones.BackColor = Color.MintCream;
            BtnBotones.Controls.Add(BtnCancelar);
            BtnBotones.Controls.Add(BtnGuardar);
            BtnBotones.Controls.Add(BtnNuevo);
            BtnBotones.ForeColor = Color.LightGray;
            BtnBotones.Location = new Point(496, 22);
            BtnBotones.Name = "BtnBotones";
            BtnBotones.Size = new Size(378, 65);
            BtnBotones.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatStyle = FlatStyle.System;
            BtnCancelar.Font = new Font("Tempus Sans ITC", 8.830189F, FontStyle.Bold);
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(267, 17);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 25);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
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
            // FormEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 965);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEditoriales";
            Text = "FormAutores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGEditoriales).EndInit();
            BtnBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LblGl;
        private TextBox textTitulo;
        private Label LblNombre;
        private TextBox TXNombre;
        private TextBox TXId;
        private Panel BtnBotones;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Button BtnNuevo;
        private DataGridView DGEditoriales;
    }
}