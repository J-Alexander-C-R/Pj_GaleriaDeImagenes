using GaleriaDeImagenes.Forms;

namespace GaleriaDeImagenes
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelMenu.Visible == true)
                panelMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMenu);
        }

        private void btnGaleriaImagenes_Click(object sender, EventArgs e)
        {
            AbriChildForm(new FrmGaleria());
            OcultarSubMenu();
        }

        


        private void btnInicio_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            if (activeform == null || activeform.IsDisposed)
                return;

            panelChildForm.Controls.Remove(activeform); // <-- quita solo el hijo
            activeform.Close();
            activeform = null; // limpia el panel

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private Form activeform = null!;
        private void AbriChildForm(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childform);
            panelChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
