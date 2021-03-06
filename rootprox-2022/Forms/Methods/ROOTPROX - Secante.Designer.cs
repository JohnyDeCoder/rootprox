
namespace rootprox_2022.Forms
{
    partial class ROOTPROX_Secante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROOTPROX_Secante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ttipTxtBox = new System.Windows.Forms.ToolTip(this.components);
            this.numericRound = new System.Windows.Forms.NumericUpDown();
            this.txtFX = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtNmax = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblMODE = new System.Windows.Forms.Label();
            this.ttipBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSigns = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.ttipOptions = new System.Windows.Forms.ToolTip(this.components);
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbRedondear = new System.Windows.Forms.RadioButton();
            this.cbSinEA = new System.Windows.Forms.CheckBox();
            this.gbTipoResult = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblFX = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblNmax = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblCorchete1 = new System.Windows.Forms.Label();
            this.lblCorchete2 = new System.Windows.Forms.Label();
            this.lblPor100 = new System.Windows.Forms.Label();
            this.lblComa = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvResultAprox = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblMethodName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).BeginInit();
            this.gbTipoResult.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultAprox)).BeginInit();
            this.gbValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // ttipTxtBox
            // 
            this.ttipTxtBox.AutoPopDelay = 15000;
            this.ttipTxtBox.InitialDelay = 3000;
            this.ttipTxtBox.IsBalloon = true;
            this.ttipTxtBox.ReshowDelay = 100;
            this.ttipTxtBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipTxtBox.ToolTipTitle = "Ayuda con Campos de Texto";
            // 
            // numericRound
            // 
            this.numericRound.AutoSize = true;
            this.numericRound.Enabled = false;
            this.numericRound.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRound.Location = new System.Drawing.Point(99, 55);
            this.numericRound.Name = "numericRound";
            this.numericRound.Size = new System.Drawing.Size(52, 26);
            this.numericRound.TabIndex = 9;
            this.ttipTxtBox.SetToolTip(this.numericRound, resources.GetString("numericRound.ToolTip"));
            this.numericRound.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericRound.ValueChanged += new System.EventHandler(this.numericRound_ValueChanged);
            // 
            // txtFX
            // 
            this.txtFX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFX.Location = new System.Drawing.Point(79, 25);
            this.txtFX.Name = "txtFX";
            this.txtFX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFX.Size = new System.Drawing.Size(261, 36);
            this.txtFX.TabIndex = 0;
            this.txtFX.Text = "ℯ^(-x)-x";
            this.ttipTxtBox.SetToolTip(this.txtFX, "• Escriba la fórmula\r\n\r\n• Ejemplos:\r\n   • x^3-x-1\r\n   • (ℯ^x+1)/(√(x))\r\n   • (ℯ^x" +
        "^-x)/(ℯ^x^x^x)\r\n   • 1/2 + sin(π / 4) + (sin(3x)2 + cos(3x)2)\r\n");
            this.txtFX.TextChanged += new System.EventHandler(this.txtFX_TextChanged);
            this.txtFX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFX_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtA.Location = new System.Drawing.Point(95, 77);
            this.txtA.MaximumSize = new System.Drawing.Size(500, 36);
            this.txtA.MinimumSize = new System.Drawing.Size(130, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(130, 36);
            this.txtA.TabIndex = 4;
            this.txtA.Text = "0";
            this.ttipTxtBox.SetToolTip(this.txtA, "• Escriba el intérvalo b  → [a, b].\r\n\r\n• Información:\r\n   Recuerde que los valore" +
        "s del intérvalo\r\n   deben ser de distintos signos.");
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtB.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtB.Location = new System.Drawing.Point(327, 77);
            this.txtB.MaximumSize = new System.Drawing.Size(500, 4);
            this.txtB.MinimumSize = new System.Drawing.Size(130, 36);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(130, 36);
            this.txtB.TabIndex = 5;
            this.txtB.Text = "1";
            this.ttipTxtBox.SetToolTip(this.txtB, "• Escriba el intérvalo b  → [a, b].\r\n\r\n• Información:\r\n   Recuerde que los valore" +
        "s del intérvalo\r\n   deben ser de distintos signos.");
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtNmax
            // 
            this.txtNmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmax.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmax.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNmax.Location = new System.Drawing.Point(216, 124);
            this.txtNmax.Name = "txtNmax";
            this.txtNmax.Size = new System.Drawing.Size(143, 36);
            this.txtNmax.TabIndex = 6;
            this.txtNmax.Text = "20";
            this.ttipTxtBox.SetToolTip(this.txtNmax, resources.GetString("txtNmax.ToolTip"));
            this.txtNmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmax_KeyPress);
            // 
            // txtE
            // 
            this.txtE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtE.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtE.Location = new System.Drawing.Point(243, 172);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(155, 36);
            this.txtE.TabIndex = 7;
            this.txtE.Text = "0.01";
            this.ttipTxtBox.SetToolTip(this.txtE, resources.GetString("txtE.ToolTip"));
            this.txtE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtE_KeyPress);
            // 
            // lblMODE
            // 
            this.lblMODE.AutoSize = true;
            this.lblMODE.BackColor = System.Drawing.Color.Transparent;
            this.lblMODE.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMODE.Location = new System.Drawing.Point(81, 11);
            this.lblMODE.Name = "lblMODE";
            this.lblMODE.Size = new System.Drawing.Size(30, 16);
            this.lblMODE.TabIndex = 27;
            this.lblMODE.Text = "RAD";
            this.ttipTxtBox.SetToolTip(this.lblMODE, "Radianes\r\n\r\n• Información:\r\n   Calcula la función en RADIANES\r\n   ÚNICAMENTE si e" +
        "xiste una función \r\n   trigonométrica en el campo de texto.");
            this.lblMODE.Visible = false;
            // 
            // ttipBtn
            // 
            this.ttipBtn.AutoPopDelay = 15000;
            this.ttipBtn.InitialDelay = 3000;
            this.ttipBtn.IsBalloon = true;
            this.ttipBtn.ReshowDelay = 100;
            this.ttipBtn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipBtn.ToolTipTitle = "Ayuda con Botones";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 106);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calcular";
            this.ttipBtn.SetToolTip(this.btnCalculate, "Calcular\r\n\r\n• Función: \r\n   Calcula por el método seleccionado a partir de los \r\n" +
        "    valores que proporcione.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 63);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reiniciar";
            this.ttipBtn.SetToolTip(this.btnReset, "Reiniciar / Limpiar\r\n\r\n• Función: \r\n   Limpia todos los campos de texto y resulta" +
        "dos.\r\n");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSigns
            // 
            this.btnSigns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSigns.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigns.Location = new System.Drawing.Point(420, 25);
            this.btnSigns.Name = "btnSigns";
            this.btnSigns.Size = new System.Drawing.Size(74, 36);
            this.btnSigns.TabIndex = 3;
            this.btnSigns.Text = "Signos";
            this.ttipBtn.SetToolTip(this.btnSigns, resources.GetString("btnSigns.ToolTip"));
            this.btnSigns.UseVisualStyleBackColor = true;
            this.btnSigns.Click += new System.EventHandler(this.btnSigns_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEuler.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuler.Location = new System.Drawing.Point(346, 25);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Padding = new System.Windows.Forms.Padding(3, 0, 0, 4);
            this.btnEuler.Size = new System.Drawing.Size(32, 36);
            this.btnEuler.TabIndex = 1;
            this.btnEuler.Text = "ℯ";
            this.ttipBtn.SetToolTip(this.btnEuler, "Símbolo de Euler ℯ\r\n\r\n• Función: \r\n   Imprime ℯ al campo de la función.\r\n\r\n• Valo" +
        "r:\r\n    ℯ = 2.718281828\r\n\r\n• Aplicación:\r\n    ℯ^n ó ℯn");
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // btnPow
            // 
            this.btnPow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPow.Font = new System.Drawing.Font("Trebuchet MS", 20.25F);
            this.btnPow.Location = new System.Drawing.Point(384, 25);
            this.btnPow.Name = "btnPow";
            this.btnPow.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPow.Size = new System.Drawing.Size(30, 36);
            this.btnPow.TabIndex = 2;
            this.btnPow.Text = "^";
            this.ttipBtn.SetToolTip(this.btnPow, "Símbolo de Potencia\r\n\r\n• Función: \r\n   Imprime ^ al campo de la función.\r\n\r\n• Apl" +
        "icación:\r\n    a^b = aᵇ");
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // ttipOptions
            // 
            this.ttipOptions.AutoPopDelay = 15000;
            this.ttipOptions.InitialDelay = 3000;
            this.ttipOptions.IsBalloon = true;
            this.ttipOptions.ReshowDelay = 100;
            this.ttipOptions.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipOptions.ToolTipTitle = "Ayuda con Opciones";
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
            this.ttipOptions.SetToolTip(this.rbNormal, "Resultado sin alterar\r\n\r\n• Información:\r\n   No altera el resultado.");
            this.rbNormal.UseVisualStyleBackColor = true;
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
            this.ttipOptions.SetToolTip(this.rbRedondear, "Redondear a n decimales\r\n\r\n• Información:\r\n   Toma el número del cuadro de número" +
        "\r\n   de la derecha y redondea los valores.");
            this.rbRedondear.UseVisualStyleBackColor = true;
            this.rbRedondear.CheckedChanged += new System.EventHandler(this.rbRedondear_CheckedChanged);
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
            this.ttipOptions.SetToolTip(this.cbSinEA, resources.GetString("cbSinEA.ToolTip"));
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
            this.gbTipoResult.Size = new System.Drawing.Size(162, 95);
            this.gbTipoResult.TabIndex = 15;
            this.gbTipoResult.TabStop = false;
            this.gbTipoResult.Text = "Tipo de Resultado";
            // 
            // gbOptions
            // 
            this.gbOptions.AutoSize = true;
            this.gbOptions.Controls.Add(this.cbSinEA);
            this.gbOptions.Controls.Add(this.gbTipoResult);
            this.gbOptions.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(12, 193);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(179, 161);
            this.gbOptions.TabIndex = 28;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Opciones";
            // 
            // lblFX
            // 
            this.lblFX.AutoSize = true;
            this.lblFX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFX.Location = new System.Drawing.Point(6, 28);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(66, 28);
            this.lblFX.TabIndex = 5;
            this.lblFX.Text = "f(x) =";
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(37, 79);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(52, 28);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "X₀ =";
            // 
            // lblB
            // 
            this.lblB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(269, 79);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(52, 28);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "X₁ =";
            // 
            // lblNmax
            // 
            this.lblNmax.AutoSize = true;
            this.lblNmax.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmax.Location = new System.Drawing.Point(7, 130);
            this.lblNmax.Name = "lblNmax";
            this.lblNmax.Size = new System.Drawing.Size(203, 28);
            this.lblNmax.TabIndex = 14;
            this.lblNmax.Text = "Número máximo =";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.Location = new System.Drawing.Point(365, 130);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(127, 28);
            this.lblIteraciones.TabIndex = 15;
            this.lblIteraciones.Text = "iteraciones";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(6, 175);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(231, 28);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Factor de Paro  (εa) =";
            // 
            // lblCorchete1
            // 
            this.lblCorchete1.AutoSize = true;
            this.lblCorchete1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorchete1.Location = new System.Drawing.Point(6, 74);
            this.lblCorchete1.Name = "lblCorchete1";
            this.lblCorchete1.Size = new System.Drawing.Size(25, 34);
            this.lblCorchete1.TabIndex = 16;
            this.lblCorchete1.Text = "[";
            // 
            // lblCorchete2
            // 
            this.lblCorchete2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorchete2.AutoSize = true;
            this.lblCorchete2.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorchete2.Location = new System.Drawing.Point(463, 74);
            this.lblCorchete2.Name = "lblCorchete2";
            this.lblCorchete2.Size = new System.Drawing.Size(25, 34);
            this.lblCorchete2.TabIndex = 17;
            this.lblCorchete2.Text = "]";
            // 
            // lblPor100
            // 
            this.lblPor100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPor100.AutoSize = true;
            this.lblPor100.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor100.Location = new System.Drawing.Point(404, 175);
            this.lblPor100.Name = "lblPor100";
            this.lblPor100.Size = new System.Drawing.Size(90, 28);
            this.lblPor100.TabIndex = 13;
            this.lblPor100.Text = "× 100%";
            // 
            // lblComa
            // 
            this.lblComa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComa.AutoSize = true;
            this.lblComa.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComa.Location = new System.Drawing.Point(231, 80);
            this.lblComa.Name = "lblComa";
            this.lblComa.Size = new System.Drawing.Size(20, 32);
            this.lblComa.TabIndex = 18;
            this.lblComa.Text = ",";
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgvResultAprox);
            this.gbResult.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(6, 218);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(488, 89);
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
            this.dgvResultAprox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultAprox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultAprox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultAprox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResultAprox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultAprox.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResultAprox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultAprox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultAprox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultAprox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultAprox.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultAprox.EnableHeadersVisualStyles = false;
            this.dgvResultAprox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.dgvResultAprox.Location = new System.Drawing.Point(6, 19);
            this.dgvResultAprox.MultiSelect = false;
            this.dgvResultAprox.Name = "dgvResultAprox";
            this.dgvResultAprox.ReadOnly = true;
            this.dgvResultAprox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultAprox.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultAprox.RowHeadersVisible = false;
            this.dgvResultAprox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvResultAprox.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultAprox.Size = new System.Drawing.Size(476, 64);
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
            // gbValues
            // 
            this.gbValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbValues.Size = new System.Drawing.Size(500, 313);
            this.gbValues.TabIndex = 29;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Valores";
            // 
            // ea
            // 
            this.ea.HeaderText = "Error Relativo Aproximado";
            this.ea.Name = "ea";
            this.ea.ReadOnly = true;
            // 
            // xr
            // 
            this.xr.HeaderText = "Raíz Aproximada";
            this.xr.Name = "xr";
            this.xr.ReadOnly = true;
            // 
            // X1
            // 
            this.X1.HeaderText = "X₁";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            // 
            // X0
            // 
            this.X0.HeaderText = "X₀";
            this.X0.Name = "X0";
            this.X0.ReadOnly = true;
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
            this.dgvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.X0,
            this.X1,
            this.xr,
            this.ea});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.dgvResults.Location = new System.Drawing.Point(12, 360);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvResults.Size = new System.Drawing.Size(685, 189);
            this.dgvResults.TabIndex = 30;
            this.dgvResults.TabStop = false;
            // 
            // lblMethodName
            // 
            this.lblMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethodName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodName.Location = new System.Drawing.Point(316, 9);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(242, 29);
            this.lblMethodName.TabIndex = 31;
            this.lblMethodName.Text = "S  E  C  A  N  T  E";
            this.lblMethodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ROOTPROX_Secante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 561);
            this.Controls.Add(this.lblMethodName);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.gbValues);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ROOTPROX_Secante";
            this.Text = "ROOTPROX - Secante";
            this.Load += new System.EventHandler(this.ROOTPROX_Secante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).EndInit();
            this.gbTipoResult.ResumeLayout(false);
            this.gbTipoResult.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultAprox)).EndInit();
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttipTxtBox;
        private System.Windows.Forms.ToolTip ttipBtn;
        private System.Windows.Forms.ToolTip ttipOptions;
        private System.Windows.Forms.GroupBox gbTipoResult;
        private System.Windows.Forms.NumericUpDown numericRound;
        private System.Windows.Forms.RadioButton rbRedondear;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.CheckBox cbSinEA;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TextBox txtFX;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtNmax;
        private System.Windows.Forms.Label lblNmax;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCorchete1;
        private System.Windows.Forms.Label lblCorchete2;
        private System.Windows.Forms.Label lblPor100;
        private System.Windows.Forms.Label lblComa;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgvResultAprox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSigns;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Label lblMODE;
        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn ea;
        private System.Windows.Forms.DataGridViewTextBoxColumn xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblMethodName;
    }
}