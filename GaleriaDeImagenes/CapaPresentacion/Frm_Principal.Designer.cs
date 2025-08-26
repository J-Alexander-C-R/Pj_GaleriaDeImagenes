namespace GaleriaDeImagenes
{
    partial class Frm_Principal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            panelSideMenu = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
            panelMenu = new Panel();
            btnGaleriaImagenes = new Button();
            btnGaleria = new Button();
            btnInicio = new Button();
            panelLogo = new Panel();
            pictureBox8 = new PictureBox();
            panelChildForm = new Panel();
            panelFooter = new Panel();
            picLogo = new PictureBox();
            panelSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Controls.Add(panelMenu);
            panelSideMenu.Controls.Add(btnGaleria);
            panelSideMenu.Controls.Add(btnInicio);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 838);
            panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 708);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 130);
            panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 90);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 0, 0);
            btnExit.Size = new Size(250, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelMenu.Controls.Add(btnGaleriaImagenes);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 209);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 42);
            panelMenu.TabIndex = 3;
            // 
            // btnGaleriaImagenes
            // 
            btnGaleriaImagenes.Dock = DockStyle.Top;
            btnGaleriaImagenes.FlatAppearance.BorderSize = 0;
            btnGaleriaImagenes.FlatStyle = FlatStyle.Flat;
            btnGaleriaImagenes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGaleriaImagenes.ForeColor = Color.LightGray;
            btnGaleriaImagenes.Location = new Point(0, 0);
            btnGaleriaImagenes.Name = "btnGaleriaImagenes";
            btnGaleriaImagenes.Padding = new Padding(35, 0, 0, 0);
            btnGaleriaImagenes.Size = new Size(250, 40);
            btnGaleriaImagenes.TabIndex = 0;
            btnGaleriaImagenes.Text = "Galeria Imagenes";
            btnGaleriaImagenes.TextAlign = ContentAlignment.MiddleLeft;
            btnGaleriaImagenes.UseVisualStyleBackColor = true;
            btnGaleriaImagenes.Click += btnGaleriaImagenes_Click;
            // 
            // btnGaleria
            // 
            btnGaleria.Dock = DockStyle.Top;
            btnGaleria.FlatAppearance.BorderSize = 0;
            btnGaleria.FlatStyle = FlatStyle.Flat;
            btnGaleria.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGaleria.ForeColor = Color.Gainsboro;
            btnGaleria.Image = (Image)resources.GetObject("btnGaleria.Image");
            btnGaleria.ImageAlign = ContentAlignment.MiddleLeft;
            btnGaleria.Location = new Point(0, 169);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Padding = new Padding(10, 0, 0, 0);
            btnGaleria.Size = new Size(250, 40);
            btnGaleria.TabIndex = 2;
            btnGaleria.Text = "Galeria";
            btnGaleria.TextAlign = ContentAlignment.MiddleLeft;
            btnGaleria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGaleria.UseVisualStyleBackColor = true;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 129);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(10, 0, 0, 0);
            btnInicio.Size = new Size(250, 40);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox8);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 129);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Top;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(250, 129);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(panelFooter);
            panelChildForm.Controls.Add(picLogo);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1043, 838);
            panelChildForm.TabIndex = 1;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(23, 21, 32);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.ForeColor = SystemColors.ControlText;
            panelFooter.Location = new Point(0, 708);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1043, 130);
            panelFooter.TabIndex = 1;
            panelFooter.Paint += panelFooter_Paint;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = Color.FromArgb(32, 30, 45);
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(400, 241);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(257, 241);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 838);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LightGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            panelSideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panel1;
        private Panel panelMenu;
        private Button btnGaleriaImagenes;
        private Button btnGaleria;
        private Button btnInicio;
        private Panel panelLogo;
        private Panel panelChildForm;
        private PictureBox picLogo;
        private Panel panelFooter;
        private Button btnExit;
        private PictureBox pictureBox8;
    }
}
