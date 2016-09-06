namespace DibujarFiguras
{
    partial class FabricaDeFiguras
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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numXi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numXf = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPx = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numOy = new System.Windows.Forms.NumericUpDown();
            this.numOx = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkInvertir = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblSust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOx)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Linea",
            "Circulo",
            "Elipse",
            "Parabola",
            "Hiperbola"});
            this.cboTipo.Location = new System.Drawing.Point(93, 6);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(271, 21);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.Text = "Linea";
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(38, 114);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(13, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Figura";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(57, 250);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(290, 55);
            this.btnGraficar.TabIndex = 13;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // numA
            // 
            this.numA.DecimalPlaces = 2;
            this.numA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numA.Location = new System.Drawing.Point(57, 60);
            this.numA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(98, 20);
            this.numA.TabIndex = 14;
            this.numA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // numB
            // 
            this.numB.DecimalPlaces = 2;
            this.numB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numB.Location = new System.Drawing.Point(57, 85);
            this.numB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(98, 20);
            this.numB.TabIndex = 15;
            this.numB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // numC
            // 
            this.numC.DecimalPlaces = 2;
            this.numC.Enabled = false;
            this.numC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numC.Location = new System.Drawing.Point(57, 111);
            this.numC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(98, 20);
            this.numC.TabIndex = 16;
            this.numC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numC.ValueChanged += new System.EventHandler(this.numC_ValueChanged);
            // 
            // numXi
            // 
            this.numXi.Location = new System.Drawing.Point(208, 60);
            this.numXi.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numXi.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.numXi.Name = "numXi";
            this.numXi.Size = new System.Drawing.Size(139, 20);
            this.numXi.TabIndex = 8;
            this.numXi.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numXi.ValueChanged += new System.EventHandler(this.numXi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X i";
            // 
            // numXf
            // 
            this.numXf.Location = new System.Drawing.Point(208, 86);
            this.numXf.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numXf.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.numXf.Name = "numXf";
            this.numXf.Size = new System.Drawing.Size(139, 20);
            this.numXf.TabIndex = 10;
            this.numXf.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numXf.ValueChanged += new System.EventHandler(this.numXf_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X f";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rango a graficar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pixeles/Unidad";
            // 
            // numPx
            // 
            this.numPx.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPx.Location = new System.Drawing.Point(400, 60);
            this.numPx.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPx.Name = "numPx";
            this.numPx.Size = new System.Drawing.Size(120, 20);
            this.numPx.TabIndex = 18;
            this.numPx.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPx.ValueChanged += new System.EventHandler(this.numPx_ValueChanged);
            // 
            // numR
            // 
            this.numR.Enabled = false;
            this.numR.Location = new System.Drawing.Point(57, 137);
            this.numR.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(98, 20);
            this.numR.TabIndex = 20;
            this.numR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numR.ValueChanged += new System.EventHandler(this.numR_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Radio";
            // 
            // numOy
            // 
            this.numOy.Location = new System.Drawing.Point(297, 134);
            this.numOy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numOy.Name = "numOy";
            this.numOy.Size = new System.Drawing.Size(50, 20);
            this.numOy.TabIndex = 24;
            this.numOy.ValueChanged += new System.EventHandler(this.numOy_ValueChanged);
            // 
            // numOx
            // 
            this.numOx.Location = new System.Drawing.Point(208, 134);
            this.numOx.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numOx.Name = "numOx";
            this.numOx.Size = new System.Drawing.Size(50, 20);
            this.numOx.TabIndex = 23;
            this.numOx.ValueChanged += new System.EventHandler(this.numOx_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Xo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Yo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Punto de Origen";
            // 
            // chkInvertir
            // 
            this.chkInvertir.AutoSize = true;
            this.chkInvertir.Location = new System.Drawing.Point(400, 89);
            this.chkInvertir.Name = "chkInvertir";
            this.chkInvertir.Size = new System.Drawing.Size(73, 17);
            this.chkInvertir.TabIndex = 26;
            this.chkInvertir.Text = "Graficar X";
            this.chkInvertir.UseVisualStyleBackColor = false;
            this.chkInvertir.CheckedChanged += new System.EventHandler(this.chkInvertir_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Variables";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(78, 177);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(168, 20);
            this.lblFormula.TabIndex = 28;
            this.lblFormula.Text = "Formula: Y = aX + b";
            // 
            // lblSust
            // 
            this.lblSust.AutoSize = true;
            this.lblSust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSust.Location = new System.Drawing.Point(53, 197);
            this.lblSust.Name = "lblSust";
            this.lblSust.Size = new System.Drawing.Size(193, 20);
            this.lblSust.TabIndex = 29;
            this.lblSust.Text = "Sustitución: Y = 1X + 1";
            // 
            // FabricaDeFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 317);
            this.Controls.Add(this.lblSust);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkInvertir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numOy);
            this.Controls.Add(this.numOx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numXf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numXi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipo);
            this.Name = "FabricaDeFiguras";
            this.Text = "FabricaDeFiguras";
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numXi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numXf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPx;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOy;
        private System.Windows.Forms.NumericUpDown numOx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkInvertir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblSust;
    }
}