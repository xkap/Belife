namespace BeLife
{
    partial class ListadoClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblRut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboSexo = new System.Windows.Forms.ComboBox();
            this.BtnFiltrarSexo = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboEstados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFiltrarEstado = new System.Windows.Forms.Button();
            this.BtnLista = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado De Clientes";
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 16;
            this.Lista.Location = new System.Drawing.Point(33, 50);
            this.Lista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(163, 244);
            this.Lista.TabIndex = 1;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(220, 121);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(160, 49);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar Cliente>>";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(639, 98);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(16, 20);
            this.LblNombre.TabIndex = 23;
            this.LblNombre.Text = "-";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(639, 222);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(16, 20);
            this.LblSexo.TabIndex = 20;
            this.LblSexo.Text = "-";
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.Location = new System.Drawing.Point(639, 69);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(16, 20);
            this.LblRut.TabIndex = 19;
            this.LblRut.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rut Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filtrar por Sexo:";
            // 
            // ComboSexo
            // 
            this.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSexo.FormattingEnabled = true;
            this.ComboSexo.Location = new System.Drawing.Point(36, 364);
            this.ComboSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboSexo.Name = "ComboSexo";
            this.ComboSexo.Size = new System.Drawing.Size(205, 24);
            this.ComboSexo.TabIndex = 27;
            // 
            // BtnFiltrarSexo
            // 
            this.BtnFiltrarSexo.Location = new System.Drawing.Point(60, 411);
            this.BtnFiltrarSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltrarSexo.Name = "BtnFiltrarSexo";
            this.BtnFiltrarSexo.Size = new System.Drawing.Size(104, 34);
            this.BtnFiltrarSexo.TabIndex = 29;
            this.BtnFiltrarSexo.Text = "Filtrar";
            this.BtnFiltrarSexo.UseVisualStyleBackColor = true;
            this.BtnFiltrarSexo.Click += new System.EventHandler(this.BtnFiltrarSexo_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(639, 252);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(16, 20);
            this.LblEstado.TabIndex = 24;
            this.LblEstado.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(408, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estado Civil";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(639, 134);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(16, 20);
            this.LblApellidos.TabIndex = 22;
            this.LblApellidos.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Apellidos";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(639, 177);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(16, 20);
            this.LblFecha.TabIndex = 21;
            this.LblFecha.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // ComboEstados
            // 
            this.ComboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstados.FormattingEnabled = true;
            this.ComboEstados.Location = new System.Drawing.Point(280, 364);
            this.ComboEstados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboEstados.Name = "ComboEstados";
            this.ComboEstados.Size = new System.Drawing.Size(205, 24);
            this.ComboEstados.TabIndex = 25;
            this.ComboEstados.SelectedIndexChanged += new System.EventHandler(this.ComboSexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filtrar por Estado Civil:";
            // 
            // BtnFiltrarEstado
            // 
            this.BtnFiltrarEstado.Location = new System.Drawing.Point(315, 411);
            this.BtnFiltrarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFiltrarEstado.Name = "BtnFiltrarEstado";
            this.BtnFiltrarEstado.Size = new System.Drawing.Size(104, 34);
            this.BtnFiltrarEstado.TabIndex = 30;
            this.BtnFiltrarEstado.Text = "Filtrar";
            this.BtnFiltrarEstado.UseVisualStyleBackColor = true;
            this.BtnFiltrarEstado.Click += new System.EventHandler(this.BtnFiltrarEstado_Click);
            // 
            // BtnLista
            // 
            this.BtnLista.Location = new System.Drawing.Point(220, 199);
            this.BtnLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLista.Name = "BtnLista";
            this.BtnLista.Size = new System.Drawing.Size(160, 49);
            this.BtnLista.TabIndex = 31;
            this.BtnLista.Text = "Lista Original";
            this.BtnLista.UseVisualStyleBackColor = true;
            this.BtnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(219, 57);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(160, 47);
            this.BtnVolver.TabIndex = 32;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 482);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnLista);
            this.Controls.Add(this.BtnFiltrarEstado);
            this.Controls.Add(this.BtnFiltrarSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboEstados);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblRut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoClientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboSexo;
        private System.Windows.Forms.Button BtnFiltrarSexo;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboEstados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrarEstado;
        private System.Windows.Forms.Button BtnLista;
        private System.Windows.Forms.Button BtnVolver;
    }
}