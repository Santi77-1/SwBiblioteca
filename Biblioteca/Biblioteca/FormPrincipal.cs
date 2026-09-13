using Biblioteca.Datos;

namespace Biblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Open_Form(new FormInicio());// Abre el formulario de inicio al iniciar la aplicación
        }

        private void Open_Form(Form formulario)// Método para abrir un formulario dentro del panel PnlContenido
        {
            PnlContenido.Controls.Clear();// Limpia los controles existentes en el panel
            formulario.TopLevel = false;// Indica que el formulario no es de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None;// Elimina el borde del formulario
            formulario.Dock = DockStyle.Fill;// Hace que el formulario ocupe todo el espacio del panel
            PnlContenido.Controls.Add(formulario);// Agrega el formulario al panel
            formulario.Show();// Muestra el formulario
        }

        private void BtnInicio_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnInicio
        {
            Open_Form(new FormInicio());
        }

        private void BtnLibros_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnLibros
        {
            Open_Form(new FormLibros());
        }
        private void BtnUsuarios_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnUsuarios
        {
            Open_Form(new FormUsuarios());
        }
        private void BtnPrestamos_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnPrestamos
        {
            Open_Form(new FormPrestamos());
        }
        private void BtnAutores_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnAutores
        {
            Open_Form(new FormAutores());
        }
        private void BtnReportes_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnReportes
        {
            Open_Form(new FormReportes());
        }
        private void BtnEditoriales_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnEditoriales
        {
            Open_Form(new FormEditoriales());
        }
        private void BtnSalida_Click(object sender, EventArgs e)// Maneja el evento de clic del botón btnSalida
        {
            Application.Exit();// Cierra la aplicación
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
