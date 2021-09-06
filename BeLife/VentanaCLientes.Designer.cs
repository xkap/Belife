namespace BeLife
{
    partial class VentanaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnListadoClientes = new System.Windows.Forms.Button();
            this.btnVolverClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // BtnListadoClientes
            // 
            resources.ApplyResources(this.BtnListadoClientes, "BtnListadoClientes");
            this.BtnListadoClientes.BackgroundImage = global::BeLife.Properties.Resources.ListClient;
            this.BtnListadoClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnListadoClientes.Name = "BtnListadoClientes";
            this.BtnListadoClientes.UseVisualStyleBackColor = true;
            this.BtnListadoClientes.Click += new System.EventHandler(this.BtnListadoClientes_Click);
            // 
            // btnVolverClientes
            // 
            resources.ApplyResources(this.btnVolverClientes, "btnVolverClientes");
            this.btnVolverClientes.BackgroundImage = global::BeLife.Properties.Resources.Arrow_sb;
            this.btnVolverClientes.FlatAppearance.BorderSize = 0;
            this.btnVolverClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolverClientes.Name = "btnVolverClientes";
            this.btnVolverClientes.UseVisualStyleBackColor = true;
            this.btnVolverClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::BeLife.Properties.Resources.Logo_BeLifes_sin_fondo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnActualizarCliente
            // 
            resources.ApplyResources(this.btnActualizarCliente, "btnActualizarCliente");
            this.btnActualizarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientUpdate;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            resources.ApplyResources(this.btnBuscarCliente, "btnBuscarCliente");
            this.btnBuscarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientSearch;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            resources.ApplyResources(this.btnEliminarCliente, "btnEliminarCliente");
            this.btnEliminarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientDelete;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            resources.ApplyResources(this.btnAgregarCliente, "btnAgregarCliente");
            this.btnAgregarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientAdd;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // VentanaClientes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnListadoClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVolverClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaClientes";
            this.Load += new System.EventHandler(this.VentanaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolverClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnListadoClientes;
        private System.Windows.Forms.Label label6;
    }
}