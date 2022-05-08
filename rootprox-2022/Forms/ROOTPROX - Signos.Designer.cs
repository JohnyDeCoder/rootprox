
namespace rootprox_2022.Forms
{
    partial class ROOTPROX_Signos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignos = new System.Windows.Forms.Label();
            this.tabControlSignos = new System.Windows.Forms.TabControl();
            this.pageOpMath = new System.Windows.Forms.TabPage();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnParen2 = new System.Windows.Forms.Button();
            this.btnParen1 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.pageFunc = new System.Windows.Forms.TabPage();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnArcTan = new System.Windows.Forms.Button();
            this.btnArcCos = new System.Windows.Forms.Button();
            this.btnArcSen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlSignos.SuspendLayout();
            this.pageOpMath.SuspendLayout();
            this.pageFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSignos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 42);
            this.panel1.TabIndex = 1;
            // 
            // lblSignos
            // 
            this.lblSignos.AutoSize = true;
            this.lblSignos.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignos.Location = new System.Drawing.Point(12, 9);
            this.lblSignos.Name = "lblSignos";
            this.lblSignos.Size = new System.Drawing.Size(310, 24);
            this.lblSignos.TabIndex = 26;
            this.lblSignos.Text = "MAPA DE SÍMBOLOS MATEMÁTICOS";
            this.lblSignos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlSignos
            // 
            this.tabControlSignos.Controls.Add(this.pageOpMath);
            this.tabControlSignos.Controls.Add(this.pageFunc);
            this.tabControlSignos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSignos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSignos.Location = new System.Drawing.Point(0, 42);
            this.tabControlSignos.Name = "tabControlSignos";
            this.tabControlSignos.SelectedIndex = 0;
            this.tabControlSignos.ShowToolTips = true;
            this.tabControlSignos.Size = new System.Drawing.Size(384, 265);
            this.tabControlSignos.TabIndex = 2;
            // 
            // pageOpMath
            // 
            this.pageOpMath.Controls.Add(this.btnPow);
            this.pageOpMath.Controls.Add(this.btnParen2);
            this.pageOpMath.Controls.Add(this.btnParen1);
            this.pageOpMath.Controls.Add(this.btnRaiz);
            this.pageOpMath.Controls.Add(this.btnDivi);
            this.pageOpMath.Controls.Add(this.btnMulti);
            this.pageOpMath.Controls.Add(this.btnResta);
            this.pageOpMath.Controls.Add(this.btnSum);
            this.pageOpMath.Location = new System.Drawing.Point(4, 27);
            this.pageOpMath.Name = "pageOpMath";
            this.pageOpMath.Padding = new System.Windows.Forms.Padding(3);
            this.pageOpMath.Size = new System.Drawing.Size(376, 234);
            this.pageOpMath.TabIndex = 0;
            this.pageOpMath.Text = "Operadores Matemáticos";
            this.pageOpMath.ToolTipText = "Operadores matemáticos clásicos";
            this.pageOpMath.UseVisualStyleBackColor = true;
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(282, 82);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(86, 70);
            this.btnPow.TabIndex = 7;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnParen2
            // 
            this.btnParen2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParen2.Location = new System.Drawing.Point(190, 82);
            this.btnParen2.Name = "btnParen2";
            this.btnParen2.Size = new System.Drawing.Size(86, 70);
            this.btnParen2.TabIndex = 6;
            this.btnParen2.Text = ")";
            this.btnParen2.UseVisualStyleBackColor = true;
            this.btnParen2.Click += new System.EventHandler(this.btnParen2_Click);
            // 
            // btnParen1
            // 
            this.btnParen1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParen1.Location = new System.Drawing.Point(98, 82);
            this.btnParen1.Name = "btnParen1";
            this.btnParen1.Size = new System.Drawing.Size(86, 70);
            this.btnParen1.TabIndex = 5;
            this.btnParen1.Text = "(";
            this.btnParen1.UseVisualStyleBackColor = true;
            this.btnParen1.Click += new System.EventHandler(this.btnParen1_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(8, 82);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(86, 70);
            this.btnRaiz.TabIndex = 4;
            this.btnRaiz.Text = "√(x)";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(282, 6);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(86, 70);
            this.btnDivi.TabIndex = 3;
            this.btnDivi.Text = "÷";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(190, 6);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(86, 70);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(98, 6);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(86, 70);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "−";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(8, 6);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(86, 70);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // pageFunc
            // 
            this.pageFunc.BackColor = System.Drawing.Color.Transparent;
            this.pageFunc.Controls.Add(this.btnArcTan);
            this.pageFunc.Controls.Add(this.btnArcCos);
            this.pageFunc.Controls.Add(this.btnArcSen);
            this.pageFunc.Controls.Add(this.btnPi);
            this.pageFunc.Controls.Add(this.btnE);
            this.pageFunc.Controls.Add(this.btnLn);
            this.pageFunc.Controls.Add(this.btnLog);
            this.pageFunc.Controls.Add(this.btnTan);
            this.pageFunc.Controls.Add(this.btnCos);
            this.pageFunc.Controls.Add(this.btnSen);
            this.pageFunc.Location = new System.Drawing.Point(4, 27);
            this.pageFunc.Name = "pageFunc";
            this.pageFunc.Padding = new System.Windows.Forms.Padding(3);
            this.pageFunc.Size = new System.Drawing.Size(376, 234);
            this.pageFunc.TabIndex = 1;
            this.pageFunc.Text = "Funciones avanzadas";
            this.pageFunc.ToolTipText = "Funciones trigonométricas y otros símbolos";
            this.pageFunc.UseVisualStyleBackColor = true;
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(98, 158);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(86, 70);
            this.btnPi.TabIndex = 14;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(8, 158);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(86, 70);
            this.btnE.TabIndex = 13;
            this.btnE.Text = "ℯuler";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(282, 82);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(86, 70);
            this.btnLn.TabIndex = 12;
            this.btnLn.Text = "ln(x)";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(282, 6);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 70);
            this.btnLog.TabIndex = 11;
            this.btnLog.Text = "log(x)";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(190, 6);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(86, 70);
            this.btnTan.TabIndex = 10;
            this.btnTan.Text = "tan(x)";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(98, 6);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(86, 70);
            this.btnCos.TabIndex = 9;
            this.btnCos.Text = "cos(x)";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSen
            // 
            this.btnSen.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSen.Location = new System.Drawing.Point(8, 6);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(86, 70);
            this.btnSen.TabIndex = 8;
            this.btnSen.Text = "sin(x)";
            this.btnSen.UseVisualStyleBackColor = true;
            this.btnSen.Click += new System.EventHandler(this.btnSen_Click);
            // 
            // btnArcTan
            // 
            this.btnArcTan.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcTan.Location = new System.Drawing.Point(190, 82);
            this.btnArcTan.Name = "btnArcTan";
            this.btnArcTan.Size = new System.Drawing.Size(86, 70);
            this.btnArcTan.TabIndex = 17;
            this.btnArcTan.Text = "tan⁻¹(x)";
            this.btnArcTan.UseVisualStyleBackColor = true;
            this.btnArcTan.Click += new System.EventHandler(this.btnArcTan_Click);
            // 
            // btnArcCos
            // 
            this.btnArcCos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcCos.Location = new System.Drawing.Point(98, 82);
            this.btnArcCos.Name = "btnArcCos";
            this.btnArcCos.Size = new System.Drawing.Size(86, 70);
            this.btnArcCos.TabIndex = 16;
            this.btnArcCos.Text = "cos⁻¹(x)";
            this.btnArcCos.UseVisualStyleBackColor = true;
            this.btnArcCos.Click += new System.EventHandler(this.btnArcCos_Click);
            // 
            // btnArcSen
            // 
            this.btnArcSen.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcSen.Location = new System.Drawing.Point(8, 82);
            this.btnArcSen.Name = "btnArcSen";
            this.btnArcSen.Size = new System.Drawing.Size(86, 70);
            this.btnArcSen.TabIndex = 15;
            this.btnArcSen.Text = "sin⁻¹(x)";
            this.btnArcSen.UseVisualStyleBackColor = true;
            this.btnArcSen.Click += new System.EventHandler(this.btnArcSin_Click);
            // 
            // ROOTPROX_Signos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 307);
            this.Controls.Add(this.tabControlSignos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ROOTPROX_Signos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROOTPROX - Signos";
            this.Load += new System.EventHandler(this.ROOTPROX_Signos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlSignos.ResumeLayout(false);
            this.pageOpMath.ResumeLayout(false);
            this.pageFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlSignos;
        private System.Windows.Forms.TabPage pageOpMath;
        private System.Windows.Forms.TabPage pageFunc;
        private System.Windows.Forms.Label lblSignos;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnParen2;
        private System.Windows.Forms.Button btnParen1;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnArcTan;
        private System.Windows.Forms.Button btnArcCos;
        private System.Windows.Forms.Button btnArcSen;
    }
}