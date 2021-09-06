namespace BeLife
{
    partial class VentanaCrearContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCrearContrato));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FecIniVig = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNumContrato = new System.Windows.Forms.Label();
            this.ComboPlan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboTitular = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RadioSi = new System.Windows.Forms.RadioButton();
            this.RadioNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblPrimaMensual = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblPrimaAnual = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.ComboPoliza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Contrato";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrear.Location = new System.Drawing.Point(295, 399);
            this.BtnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(122, 32);
            this.BtnCrear.TabIndex = 1;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio Vigencia                :";
            // 
            // FecIniVig
            // 
            this.FecIniVig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FecIniVig.Location = new System.Drawing.Point(218, 112);
            this.FecIniVig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FecIniVig.Name = "FecIniVig";
            this.FecIniVig.Size = new System.Drawing.Size(228, 20);
            this.FecIniVig.TabIndex = 3;
            this.FecIniVig.ValueChanged += new System.EventHandler(this.FecIniVig_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Contrato        :";
            // 
            // LblNumContrato
            // 
            this.LblNumContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNumContrato.AutoSize = true;
            this.LblNumContrato.Location = new System.Drawing.Point(216, 47);
            this.LblNumContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumContrato.Name = "LblNumContrato";
            this.LblNumContrato.Size = new System.Drawing.Size(19, 13);
            this.LblNumContrato.TabIndex = 7;
            this.LblNumContrato.Text = "----";
            // 
            // ComboPlan
            // 
            this.ComboPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlan.FormattingEnabled = true;
            this.ComboPlan.Location = new System.Drawing.Point(216, 150);
            this.ComboPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboPlan.Name = "ComboPlan";
            this.ComboPlan.Size = new System.Drawing.Size(228, 21);
            this.ComboPlan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plan                                :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Titular                             :";
            // 
            // ComboTitular
            // 
            this.ComboTitular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTitular.FormattingEnabled = true;
            this.ComboTitular.Location = new System.Drawing.Point(218, 78);
            this.ComboTitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboTitular.Name = "ComboTitular";
            this.ComboTitular.Size = new System.Drawing.Size(228, 21);
            this.ComboTitular.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Declaración de Salud     :";
            // 
            // RadioSi
            // 
            this.RadioSi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioSi.AutoSize = true;
            this.RadioSi.Location = new System.Drawing.Point(226, 229);
            this.RadioSi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioSi.Name = "RadioSi";
            this.RadioSi.Size = new System.Drawing.Size(35, 17);
            this.RadioSi.TabIndex = 13;
            this.RadioSi.TabStop = true;
            this.RadioSi.Text = "SI";
            this.RadioSi.UseVisualStyleBackColor = true;
            // 
            // RadioNo
            // 
            this.RadioNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioNo.AutoSize = true;
            this.RadioNo.Location = new System.Drawing.Point(352, 229);
            this.RadioNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioNo.Name = "RadioNo";
            this.RadioNo.Size = new System.Drawing.Size(41, 17);
            this.RadioNo.TabIndex = 14;
            this.RadioNo.TabStop = true;
            this.RadioNo.Text = "NO";
            this.RadioNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(216, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(217, 42);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtObservaciones.Location = new System.Drawing.Point(216, 274);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(233, 20);
            this.TxtObservaciones.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Observaciones                :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Póliza                             :";
            // 
            // LblPrimaMensual
            // 
            this.LblPrimaMensual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrimaMensual.AutoSize = true;
            this.LblPrimaMensual.Location = new System.Drawing.Point(223, 358);
            this.LblPrimaMensual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrimaMensual.Name = "LblPrimaMensual";
            this.LblPrimaMensual.Size = new System.Drawing.Size(19, 13);
            this.LblPrimaMensual.TabIndex = 21;
            this.LblPrimaMensual.Text = "----";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Prima Mensual               :";
            // 
            // LblPrimaAnual
            // 
            this.LblPrimaAnual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrimaAnual.AutoSize = true;
            this.LblPrimaAnual.Location = new System.Drawing.Point(223, 323);
            this.LblPrimaAnual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrimaAnual.Name = "LblPrimaAnual";
            this.LblPrimaAnual.Size = new System.Drawing.Size(19, 13);
            this.LblPrimaAnual.TabIndex = 23;
            this.LblPrimaAnual.Text = "----";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 320);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Prima Anual                    :";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.Location = new System.Drawing.Point(92, 399);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(119, 32);
            this.BtnVolver.TabIndex = 24;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // ComboPoliza
            // 
            this.ComboPoliza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPoliza.FormattingEnabled = true;
            this.ComboPoliza.Location = new System.Drawing.Point(216, 184);
            this.ComboPoliza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboPoliza.Name = "ComboPoliza";
            this.ComboPoliza.Size = new System.Drawing.Size(228, 21);
            this.ComboPoliza.TabIndex = 18;
            // 
            // VentanaCrearContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 455);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.LblPrimaAnual);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblPrimaMensual);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboPoliza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.RadioNo);
            this.Controls.Add(this.RadioSi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboTitular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboPlan);
            this.Controls.Add(this.LblNumContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FecIniVig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentanaCrearContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaCrearContrato";
            this.Load += new System.EventHandler(this.VentanaCrearContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FecIniVig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNumContrato;
        private System.Windows.Forms.ComboBox ComboPlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboTitular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RadioSi;
        private System.Windows.Forms.RadioButton RadioNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblPrimaMensual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblPrimaAnual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.ComboBox ComboPoliza;
    }
}