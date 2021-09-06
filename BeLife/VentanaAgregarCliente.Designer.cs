namespace BeLife
{
    partial class VentanaAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarCliente));
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblECivil = new System.Windows.Forms.Label();
            this.RadioViudo = new System.Windows.Forms.RadioButton();
            this.RadioCasado = new System.Windows.Forms.RadioButton();
            this.errorRut = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.RadiosSexo = new System.Windows.Forms.GroupBox();
            this.RadioDivorciado = new System.Windows.Forms.RadioButton();
            this.RadioSoltero = new System.Windows.Forms.RadioButton();
            this.RadiosEcivil = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            this.RadiosSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::BeLife.Properties.Resources.Arrow_sb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(272, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 62);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Volver";
            // 
            // TxtRut
            // 
            this.TxtRut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(204, 51);
            this.TxtRut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(356, 28);
            this.TxtRut.TabIndex = 1;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(204, 150);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(356, 28);
            this.TxtApellidos.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(204, 101);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(356, 28);
            this.TxtNombre.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(204, 200);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(356, 29);
            this.Fecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "RUT                 :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre           :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellidos         :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fec. Nacimiento   :";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRegistrar.Location = new System.Drawing.Point(204, 382);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(226, 63);
            this.BtnRegistrar.TabIndex = 21;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioM.Location = new System.Drawing.Point(12, 10);
            this.RadioM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(114, 28);
            this.RadioM.TabIndex = 22;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "Masculino";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioF.Location = new System.Drawing.Point(204, 11);
            this.RadioF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(115, 28);
            this.RadioF.TabIndex = 23;
            this.RadioF.TabStop = true;
            this.RadioF.Text = "Femenino";
            this.RadioF.UseVisualStyleBackColor = true;
            this.RadioF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LblSexo
            // 
            this.LblSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(26, 246);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(160, 24);
            this.LblSexo.TabIndex = 24;
            this.LblSexo.Text = "Sexo                :";
            // 
            // LblECivil
            // 
            this.LblECivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblECivil.AutoSize = true;
            this.LblECivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblECivil.Location = new System.Drawing.Point(26, 293);
            this.LblECivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblECivil.Name = "LblECivil";
            this.LblECivil.Size = new System.Drawing.Size(161, 24);
            this.LblECivil.TabIndex = 25;
            this.LblECivil.Text = "Estado Civil      :";
            // 
            // RadioViudo
            // 
            this.RadioViudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioViudo.AutoSize = true;
            this.RadioViudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioViudo.Location = new System.Drawing.Point(409, 338);
            this.RadioViudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioViudo.Name = "RadioViudo";
            this.RadioViudo.Size = new System.Drawing.Size(78, 28);
            this.RadioViudo.TabIndex = 27;
            this.RadioViudo.TabStop = true;
            this.RadioViudo.Text = "Viudo";
            this.RadioViudo.UseVisualStyleBackColor = true;
            // 
            // RadioCasado
            // 
            this.RadioCasado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioCasado.AutoSize = true;
            this.RadioCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCasado.Location = new System.Drawing.Point(409, 295);
            this.RadioCasado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioCasado.Name = "RadioCasado";
            this.RadioCasado.Size = new System.Drawing.Size(92, 28);
            this.RadioCasado.TabIndex = 29;
            this.RadioCasado.TabStop = true;
            this.RadioCasado.Text = "Casado";
            this.RadioCasado.UseVisualStyleBackColor = true;
            // 
            // errorRut
            // 
            this.errorRut.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellidos
            // 
            this.errorApellidos.ContainerControl = this;
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // RadiosSexo
            // 
            this.RadiosSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiosSexo.Controls.Add(this.RadioF);
            this.RadiosSexo.Controls.Add(this.RadioM);
            this.RadiosSexo.Location = new System.Drawing.Point(204, 236);
            this.RadiosSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosSexo.Name = "RadiosSexo";
            this.RadiosSexo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosSexo.Size = new System.Drawing.Size(333, 41);
            this.RadiosSexo.TabIndex = 5;
            this.RadiosSexo.TabStop = false;
            // 
            // RadioDivorciado
            // 
            this.RadioDivorciado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioDivorciado.AutoSize = true;
            this.RadioDivorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDivorciado.Location = new System.Drawing.Point(215, 338);
            this.RadioDivorciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioDivorciado.Name = "RadioDivorciado";
            this.RadioDivorciado.Size = new System.Drawing.Size(117, 28);
            this.RadioDivorciado.TabIndex = 26;
            this.RadioDivorciado.TabStop = true;
            this.RadioDivorciado.Text = "Divorciado";
            this.RadioDivorciado.UseVisualStyleBackColor = true;
            // 
            // RadioSoltero
            // 
            this.RadioSoltero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioSoltero.AutoSize = true;
            this.RadioSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioSoltero.Location = new System.Drawing.Point(215, 293);
            this.RadioSoltero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioSoltero.Name = "RadioSoltero";
            this.RadioSoltero.Size = new System.Drawing.Size(87, 28);
            this.RadioSoltero.TabIndex = 28;
            this.RadioSoltero.TabStop = true;
            this.RadioSoltero.Text = "Soltero";
            this.RadioSoltero.UseVisualStyleBackColor = true;
            // 
            // RadiosEcivil
            // 
            this.RadiosEcivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiosEcivil.Location = new System.Drawing.Point(204, 293);
            this.RadiosEcivil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosEcivil.Name = "RadiosEcivil";
            this.RadiosEcivil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiosEcivil.Size = new System.Drawing.Size(333, 84);
            this.RadiosEcivil.TabIndex = 6;
            this.RadiosEcivil.TabStop = false;
            this.RadiosEcivil.Text = "groupBox1";
            // 
            // VentanaAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 565);
            this.Controls.Add(this.RadioDivorciado);
            this.Controls.Add(this.RadioSoltero);
            this.Controls.Add(this.RadioCasado);
            this.Controls.Add(this.RadioViudo);
            this.Controls.Add(this.LblECivil);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadiosSexo);
            this.Controls.Add(this.RadiosEcivil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.VentanaAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            this.RadiosSexo.ResumeLayout(false);
            this.RadiosSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblECivil;
        private System.Windows.Forms.RadioButton RadioViudo;
        private System.Windows.Forms.RadioButton RadioCasado;
        private System.Windows.Forms.ErrorProvider errorRut;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellidos;
        private System.Windows.Forms.ErrorProvider errorFecha;
        private System.Windows.Forms.GroupBox RadiosSexo;
        private System.Windows.Forms.RadioButton RadioDivorciado;
        private System.Windows.Forms.RadioButton RadioSoltero;
        private System.Windows.Forms.GroupBox RadiosEcivil;
    }
}