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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            CargarTiposReportes();
        }

        private void CargarTiposReportes()
        {
            // Cargar los tipos de reportes en el ComboBox
            CBTiporeporte.Items.Clear();
            CBTiporeporte.Items.Add("Prestamos Activos");
            CBTiporeporte.Items.Add("Prestamos Devueltos");
            CBTiporeporte.Items.Add("Inventario de Libros");

            CBTiporeporte.SelectedIndex = -1;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBTiporeporte.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de reporte.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "";
                    switch (CBTiporeporte.SelectedItem.ToString())
                    {
                        case "Prestamos Activos":
                            consulta = @"SELECT 
                                            P.Id,
                                            U.Nombre + ' ' + U.Apellido AS Usuario,
                                            L.ISBN,
                                            L.TITULO,
                                            p.Fecha_Prestamo,
                                            P.Estado
                                          FROM PRESTAMOS P
                                          INNER JOIN USUARIOS U ON P.Id_Usuario = U.Id
                                          INNER JOIN LIBROS L ON P.ISBN = L.ISBN
                                          WHERE P.Estado = 'Prestado'
                                          ORDER BY P.Fecha_Prestamo DESC";
                            break;
                        case "Prestamos Devueltos":
                            consulta = @"SELECT 
                                            P.Id,
                                            U.Nombre + ' ' + U.Apellido AS Usuario,
                                            L.ISBN,
                                            L.TITULO,
                                            p.Fecha_Devolucion,
                                            P.Estado
                                          FROM PRESTAMOS P
                                          INNER JOIN USUARIOS U ON P.Id_Usuario = U.Id
                                          INNER JOIN LIBROS L ON P.ISBN = L.ISBN
                                          WHERE P.Estado = 'Devuelto'
                                          ORDER BY P.Fecha_Devolucion DESC";
                            break;
                        case "Inventario de Libros":
                            consulta = @"SELECT 
                                            L.ISBN,
                                            L.Titulo,
                                            A.Nombre +  ' ' + A.Apellido AS AUTOR,
                                            E.Nombre AS Editorial,
                                            L.Categoria,
                                            L.Existencias
                                          FROM LIBROS L
                                          INNER JOIN AUTORES A ON L.Id_Autores = A.Id
                                          INNER JOIN EDITORIALES E ON L.Id_Editorial = E.Id
                                          ORDER BY L.TITULO ";
                            break;
                    }
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        DGReporte.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte: " + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                  );
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CBTiporeporte.SelectedIndex = -1;
            DGReporte.DataSource = null;

        }
    }
}
