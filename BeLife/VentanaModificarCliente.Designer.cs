namespace BeLife
{
    partial class VentanaModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaModificarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelResultados = new System.Windows.Forms.Panel();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.RadiosEcivil = new System.Windows.Forms.GroupBox();
            this.RadioViudo = new System.Windows.Forms.RadioButton();
            this.RadioDivorciado = new System.Windows.Forms.RadioButton();
            this.RadioCasado = new System.Windows.Forms.RadioButton();
            this.RadioSoltero = new System.Windows.Forms.RadioButton();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblRut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelPrincipal.SuspendLayout();
            this.PanelResultados.SuspendLayout();
            this.RadiosEcivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut";
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(94, 137);
            this.TxtRut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(251, 20);
            this.TxtRut.TabIndex = 2;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(14, 268);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(155, 34);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(214, 268);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(155, 34);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.label2);
            this.PanelPrincipal.Location = new System.Drawing.Point(10, 52);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(409, 429);
            this.PanelPrincipal.TabIndex = 5;
            // 
            // PanelResultados
            // 
            this.PanelResultados.Controls.Add(this.BtnAceptar);
            this.PanelResultados.Controls.Add(this.RadiosEcivil);
            this.PanelResultados.Controls.Add(this.Fecha);
            this.PanelResultados.Controls.Add(this.LblSexo);
            this.PanelResultados.Controls.Add(this.LblNombre);
            this.PanelResultados.Controls.Add(this.LblApellidos);
            this.PanelResultados.Controls.Add(this.LblRut);
            this.PanelResultados.Controls.Add(this.label9);
            this.PanelResultados.Controls.Add(this.label8);
            this.PanelResultados.Controls.Add(this.label7);
            this.PanelResultados.Controls.Add(this.label6);
            this.PanelResultados.Controls.Add(this.label5);
            this.PanelResultados.Controls.Add(this.label4);
            this.PanelResultados.Controls.Add(this.label3);
            this.PanelResultados.Location = new System.Drawing.Point(9, 53);
            this.PanelResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelResultados.Name = "PanelResultados";
            this.PanelResultados.Size = new System.Drawing.Size(404, 426);
            this.PanelResultados.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(128, 368);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(120, 31);
            this.BtnAceptar.TabIndex = 31;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // RadiosEcivil
            // 
            this.RadiosEcivil.Controls.Add(this.RadioViudo);
            this.RadiosEcivil.Controls.Add(this.RadioDivorciado);
            this.RadiosEcivil.Controls.Add(this.RadioCasado);
            this.RadiosEcivil.Controls.Add(this.RadioSoltero);
            this.RadiosEcivil.Location = new System.Drawing.Point(194, 237);
            this.RadiosEcivil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosEcivil.Name = "RadiosEcivil";
            this.RadiosEcivil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosEcivil.Size = new System.Drawing.Size(201, 82);
            this.RadiosEcivil.TabIndex = 30;
            this.RadiosEcivil.TabStop = false;
            // 
            // RadioViudo
            // 
            this.RadioViudo.AutoSize = true;
            this.RadioViudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioViudo.Location = new System.Drawing.Point(125, 58);
            this.RadioViudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioViudo.Name = "RadioViudo";
            this.RadioViudo.Size = new System.Drawing.Size(62, 21);
            this.RadioViudo.TabIndex = 32;
            this.RadioViudo.TabStop = true;
            this.RadioViudo.Text = "Viudo";
            this.RadioViudo.UseVisualStyleBackColor = true;
            // 
            // RadioDivorciado
            // 
            this.RadioDivorciado.AutoSize = true;
            this.RadioDivorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDivorciado.Location = new System.Drawing.Point(4, 58);
            this.RadioDivorciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioDivorciado.Name = "RadioDivorciado";
            this.RadioDivorciado.Size = new System.Drawing.Size(93, 21);
            this.RadioDivorciado.TabIndex = 31;
            this.RadioDivorciado.TabStop = true;
            this.RadioDivorciado.Text = "Divorciado";
            this.RadioDivorciado.UseVisualStyleBackColor = true;
            // 
            // RadioCasado
            // 
            this.RadioCasado.AutoSize = true;
            this.RadioCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCasado.Location = new System.Drawing.Point(125, 17);
            this.RadioCasado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioCasado.Name = "RadioCasado";
            this.RadioCasado.Size = new System.Drawing.Size(74, 21);
            this.RadioCasado.TabIndex = 34;
            this.RadioCasado.TabStop = true;
            this.RadioCasado.Text = "Casado";
            this.RadioCasado.UseVisualStyleBackColor = true;
            // 
            // RadioSoltero
            // 
            this.RadioSoltero.AutoSize = true;
            this.RadioSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioSoltero.Location = new System.Drawing.Point(4, 17);
            this.RadioSoltero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioSoltero.Name = "RadioSoltero";
            this.RadioSoltero.Size = new System.Drawing.Size(71, 21);
            this.RadioSoltero.TabIndex = 33;
            this.RadioSoltero.TabStop = true;
            this.RadioSoltero.Text = "Soltero";
            this.RadioSoltero.UseVisualStyleBackColor = true;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(202, 171);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 13;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(199, 207);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(23, 20);
            this.LblSexo.TabIndex = 12;
            this.LblSexo.Text = "\"\"";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(199, 95);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(23, 20);
            this.LblNombre.TabIndex = 11;
            this.LblNombre.Text = "\"\"";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(199, 141);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(23, 20);
            this.LblApellidos.TabIndex = 10;
            this.LblApellidos.Text = "\"\"";
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.Location = new System.Drawing.Point(200, 63);
            this.LblRut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(23, 20);
            this.LblRut.TabIndex = 7;
            this.LblRut.Text = "\"\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha De Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "El cliente se encuentra registrado y puede ser modificado";
            // 
            // VentanaModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 491);
            this.Controls.Add(this.PanelResultados);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentanaModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaModificarCliente";
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.PanelResultados.ResumeLayout(false);
            this.PanelResultados.PerformLayout();
            this.RadiosEcivil.ResumeLayout(false);
            this.RadiosEcivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelResultados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.GroupBox RadiosEcivil;
        private System.Windows.Forms.RadioButton RadioViudo;
        private System.Windows.Forms.RadioButton RadioDivorciado;
        private System.Windows.Forms.RadioButton RadioCasado;
        private System.Windows.Forms.RadioButton RadioSoltero;
        private System.Windows.Forms.Button BtnAceptar;
    }
}