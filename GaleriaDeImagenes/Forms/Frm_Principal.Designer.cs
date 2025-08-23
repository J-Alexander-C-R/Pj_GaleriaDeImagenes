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
            btnInfo = new Button();
            panelMenu = new Panel();
            btnGaleriaImagenes = new Button();
            btnGaleria = new Button();
            btnInicio = new Button();
            panelLogo = new Panel();
            panelChildForm = new Panel();
            panelFooter = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picLogo = new PictureBox();
            pictureBox8 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelChildForm.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Controls.Add(btnInfo);
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
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Top;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.Gainsboro;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(0, 251);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(5, 0, 0, 0);
            btnInfo.Size = new Size(250, 40);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Mas";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
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
            panelFooter.Controls.Add(pictureBox7);
            panelFooter.Controls.Add(pictureBox6);
            panelFooter.Controls.Add(pictureBox5);
            panelFooter.Controls.Add(pictureBox4);
            panelFooter.Controls.Add(label3);
            panelFooter.Controls.Add(label2);
            panelFooter.Controls.Add(panel3);
            panelFooter.Controls.Add(label1);
            panelFooter.Controls.Add(panel2);
            panelFooter.Controls.Add(pictureBox3);
            panelFooter.Controls.Add(pictureBox2);
            panelFooter.Controls.Add(pictureBox1);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.ForeColor = SystemColors.ControlText;
            panelFooter.Location = new Point(0, 708);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1043, 130);
            panelFooter.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(458, 33);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(262, 33);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(349, 33);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(400, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "00:00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(987, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "00:00";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(36, 33, 50);
            panel3.Location = new Point(58, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 5);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(774, 36);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 4;
            label1.Text = "0%";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(36, 33, 50);
            panel2.Location = new Point(568, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 5);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(538, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(499, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panelChildForm.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panel1;
        private Button btnInfo;
        private Panel panelMenu;
        private Button btnGaleriaImagenes;
        private Button btnGaleria;
        private Button btnInicio;
        private Panel panelLogo;
        private Panel panelChildForm;
        private PictureBox picLogo;
        private Panel panelFooter;
        private Button btnExit;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
    }
}
