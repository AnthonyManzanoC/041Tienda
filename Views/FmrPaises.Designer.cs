namespace _041Tienda
{
    partial class FmrPaises
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre de Paises";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(219, 80);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_detalle.TabIndex = 14;
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.Location = new System.Drawing.Point(382, 62);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(156, 134);
            this.lstPaises.TabIndex = 13;
            this.lstPaises.DoubleClick += new System.EventHandler(this.lstPaises_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de Paises";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(463, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(382, 262);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(291, 262);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(210, 262);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 8;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // FmrPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_grabar);
            this.Name = "FmrPaises";
            this.Load += new System.EventHandler(this.FmrPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.ListBox lstPaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_grabar;
    }
}

