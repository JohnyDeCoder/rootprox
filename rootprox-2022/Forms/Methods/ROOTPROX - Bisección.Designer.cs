﻿
namespace rootprox_2022.Forms
{
    partial class ROOTPROX_Bisección
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.lblMODE = new System.Windows.Forms.Label();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnSigns = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvResultAprox = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComa = new System.Windows.Forms.Label();
            this.lblPor100 = new System.Windows.Forms.Label();
            this.lblCorchete2 = new System.Windows.Forms.Label();
            this.lblCorchete1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblNmax = new System.Windows.Forms.Label();
            this.txtNmax = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblFX = new System.Windows.Forms.Label();
            this.txtFX = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbSinEA = new System.Windows.Forms.CheckBox();
            this.gbTipoResult = new System.Windows.Forms.GroupBox();
            this.numericRound = new System.Windows.Forms.NumericUpDown();
            this.rbRedondear = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbValues.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultAprox)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.gbTipoResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gbValues
            // 
            this.gbValues.Controls.Add(this.lblMODE);
            this.gbValues.Controls.Add(this.btnPow);
            this.gbValues.Controls.Add(this.btnEuler);
            this.gbValues.Controls.Add(this.btnSigns);
            this.gbValues.Controls.Add(this.gbResult);
            this.gbValues.Controls.Add(this.lblComa);
            this.gbValues.Controls.Add(this.lblPor100);
            this.gbValues.Controls.Add(this.lblCorchete2);
            this.gbValues.Controls.Add(this.lblCorchete1);
            this.gbValues.Controls.Add(this.lblError);
            this.gbValues.Controls.Add(this.txtE);
            this.gbValues.Controls.Add(this.lblIteraciones);
            this.gbValues.Controls.Add(this.lblNmax);
            this.gbValues.Controls.Add(this.txtNmax);
            this.gbValues.Controls.Add(this.lblB);
            this.gbValues.Controls.Add(this.txtB);
            this.gbValues.Controls.Add(this.lblA);
            this.gbValues.Controls.Add(this.txtA);
            this.gbValues.Controls.Add(this.lblFX);
            this.gbValues.Controls.Add(this.txtFX);
            this.gbValues.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValues.Location = new System.Drawing.Point(197, 41);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(500, 297);
            this.gbValues.TabIndex = 16;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Valores";
            // 
            // lblMODE
            // 
            this.lblMODE.AutoSize = true;
            this.lblMODE.BackColor = System.Drawing.Color.Transparent;
            this.lblMODE.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMODE.Location = new System.Drawing.Point(81, 6);
            this.lblMODE.Name = "lblMODE";
            this.lblMODE.Size = new System.Drawing.Size(30, 16);
            this.lblMODE.TabIndex = 27;
            this.lblMODE.Text = "RAD";
            this.lblMODE.Visible = false;
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Trebuchet MS", 20.25F);
            this.btnPow.Location = new System.Drawing.Point(384, 20);
            this.btnPow.Name = "btnPow";
            this.btnPow.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPow.Size = new System.Drawing.Size(30, 36);
            this.btnPow.TabIndex = 2;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuler.Location = new System.Drawing.Point(346, 20);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Padding = new System.Windows.Forms.Padding(3, 0, 0, 4);
            this.btnEuler.Size = new System.Drawing.Size(32, 36);
            this.btnEuler.TabIndex = 1;
            this.btnEuler.Text = "ℯ";
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // btnSigns
            // 
            this.btnSigns.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigns.Location = new System.Drawing.Point(420, 20);
            this.btnSigns.Name = "btnSigns";
            this.btnSigns.Size = new System.Drawing.Size(74, 36);
            this.btnSigns.TabIndex = 3;
            this.btnSigns.Text = "Signos";
            this.btnSigns.UseVisualStyleBackColor = true;
            this.btnSigns.Click += new System.EventHandler(this.btnSigns_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.dgvResultAprox);
            this.gbResult.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(6, 209);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(488, 84);
            this.gbResult.TabIndex = 16;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultado";
            // 
            // dgvResultAprox
            // 
            this.dgvResultAprox.AllowUserToAddRows = false;
            this.dgvResultAprox.AllowUserToDeleteRows = false;
            this.dgvResultAprox.AllowUserToResizeColumns = false;
            this.dgvResultAprox.AllowUserToResizeRows = false;
            this.dgvResultAprox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultAprox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultAprox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultAprox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResultAprox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultAprox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResultAprox.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResultAprox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultAprox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvResultAprox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultAprox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvResultAprox.EnableHeadersVisualStyles = false;
            this.dgvResultAprox.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvResultAprox.Location = new System.Drawing.Point(6, 19);
            this.dgvResultAprox.MultiSelect = false;
            this.dgvResultAprox.Name = "dgvResultAprox";
            this.dgvResultAprox.ReadOnly = true;
            this.dgvResultAprox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultAprox.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvResultAprox.RowHeadersVisible = false;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvResultAprox.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvResultAprox.Size = new System.Drawing.Size(476, 59);
            this.dgvResultAprox.TabIndex = 18;
            this.dgvResultAprox.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Iteración";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 176;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Raíz Aproximada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Error Relativo Aproximado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblComa
            // 
            this.lblComa.AutoSize = true;
            this.lblComa.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComa.Location = new System.Drawing.Point(230, 74);
            this.lblComa.Name = "lblComa";
            this.lblComa.Size = new System.Drawing.Size(20, 32);
            this.lblComa.TabIndex = 18;
            this.lblComa.Text = ",";
            // 
            // lblPor100
            // 
            this.lblPor100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPor100.AutoSize = true;
            this.lblPor100.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor100.Location = new System.Drawing.Point(404, 170);
            this.lblPor100.Name = "lblPor100";
            this.lblPor100.Size = new System.Drawing.Size(90, 28);
            this.lblPor100.TabIndex = 13;
            this.lblPor100.Text = "× 100%";
            // 
            // lblCorchete2
            // 
            this.lblCorchete2.AutoSize = true;
            this.lblCorchete2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorchete2.Location = new System.Drawing.Point(467, 69);
            this.lblCorchete2.Name = "lblCorchete2";
            this.lblCorchete2.Size = new System.Drawing.Size(25, 34);
            this.lblCorchete2.TabIndex = 17;
            this.lblCorchete2.Text = "]";
            // 
            // lblCorchete1
            // 
            this.lblCorchete1.AutoSize = true;
            this.lblCorchete1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorchete1.Location = new System.Drawing.Point(6, 69);
            this.lblCorchete1.Name = "lblCorchete1";
            this.lblCorchete1.Size = new System.Drawing.Size(25, 34);
            this.lblCorchete1.TabIndex = 16;
            this.lblCorchete1.Text = "[";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(6, 170);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(231, 28);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Factor de Paro  (εa) =";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtE.Location = new System.Drawing.Point(243, 167);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(155, 36);
            this.txtE.TabIndex = 7;
            this.txtE.Text = "0.01";
            this.txtE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtE_KeyPress);
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.Location = new System.Drawing.Point(365, 125);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(127, 28);
            this.lblIteraciones.TabIndex = 15;
            this.lblIteraciones.Text = "iteraciones";
            // 
            // lblNmax
            // 
            this.lblNmax.AutoSize = true;
            this.lblNmax.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmax.Location = new System.Drawing.Point(7, 125);
            this.lblNmax.Name = "lblNmax";
            this.lblNmax.Size = new System.Drawing.Size(203, 28);
            this.lblNmax.TabIndex = 14;
            this.lblNmax.Text = "Número máximo =";
            // 
            // txtNmax
            // 
            this.txtNmax.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNmax.Location = new System.Drawing.Point(216, 119);
            this.txtNmax.Name = "txtNmax";
            this.txtNmax.Size = new System.Drawing.Size(143, 36);
            this.txtNmax.TabIndex = 6;
            this.txtNmax.Text = "20";
            this.txtNmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmax_KeyPress);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(269, 74);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(52, 28);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "X₁ =";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtB.Location = new System.Drawing.Point(327, 68);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(134, 36);
            this.txtB.TabIndex = 5;
            this.txtB.Text = "2";
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(37, 74);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(52, 28);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "X₀ =";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtA.Location = new System.Drawing.Point(95, 71);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(134, 36);
            this.txtA.TabIndex = 4;
            this.txtA.Text = "1";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // lblFX
            // 
            this.lblFX.AutoSize = true;
            this.lblFX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFX.Location = new System.Drawing.Point(6, 23);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(66, 28);
            this.lblFX.TabIndex = 5;
            this.lblFX.Text = "f(x) =";
            // 
            // txtFX
            // 
            this.txtFX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFX.Location = new System.Drawing.Point(79, 20);
            this.txtFX.Name = "txtFX";
            this.txtFX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFX.Size = new System.Drawing.Size(261, 36);
            this.txtFX.TabIndex = 0;
            this.txtFX.Text = "x^3-x-1";
            this.txtFX.TextChanged += new System.EventHandler(this.txtFX_TextChanged);
            this.txtFX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFX_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 63);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbSinEA);
            this.gbOptions.Controls.Add(this.gbTipoResult);
            this.gbOptions.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(12, 193);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(179, 145);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Opciones";
            // 
            // cbSinEA
            // 
            this.cbSinEA.AutoSize = true;
            this.cbSinEA.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSinEA.Location = new System.Drawing.Point(6, 19);
            this.cbSinEA.Name = "cbSinEA";
            this.cbSinEA.Size = new System.Drawing.Size(157, 22);
            this.cbSinEA.TabIndex = 11;
            this.cbSinEA.Text = "Sin Factor de Paroᴮᴱᵀᴬ";
            this.cbSinEA.UseVisualStyleBackColor = true;
            this.cbSinEA.CheckedChanged += new System.EventHandler(this.cbSinEA_CheckedChanged);
            // 
            // gbTipoResult
            // 
            this.gbTipoResult.Controls.Add(this.numericRound);
            this.gbTipoResult.Controls.Add(this.rbRedondear);
            this.gbTipoResult.Controls.Add(this.rbNormal);
            this.gbTipoResult.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoResult.Location = new System.Drawing.Point(6, 47);
            this.gbTipoResult.Name = "gbTipoResult";
            this.gbTipoResult.Size = new System.Drawing.Size(162, 92);
            this.gbTipoResult.TabIndex = 15;
            this.gbTipoResult.TabStop = false;
            this.gbTipoResult.Text = "Tipo de Resultado";
            // 
            // numericRound
            // 
            this.numericRound.Enabled = false;
            this.numericRound.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRound.Location = new System.Drawing.Point(99, 55);
            this.numericRound.Name = "numericRound";
            this.numericRound.Size = new System.Drawing.Size(50, 26);
            this.numericRound.TabIndex = 9;
            this.numericRound.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericRound.ValueChanged += new System.EventHandler(this.numericRound_ValueChanged);
            // 
            // rbRedondear
            // 
            this.rbRedondear.AutoSize = true;
            this.rbRedondear.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRedondear.Location = new System.Drawing.Point(6, 47);
            this.rbRedondear.Name = "rbRedondear";
            this.rbRedondear.Size = new System.Drawing.Size(87, 40);
            this.rbRedondear.TabIndex = 8;
            this.rbRedondear.Text = "Redondear\r\ndecimales";
            this.rbRedondear.UseVisualStyleBackColor = true;
            this.rbRedondear.CheckedChanged += new System.EventHandler(this.rbRedondear_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(6, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(67, 22);
            this.rbNormal.TabIndex = 10;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 106);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.X0,
            this.X1,
            this.xr,
            this.ea});
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvResults.Location = new System.Drawing.Point(12, 344);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvResults.Size = new System.Drawing.Size(685, 205);
            this.dgvResults.TabIndex = 17;
            this.dgvResults.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "B  I  S  E  C  C  I  Ó  N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iter
            // 
            this.iter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iter.Frozen = true;
            this.iter.HeaderText = "Iteración";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            this.iter.Width = 176;
            // 
            // X0
            // 
            this.X0.HeaderText = "X₀";
            this.X0.Name = "X0";
            this.X0.ReadOnly = true;
            // 
            // X1
            // 
            this.X1.HeaderText = "X₁";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            // 
            // xr
            // 
            this.xr.HeaderText = "Raíz Aproximada";
            this.xr.Name = "xr";
            this.xr.ReadOnly = true;
            // 
            // ea
            // 
            this.ea.HeaderText = "Error Relativo Aproximado";
            this.ea.Name = "ea";
            this.ea.ReadOnly = true;
            // 
            // ROOTPROX_Bisección
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.gbValues);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ROOTPROX_Bisección";
            this.Text = "ROOTPROX - Bisección";
            this.Load += new System.EventHandler(this.ROOTPROX_Bisección_Load);
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultAprox)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbTipoResult.ResumeLayout(false);
            this.gbTipoResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNmax;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblNmax;
        private System.Windows.Forms.Label lblPor100;
        private System.Windows.Forms.GroupBox gbTipoResult;
        private System.Windows.Forms.RadioButton rbRedondear;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label lblCorchete2;
        private System.Windows.Forms.Label lblCorchete1;
        private System.Windows.Forms.Label lblComa;
        private System.Windows.Forms.CheckBox cbSinEA;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgvResultAprox;
        private System.Windows.Forms.Button btnSigns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown numericRound;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFX;
        private System.Windows.Forms.Label lblMODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea;
    }
}