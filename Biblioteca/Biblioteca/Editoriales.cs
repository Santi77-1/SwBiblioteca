using Biblioteca.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormEditoriales : Form
    {
        private bool modoEdition = false;
        public FormEditoriales()
        {
            InitializeComponent();
            Cargar_Editoriales();
        }
        private void Cargar_Editoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM EDITORIALES";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        DGEditoriales.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las Editoriales:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TXId.Clear();
            TXNombre.Clear();

            TXId.Focus();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXNombre.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "INSERT INTO EDITORIALES " +
                        "(Nombre) " +
                        "VALUES " +
                        "(@Nombre)";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", TXNombre.Text.Trim());
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial guardada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Cargar_Editoriales();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la editorial:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TXId.Clear();
            TXNombre.Clear();

            modoEdition = false;

        }
        private void Cargar_Autor_Seleccionado(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGEditoriales.CurrentRow == null)
                return;
            TXId.Text = DGEditoriales.CurrentRow.Cells["Id"].Value.ToString();
            TXNombre.Text = DGEditoriales.CurrentRow.Cells["Nombre"].Value.ToString();


        }
        private void TXApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblGl_Click(object sender, EventArgs e)
        {

        }
    }
}
