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
    public partial class FormUsuarios : Form
    {
        private bool modoEdition = false;
        public FormUsuarios()
        {

            InitializeComponent();
            Cargar_Usuarios();
        }
        private void Cargar_Usuario_Seleccionado(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGUsuarios.CurrentRow == null)
                return;
            TXId.Text = DGUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            TXNombre.Text = DGUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            TXApellido.Text = DGUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            TXDocumento.Text = DGUsuarios.CurrentRow.Cells["Documento"].Value.ToString();
            TXTelefono.Text = DGUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            TXCorreo.Text = DGUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
        }
        private void Cargar_Usuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        DGUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los Usuarios:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void TxtDocumento_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtBusqueda.Text))
                {
                    MessageBox.Show(
                        "Ingrese un nombre para realizar la busqueda",
                        "Bilioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM USUARIOS WHERE CONCAT(Nombre , ' ' , Apellido) = @Nombre";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", TxtBusqueda.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                TXId.Text = lector["Id"].ToString();
                                TXNombre.Text = lector["Nombre"].ToString();
                                TXApellido.Text = lector["Apellido"].ToString();
                                TXDocumento.Text = lector["Documento"].ToString();
                                TXTelefono.Text = lector["Telefono"].ToString();
                                TXCorreo.Text = lector["Correo"].ToString();
                                MessageBox.Show(
                                    "Libro encontrado",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un Usuario con el Nombre proporcionado",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TXNombre.Clear();
            TXApellido.Clear();
            TXDocumento.Clear();
            TXTelefono.Clear();
            TXCorreo.Clear();

            TxtBusqueda.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXApellido.Text) ||
                    string.IsNullOrWhiteSpace(TXDocumento.Text) ||
                    string.IsNullOrWhiteSpace(TXTelefono.Text) ||
                    string.IsNullOrWhiteSpace(TXCorreo.Text)
                    )
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                int Documento, Telefono;

                if (!int.TryParse(TXDocumento.Text, out Documento))
                {
                    MessageBox.Show(
                        "El documento debe ser un numero entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!int.TryParse(TXTelefono.Text, out Telefono))
                {
                    MessageBox.Show(
                        "El Telefono debe ser un numero entero.",
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

                    string consulta = "INSERT INTO USUARIOS " +
                        "(Nombre, Apellido,Documento , Telefono, Correo) " +
                        "VALUES " +
                        "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", TXNombre.Text.Trim());
                        comando.Parameters.AddWithValue("@Apellido", TXApellido.Text.Trim());
                        comando.Parameters.AddWithValue("@Correo", TXCorreo.Text.Trim());
                        comando.Parameters.AddWithValue("@Documento", Documento);
                        comando.Parameters.AddWithValue("@Telefono", Telefono);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Cargar_Usuarios();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el Usuario:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LblGl_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXApellido.Text) ||
                    string.IsNullOrWhiteSpace(TXDocumento.Text) ||
                    string.IsNullOrWhiteSpace(TXTelefono.Text) ||
                    string.IsNullOrWhiteSpace(TXCorreo.Text)
                    )
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;

                }
                int Documento, Telefono;

                if (!int.TryParse(TXDocumento.Text, out Documento))
                {
                    MessageBox.Show(
                        "El Documento debe ser un numero entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!int.TryParse(TXTelefono.Text, out Telefono))
                {
                    MessageBox.Show(
                        "El telefono debe ser un numero entero.",
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

                    string consulta = "UPDATE USUARIOS SET " +
                        "Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "Documento = @Documento, " +
                        "Telefono = @Telefono, " +
                        "Correo = @Correo  " +
                        "WHERE Id = @Id";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Id", TXId.Text.Trim());
                        comando.Parameters.AddWithValue("@Nombre", TXNombre.Text.Trim());
                        comando.Parameters.AddWithValue("@Apellido", TXApellido.Text.Trim());
                        comando.Parameters.AddWithValue("@Documento", Documento);
                        comando.Parameters.AddWithValue("@Telefono", Telefono);
                        comando.Parameters.AddWithValue("@Correo", TXCorreo.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Cargar_Usuarios();
                BtnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el Usuario:\n " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TXNombre.Clear();
            TXApellido.Clear();
            TXDocumento.Clear();
            TXTelefono.Clear();
            TXCorreo.Clear();

            modoEdition = false;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGUsuarios.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un usuario para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                string Id = DGUsuarios.CurrentRow.Cells["Id"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este usuario?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "DELETE FROM USUARIOS WHERE Id = @Id";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Id", Id);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                modoEdition = false;
                TXId.Enabled = true;

                Cargar_Usuarios();
                BtnNuevo_Click(null, null);
            }
            catch
            {
                MessageBox.Show(
                    "Error al eliminar el Usuarios.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}
