namespace CapaPresentacion
{
    partial class Form1
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
            this.btnContactos = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnContactoPorTelefono = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactos
            // 
            this.btnContactos.Location = new System.Drawing.Point(128, 331);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(177, 75);
            this.btnContactos.TabIndex = 0;
            this.btnContactos.Text = "Todos Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(98, 100);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(572, 202);
            this.dgvDatos.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Lime;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(98, 29);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(572, 41);
            this.lblTexto.TabIndex = 2;
            // 
            // btnContactoPorTelefono
            // 
            this.btnContactoPorTelefono.Location = new System.Drawing.Point(360, 331);
            this.btnContactoPorTelefono.Name = "btnContactoPorTelefono";
            this.btnContactoPorTelefono.Size = new System.Drawing.Size(137, 75);
            this.btnContactoPorTelefono.TabIndex = 3;
            this.btnContactoPorTelefono.Text = "Contacto por teléfono";
            this.btnContactoPorTelefono.UseVisualStyleBackColor = true;
            this.btnContactoPorTelefono.Click += new System.EventHandler(this.btnContactoPorTelefono_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(397, 412);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(367, 415);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(24, 16);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "tel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnContactoPorTelefono);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnContactos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnContactoPorTelefono;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
    }
}

