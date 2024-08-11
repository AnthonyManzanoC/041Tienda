namespace _041Tienda.Views
{
    partial class fmr_Clientes
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(485, 261);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(404, 261);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(313, 261);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(232, 261);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 16;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(404, 77);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(156, 147);
            this.lstClientes.TabIndex = 20;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            this.lstClientes.DoubleClick += new System.EventHandler(this.lstClientes_DoubleClick);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(232, 59);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(100, 20);
            this.txt_nombres.TabIndex = 21;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(232, 103);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidos.TabIndex = 22;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(232, 145);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 23;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(232, 192);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 24;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(232, 235);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lista de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nombres";
            // 
            // fmr_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_grabar);
            this.Name = "fmr_Clientes";
            this.Text = "fmr_Clientes";
            this.Load += new System.EventHandler(this.fmr_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}