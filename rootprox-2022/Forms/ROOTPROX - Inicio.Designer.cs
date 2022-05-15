
namespace rootprox_2022
{
    partial class ROOTPROX_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROOTPROX_Inicio));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panelContainerLeft = new System.Windows.Forms.Panel();
            this.btnTags = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuTheme = new System.Windows.Forms.Panel();
            this.btnPurpleTheme = new FontAwesome.Sharp.IconButton();
            this.btnGreenTheme = new FontAwesome.Sharp.IconButton();
            this.btnRedTheme = new FontAwesome.Sharp.IconButton();
            this.btnBlueTheme = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnTheme = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnGuia = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuMethods = new System.Windows.Forms.Panel();
            this.btnReglaFalsa = new FontAwesome.Sharp.IconButton();
            this.btnSecante = new FontAwesome.Sharp.IconButton();
            this.btnBiseccion = new FontAwesome.Sharp.IconButton();
            this.btnMethods = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbxFormLogo = new System.Windows.Forms.PictureBox();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panelContainerLeft.SuspendLayout();
            this.panelSubMenuTheme.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelSubMenuMethods.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(208, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Rootprox.Properties.Resources.ROOTPROX_logo_blanco;
            this.pbxLogo.Location = new System.Drawing.Point(0, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(208, 91);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // panelContainerLeft
            // 
            this.panelContainerLeft.AutoScroll = true;
            this.panelContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            this.panelContainerLeft.Controls.Add(this.btnTags);
            this.panelContainerLeft.Controls.Add(this.panelSubMenuTheme);
            this.panelContainerLeft.Controls.Add(this.btnTheme);
            this.panelContainerLeft.Controls.Add(this.panelSubMenuHelp);
            this.panelContainerLeft.Controls.Add(this.btnAyuda);
            this.panelContainerLeft.Controls.Add(this.panelSubMenuMethods);
            this.panelContainerLeft.Controls.Add(this.btnMethods);
            this.panelContainerLeft.Controls.Add(this.btnExit);
            this.panelContainerLeft.Controls.Add(this.panelLogo);
            this.panelContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.panelContainerLeft.Name = "panelContainerLeft";
            this.panelContainerLeft.Size = new System.Drawing.Size(225, 561);
            this.panelContainerLeft.TabIndex = 2;
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.White;
            this.btnTags.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnTags.IconColor = System.Drawing.Color.White;
            this.btnTags.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTags.IconSize = 28;
            this.btnTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.Location = new System.Drawing.Point(0, 595);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(208, 45);
            this.btnTags.TabIndex = 21;
            this.btnTags.Text = "Lanzamientos";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // panelSubMenuTheme
            // 
            this.panelSubMenuTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuTheme.Controls.Add(this.btnPurpleTheme);
            this.panelSubMenuTheme.Controls.Add(this.btnGreenTheme);
            this.panelSubMenuTheme.Controls.Add(this.btnRedTheme);
            this.panelSubMenuTheme.Controls.Add(this.btnBlueTheme);
            this.panelSubMenuTheme.Controls.Add(this.iconButton2);
            this.panelSubMenuTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuTheme.Location = new System.Drawing.Point(0, 435);
            this.panelSubMenuTheme.Name = "panelSubMenuTheme";
            this.panelSubMenuTheme.Size = new System.Drawing.Size(208, 160);
            this.panelSubMenuTheme.TabIndex = 20;
            // 
            // btnPurpleTheme
            // 
            this.btnPurpleTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurpleTheme.FlatAppearance.BorderSize = 0;
            this.btnPurpleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurpleTheme.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurpleTheme.ForeColor = System.Drawing.Color.White;
            this.btnPurpleTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPurpleTheme.IconColor = System.Drawing.Color.White;
            this.btnPurpleTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPurpleTheme.IconSize = 28;
            this.btnPurpleTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurpleTheme.Location = new System.Drawing.Point(0, 120);
            this.btnPurpleTheme.Name = "btnPurpleTheme";
            this.btnPurpleTheme.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPurpleTheme.Size = new System.Drawing.Size(208, 40);
            this.btnPurpleTheme.TabIndex = 15;
            this.btnPurpleTheme.Text = "Morado";
            this.btnPurpleTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurpleTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurpleTheme.UseVisualStyleBackColor = true;
            this.btnPurpleTheme.Click += new System.EventHandler(this.btnPurpleTheme_Click);
            // 
            // btnGreenTheme
            // 
            this.btnGreenTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGreenTheme.FlatAppearance.BorderSize = 0;
            this.btnGreenTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreenTheme.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenTheme.ForeColor = System.Drawing.Color.White;
            this.btnGreenTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGreenTheme.IconColor = System.Drawing.Color.White;
            this.btnGreenTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGreenTheme.IconSize = 28;
            this.btnGreenTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenTheme.Location = new System.Drawing.Point(0, 80);
            this.btnGreenTheme.Name = "btnGreenTheme";
            this.btnGreenTheme.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGreenTheme.Size = new System.Drawing.Size(208, 40);
            this.btnGreenTheme.TabIndex = 14;
            this.btnGreenTheme.Text = "Verde";
            this.btnGreenTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreenTheme.UseVisualStyleBackColor = true;
            this.btnGreenTheme.Click += new System.EventHandler(this.btnGreenTheme_Click);
            // 
            // btnRedTheme
            // 
            this.btnRedTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRedTheme.FlatAppearance.BorderSize = 0;
            this.btnRedTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedTheme.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedTheme.ForeColor = System.Drawing.Color.White;
            this.btnRedTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRedTheme.IconColor = System.Drawing.Color.White;
            this.btnRedTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRedTheme.IconSize = 28;
            this.btnRedTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedTheme.Location = new System.Drawing.Point(0, 40);
            this.btnRedTheme.Name = "btnRedTheme";
            this.btnRedTheme.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRedTheme.Size = new System.Drawing.Size(208, 40);
            this.btnRedTheme.TabIndex = 13;
            this.btnRedTheme.Text = "Rojo";
            this.btnRedTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedTheme.UseVisualStyleBackColor = true;
            this.btnRedTheme.Click += new System.EventHandler(this.btnRedTheme_Click);
            // 
            // btnBlueTheme
            // 
            this.btnBlueTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlueTheme.FlatAppearance.BorderSize = 0;
            this.btnBlueTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTheme.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueTheme.ForeColor = System.Drawing.Color.White;
            this.btnBlueTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBlueTheme.IconColor = System.Drawing.Color.White;
            this.btnBlueTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBlueTheme.IconSize = 28;
            this.btnBlueTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueTheme.Location = new System.Drawing.Point(0, 0);
            this.btnBlueTheme.Name = "btnBlueTheme";
            this.btnBlueTheme.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBlueTheme.Size = new System.Drawing.Size(208, 40);
            this.btnBlueTheme.TabIndex = 12;
            this.btnBlueTheme.Text = "Azul";
            this.btnBlueTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlueTheme.UseVisualStyleBackColor = true;
            this.btnBlueTheme.Click += new System.EventHandler(this.btnBlueTheme_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(225, 40);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Guía de uso";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnTheme
            // 
            this.btnTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.btnTheme.IconColor = System.Drawing.Color.White;
            this.btnTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheme.IconSize = 28;
            this.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.Location = new System.Drawing.Point(0, 390);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTheme.Size = new System.Drawing.Size(208, 45);
            this.btnTheme.TabIndex = 19;
            this.btnTheme.Text = "Cambiar Tema";
            this.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuHelp.Controls.Add(this.btnAbout);
            this.panelSubMenuHelp.Controls.Add(this.btnGuia);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 310);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(208, 80);
            this.panelSubMenuHelp.TabIndex = 17;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 28;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 40);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(208, 40);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnGuia
            // 
            this.btnGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuia.FlatAppearance.BorderSize = 0;
            this.btnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuia.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuia.ForeColor = System.Drawing.Color.White;
            this.btnGuia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuia.IconColor = System.Drawing.Color.White;
            this.btnGuia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuia.IconSize = 28;
            this.btnGuia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.Location = new System.Drawing.Point(0, 0);
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGuia.Size = new System.Drawing.Size(208, 40);
            this.btnGuia.TabIndex = 11;
            this.btnGuia.Text = "Guía de uso";
            this.btnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuia.UseVisualStyleBackColor = true;
            this.btnGuia.Click += new System.EventHandler(this.btnGuia_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 28;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 265);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(208, 45);
            this.btnAyuda.TabIndex = 16;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // panelSubMenuMethods
            // 
            this.panelSubMenuMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuMethods.Controls.Add(this.btnReglaFalsa);
            this.panelSubMenuMethods.Controls.Add(this.btnSecante);
            this.panelSubMenuMethods.Controls.Add(this.btnBiseccion);
            this.panelSubMenuMethods.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMethods.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuMethods.Name = "panelSubMenuMethods";
            this.panelSubMenuMethods.Size = new System.Drawing.Size(208, 120);
            this.panelSubMenuMethods.TabIndex = 15;
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReglaFalsa.FlatAppearance.BorderSize = 0;
            this.btnReglaFalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglaFalsa.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglaFalsa.ForeColor = System.Drawing.Color.White;
            this.btnReglaFalsa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReglaFalsa.IconColor = System.Drawing.Color.White;
            this.btnReglaFalsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReglaFalsa.IconSize = 28;
            this.btnReglaFalsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglaFalsa.Location = new System.Drawing.Point(0, 80);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReglaFalsa.Size = new System.Drawing.Size(208, 40);
            this.btnReglaFalsa.TabIndex = 12;
            this.btnReglaFalsa.Text = "Regla Falsa";
            this.btnReglaFalsa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglaFalsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnReglaFalsa_Click);
            // 
            // btnSecante
            // 
            this.btnSecante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecante.FlatAppearance.BorderSize = 0;
            this.btnSecante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecante.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecante.ForeColor = System.Drawing.Color.White;
            this.btnSecante.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSecante.IconColor = System.Drawing.Color.White;
            this.btnSecante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSecante.IconSize = 28;
            this.btnSecante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecante.Location = new System.Drawing.Point(0, 40);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSecante.Size = new System.Drawing.Size(208, 40);
            this.btnSecante.TabIndex = 11;
            this.btnSecante.Text = "Secante";
            this.btnSecante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.btnSecante_Click);
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiseccion.FlatAppearance.BorderSize = 0;
            this.btnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiseccion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiseccion.ForeColor = System.Drawing.Color.White;
            this.btnBiseccion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBiseccion.IconColor = System.Drawing.Color.White;
            this.btnBiseccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBiseccion.IconSize = 28;
            this.btnBiseccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiseccion.Location = new System.Drawing.Point(0, 0);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBiseccion.Size = new System.Drawing.Size(208, 40);
            this.btnBiseccion.TabIndex = 10;
            this.btnBiseccion.Text = "Bisección";
            this.btnBiseccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiseccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnMethods
            // 
            this.btnMethods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMethods.FlatAppearance.BorderSize = 0;
            this.btnMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMethods.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethods.ForeColor = System.Drawing.Color.White;
            this.btnMethods.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnMethods.IconColor = System.Drawing.Color.White;
            this.btnMethods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMethods.IconSize = 28;
            this.btnMethods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMethods.Location = new System.Drawing.Point(0, 100);
            this.btnMethods.Name = "btnMethods";
            this.btnMethods.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMethods.Size = new System.Drawing.Size(208, 45);
            this.btnMethods.TabIndex = 14;
            this.btnMethods.Text = "Métodos";
            this.btnMethods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMethods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMethods.UseVisualStyleBackColor = true;
            this.btnMethods.Click += new System.EventHandler(this.btnMethods_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 28;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(208, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(211)))), ((int)(((byte)(251)))));
            this.panelForm.Controls.Add(this.lblVersion);
            this.panelForm.Controls.Add(this.pbxFormLogo);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(225, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(709, 561);
            this.panelForm.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.lblVersion.Location = new System.Drawing.Point(620, 542);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 19);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "v1.0.0-beta";
            // 
            // pbxFormLogo
            // 
            this.pbxFormLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxFormLogo.Image = global::Rootprox.Properties.Resources.ROOTPROX_logo_blanco;
            this.pbxFormLogo.Location = new System.Drawing.Point(0, 145);
            this.pbxFormLogo.Name = "pbxFormLogo";
            this.pbxFormLogo.Size = new System.Drawing.Size(709, 302);
            this.pbxFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFormLogo.TabIndex = 8;
            this.pbxFormLogo.TabStop = false;
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // ROOTPROX_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelContainerLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "ROOTPROX_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROOTPROX - Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ROOTPROX_Inicio_FormClosing);
            this.Load += new System.EventHandler(this.ROOTPROX_Inicio_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panelContainerLeft.ResumeLayout(false);
            this.panelSubMenuTheme.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelSubMenuMethods.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnBiseccion;
        private System.Windows.Forms.Panel panelContainerLeft;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelForm;
        private FontAwesome.Sharp.IconButton btnMethods;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnGuia;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private System.Windows.Forms.Panel panelSubMenuMethods;
        private FontAwesome.Sharp.IconButton btnReglaFalsa;
        private FontAwesome.Sharp.IconButton btnSecante;
        private FontAwesome.Sharp.IconButton btnTheme;
        private System.Windows.Forms.Panel panelSubMenuTheme;
        private FontAwesome.Sharp.IconButton btnBlueTheme;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnGreenTheme;
        private FontAwesome.Sharp.IconButton btnRedTheme;
        private FontAwesome.Sharp.IconButton btnPurpleTheme;
        private FontAwesome.Sharp.IconButton btnTags;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxFormLogo;
        private System.Windows.Forms.Timer tmrHoraFecha;
    }
}

