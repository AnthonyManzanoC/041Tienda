namespace _041Tienda.Views
{
    partial class fmr_Proveedores
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
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombreEmpresa = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lstProveedores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(472, 246);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(391, 246);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(300, 246);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(219, 246);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 12;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(219, 147);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 16;
            // 
            // txt_nombreEmpresa
            // 
            this.txt_nombreEmpresa.Location = new System.Drawing.Point(219, 90);
            this.txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            this.txt_nombreEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreEmpresa.TabIndex = 17;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(219, 203);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 18;
            // 
            // lstProveedores
            // 
            this.lstProveedores.FormattingEnabled = true;
            this.lstProveedores.Location = new System.Drawing.Point(427, 90);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(120, 95);
            this.lstProveedores.TabIndex = 19;
            this.lstProveedores.DoubleClick += new System.EventHandler(this.lstProveedores_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre de Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefono";
            // 
            // fmr_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombreEmpresa);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_grabar);
            this.Name = "fmr_Proveedores";
            this.Text = "fmr_Proveedores";
            this.Load += new System.EventHandler(this.fmr_Proveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombreEmpresa;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ListBox lstProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}