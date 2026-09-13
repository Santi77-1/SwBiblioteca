using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Biblioteca.Datos;


namespace Biblioteca
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
            Carga_Prestamos();
            Cargar_Uuarios();
            Cargar_Libros();
            DTPrestamo.Value = DateTime.Now;
            DTDevolucion.Value = DateTime.Now;
        }

        private void Carga_Prestamos()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Prestamos";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        DGPrestamos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los préstamos: " + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Cargar_Uuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT Id, Nombre, Apellido" +
                        " FROM USUARIOS" +
                        " ORDER BY Nombre , Apellido";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        tabla.Columns.Add(
                            "Nombre_Completo",
                            typeof(string)
                        );
                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["Nombre_Completo"] =
                                fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                        }

                        CBUsuario.DataSource = tabla;
                        CBUsuario.DisplayMember = "Nombre_Completo";
                        CBUsuario.ValueMember = "Id";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios: " + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void Cargar_Libros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT ISBN, Titulo" +
                        " FROM LIBROS" +
                        " ORDER BY Titulo";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        CBLibro.DataSource = tabla;
                        CBLibro.DisplayMember = "Titulo";
                        CBLibro.ValueMember = "ISBN";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios: " + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnNuevo_click(object sender, EventArgs e)
        {
            CBUsuario.SelectedIndex = -1;
            CBLibro.SelectedIndex = -1;

            DTPrestamo.Value = DateTime.Now;
            DTDevolucion.Value = DateTime.Now;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CBUsuario.SelectedIndex == -1 || CBLibro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un usuario y un libro antes de guardar.", "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int Id_usuario = Convert.ToInt32(CBUsuario.SelectedValue);
            string ISBN = CBLibro.SelectedValue.ToString();

            DateTime Fecha_Prestamo = DTPrestamo.Value;

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();
                string consulta_existencias = "SELECT Existencias FROM LIBROS WHERE ISBN = @ISBN";

                using (SqlCommand comando_existencias = new SqlCommand(consulta_existencias, cn))
                {
                    comando_existencias.Parameters.AddWithValue("@ISBN", ISBN);

                    int existencias = Convert.ToInt32(comando_existencias.ExecuteScalar());

                    if (existencias <= 0)
                    {
                        MessageBox.Show(
                            "No hay existencias disponibles para el libro seleccionado.", "Biblioteca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                }

                string consulta = @"
                    INSERT INTO PRESTAMOS
                        (Id_Usuario, ISBN, Fecha_Prestamo, Fecha_Devolucion , Estado)
                    VALUES 
                        (@Id_Usuario, @ISBN, @Fecha_Prestamo, NULL, 'Prestado')";
                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Id_Usuario", Id_usuario
                        );

                    comando.Parameters.AddWithValue(
                        "@ISBN", ISBN
                        );

                    comando.Parameters.AddWithValue(
                        "@Fecha_Prestamo", Fecha_Prestamo
                        );
                    comando.ExecuteNonQuery();
                }

                string Actualizar_Existencias =

                    "UPDATE LIBROS" +
                    " SET Existencias = Existencias - 1" +
                    " WHERE ISBN = @ISBN";
                using (SqlCommand comando_actualizar = new SqlCommand(Actualizar_Existencias, cn))
                {
                    comando_actualizar.Parameters.AddWithValue("@ISBN", ISBN);

                    int filas_afectadas = comando_actualizar.ExecuteNonQuery();

                    if (filas_afectadas == 0)
                    {
                        MessageBox.Show(
                            "Error al actualizar las existencias del libro.", "Biblioteca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }
            }
            MessageBox.Show(
                "Préstamo registrado correctamente.", "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Carga_Prestamos();

            BtnNuevo_click(null, null);
        }
        private void DGPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            CBUsuario.SelectedValue = Convert.ToInt32(DGPrestamos.Rows[e.RowIndex].Cells["Id_Usuario"].Value);
            CBLibro.SelectedValue = Convert.ToString(DGPrestamos.Rows[e.RowIndex].Cells["ISBN"].Value);
            DTPrestamo.Value = Convert.ToDateTime(DGPrestamos.Rows[e.RowIndex].Cells["Fecha_Prestamo"].Value);
            if (DGPrestamos.Rows[e.RowIndex].Cells["Fecha_Devolucion"].Value != DBNull.Value)
            {
                DTDevolucion.Value = Convert.ToDateTime(DGPrestamos.Rows[e.RowIndex].Cells["Fecha_Devolucion"].Value);
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPrestamos.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un préstamo para editar.", "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                int Id_Prestamo = Convert.ToInt32(DGPrestamos.CurrentRow.Cells["Id"].Value);
                string isbn = DGPrestamos.CurrentRow.Cells["ISBN"].Value.ToString();
                string estado = DGPrestamos.CurrentRow.Cells["Estado"].Value.ToString();

                if (estado == "Devuelto")
                {
                    MessageBox.Show(
                        "El préstamo ya ha sido devuelto", "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (!DTDevolucion.Checked)
                {
                    MessageBox.Show(
                        "Seleccione una fecha de devolución antes de guardar.", "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                DateTime fecha_devolucin = DTDevolucion.Value;

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de marcar el préstamo como devuelto?", "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"
                        UPDATE PRESTAMOS
                        SET Fecha_Devolucion = @Fecha_Devolucion,
                            Estado = 'Devuelto'
                        WHERE Id = @Id_Prestamo";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Fecha_Devolucion", fecha_devolucin);
                        comando.Parameters.AddWithValue("@Id_Prestamo", Id_Prestamo);
                        comando.ExecuteNonQuery();
                    }

                }

                MessageBox.Show(
                    "Préstamo marcado como devuelto correctamente.", "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Carga_Prestamos();
                BtnNuevo_click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al marcar el préstamo como devuelto: " + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CBUsuario.SelectedIndex = -1;
            CBLibro.SelectedIndex = -1;
            DTPrestamo.Value = DateTime.Now;
            DTDevolucion.Value = DateTime.Now;
            DTDevolucion.Checked = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGPrestamos.SelectedRows.Count == null)
                {
                    MessageBox.Show(
                        "Seleccione un prestamo para eliminar.", "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                int Id_Prestamo = Convert.ToInt32(DGPrestamos.CurrentRow.Cells["Id"].Value);

                string ISBN = DGPrestamos.CurrentRow.Cells["ISBN"].Value.ToString();
                string estado = DGPrestamos.CurrentRow.Cells["Estado"].Value.ToString();
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el préstamo seleccionado?", "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM PRESTAMOS WHERE Id = @Id_Prestamo";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Id_Prestamo", Id_Prestamo);
                        comando.ExecuteNonQuery();
                    }

                    if (estado == "Prestado")
                    {
                        string Actualizar_Existencias =
                            "UPDATE LIBROS" +
                            " SET Existencias = Existencias + 1" +
                            " WHERE ISBN = @ISBN";
                        using (SqlCommand comando_actualizar = new SqlCommand(Actualizar_Existencias, cn))
                        {
                            comando_actualizar.Parameters.AddWithValue("@ISBN", ISBN);
                            comando_actualizar.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show(
                    "Préstamo eliminado correctamente.", "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Carga_Prestamos();
                BtnNuevo_click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el préstamo: " + ex.Message, "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

