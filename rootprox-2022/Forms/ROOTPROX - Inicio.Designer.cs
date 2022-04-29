
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnBiseccion = new FontAwesome.Sharp.IconButton();
            this.panelContainerLeft = new System.Windows.Forms.Panel();
            this.btnTags = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnGuia = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuMethods = new System.Windows.Forms.Panel();
            this.btnReglaFalsa = new FontAwesome.Sharp.IconButton();
            this.btnSecante = new FontAwesome.Sharp.IconButton();
            this.btnMethods = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelContainerLeft.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelSubMenuMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiseccion.FlatAppearance.BorderSize = 0;
            this.btnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiseccion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiseccion.ForeColor = System.Drawing.Color.White;
            this.btnBiseccion.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnBiseccion.IconColor = System.Drawing.Color.White;
            this.btnBiseccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBiseccion.IconSize = 28;
            this.btnBiseccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiseccion.Location = new System.Drawing.Point(0, 0);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBiseccion.Size = new System.Drawing.Size(225, 40);
            this.btnBiseccion.TabIndex = 10;
            this.btnBiseccion.Text = "Bisección";
            this.btnBiseccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiseccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // panelContainerLeft
            // 
            this.panelContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            this.panelContainerLeft.Controls.Add(this.btnTags);
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
            this.btnTags.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnTags.IconColor = System.Drawing.Color.White;
            this.btnTags.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTags.IconSize = 28;
            this.btnTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.Location = new System.Drawing.Point(0, 395);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(225, 45);
            this.btnTags.TabIndex = 18;
            this.btnTags.Text = "Lanzamientos";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuHelp.Controls.Add(this.btnAbout);
            this.panelSubMenuHelp.Controls.Add(this.btnGuia);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 314);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(225, 81);
            this.panelSubMenuHelp.TabIndex = 17;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 28;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 40);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(225, 40);
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
            this.btnGuia.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnGuia.IconColor = System.Drawing.Color.White;
            this.btnGuia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuia.IconSize = 28;
            this.btnGuia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.Location = new System.Drawing.Point(0, 0);
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGuia.Size = new System.Drawing.Size(225, 40);
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
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 28;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 269);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(225, 45);
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
            this.panelSubMenuMethods.Size = new System.Drawing.Size(225, 124);
            this.panelSubMenuMethods.TabIndex = 15;
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReglaFalsa.FlatAppearance.BorderSize = 0;
            this.btnReglaFalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReglaFalsa.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReglaFalsa.ForeColor = System.Drawing.Color.White;
            this.btnReglaFalsa.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnReglaFalsa.IconColor = System.Drawing.Color.White;
            this.btnReglaFalsa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReglaFalsa.IconSize = 28;
            this.btnReglaFalsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglaFalsa.Location = new System.Drawing.Point(0, 80);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReglaFalsa.Size = new System.Drawing.Size(225, 40);
            this.btnReglaFalsa.TabIndex = 12;
            this.btnReglaFalsa.Text = "Regla Falsa";
            this.btnReglaFalsa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglaFalsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnSustitucion_Click);
            // 
            // btnSecante
            // 
            this.btnSecante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecante.FlatAppearance.BorderSize = 0;
            this.btnSecante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecante.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecante.ForeColor = System.Drawing.Color.White;
            this.btnSecante.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnSecante.IconColor = System.Drawing.Color.White;
            this.btnSecante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSecante.IconSize = 28;
            this.btnSecante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecante.Location = new System.Drawing.Point(0, 40);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSecante.Size = new System.Drawing.Size(225, 40);
            this.btnSecante.TabIndex = 11;
            this.btnSecante.Text = "Secante";
            this.btnSecante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.btnSecante_Click);
            // 
            // btnMethods
            // 
            this.btnMethods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMethods.FlatAppearance.BorderSize = 0;
            this.btnMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMethods.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethods.ForeColor = System.Drawing.Color.White;
            this.btnMethods.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnMethods.IconColor = System.Drawing.Color.White;
            this.btnMethods.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMethods.IconSize = 28;
            this.btnMethods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMethods.Location = new System.Drawing.Point(0, 100);
            this.btnMethods.Name = "btnMethods";
            this.btnMethods.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMethods.Size = new System.Drawing.Size(225, 45);
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
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 28;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(225, 45);
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
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(225, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(709, 561);
            this.panelForm.TabIndex = 3;
            // 
            // ROOTPROX_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelContainerLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "ROOTPROX_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROOTPROX - Inicio";
            this.Load += new System.EventHandler(this.ROOTPROX_Inicio_Load);
            this.panelContainerLeft.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelSubMenuMethods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnBiseccion;
        private System.Windows.Forms.Panel panelContainerLeft;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelForm;
        private FontAwesome.Sharp.IconButton btnMethods;
        private FontAwesome.Sharp.IconButton btnTags;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnGuia;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private System.Windows.Forms.Panel panelSubMenuMethods;
        private FontAwesome.Sharp.IconButton btnReglaFalsa;
        private FontAwesome.Sharp.IconButton btnSecante;
    }
}

