using GaleriaDeImagenes.Forms;

namespace GaleriaDeImagenes
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            customizeDesign();
            // TODO: Inicializar la interfaz y ocultar submenús al inicio.
        }

        private void customizeDesign()
        {
            panelMenu.Visible = false;
            // TODO: Configuración inicial de diseño -> ocultar el panel del menú.
        }

        private void OcultarSubMenu()
        {
            if (panelMenu.Visible == true)
                panelMenu.Visible = false;
            // TODO: Método para ocultar el submenú si está visible.
        }

        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubMenu();
                // TODO: Antes de mostrar otro, oculta el que esté abierto.
                submenu.Visible = true;
                // TODO: Muestra el submenú seleccionado.
            }
            else
            {
                submenu.Visible = false;
                // TODO: Si ya está visible, lo oculta.
            }
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMenu);
            // TODO: Al presionar "Galería" se alterna el submenú correspondiente.
        }

        private void btnGaleriaImagenes_Click(object sender, EventArgs e)
        {
            AbriChildForm(new FrmGaleria());
            // TODO: Abre el formulario hijo "FrmGaleria" dentro del panel.
            OcultarSubMenu();
            // TODO: Después de abrir, oculta el submenú.
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            // TODO: Ocultar submenú al presionar inicio.

            if (activeform == null || activeform.IsDisposed)
                return; // TODO: Si no hay formulario activo, salir.

            panelChildForm.Controls.Remove(activeform);
            // TODO: Quita solo el formulario hijo del panel.
            activeform.Close();
            // TODO: Cierra el formulario hijo activo.
            activeform = null;
            // TODO: Limpia la referencia al formulario activo.
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            // TODO: Botón de información aún no implementado.
        }

        private Form activeform = null!;
        // TODO: Variable que almacena el formulario hijo activo.

        private void AbriChildForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            // TODO: Si ya hay un formulario abierto, se cierra.

            activeform = childform;
            // TODO: Actualiza el formulario activo.
            childform.TopLevel = false;
            // TODO: Hace que el formulario no sea independiente (se integra en el panel).
            childform.FormBorderStyle = FormBorderStyle.None;
            // TODO: Quita los bordes del formulario hijo.
            childform.Dock = DockStyle.Fill;
            // TODO: Ajusta el formulario al tamaño del panel contenedor.
            panelChildForm.Controls.Add(childform);
            // TODO: Inserta el formulario dentro del panel.
            panelChildForm.Tag = childform;
            // TODO: Guarda la referencia al formulario en el Tag del panel.
            childform.BringToFront();
            // TODO: Trae el formulario al frente.
            childform.Show();
            // TODO: Muestra el formulario hijo.
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            // TODO: Evento Paint del panel hijo (aún sin uso).
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // TODO: Cierra la aplicación al presionar el botón salir.
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
