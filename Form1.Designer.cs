namespace Ejercicio_7
{
    partial class fmrPesosADolares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPesosADolares));
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlBlanco = new System.Windows.Forms.Panel();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnOtraConversion = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.txtCantidadDolares = new System.Windows.Forms.TextBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVerde
            // 
            this.pnlVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlVerde.Location = new System.Drawing.Point(12, 12);
            this.pnlVerde.Name = "pnlVerde";
            this.pnlVerde.Size = new System.Drawing.Size(388, 53);
            this.pnlVerde.TabIndex = 0;
            // 
            // pnlBlanco
            // 
            this.pnlBlanco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBlanco.Location = new System.Drawing.Point(408, 12);
            this.pnlBlanco.Name = "pnlBlanco";
            this.pnlBlanco.Size = new System.Drawing.Size(388, 53);
            this.pnlBlanco.TabIndex = 1;
            // 
            // pnlRojo
            // 
            this.pnlRojo.BackColor = System.Drawing.Color.Red;
            this.pnlRojo.Location = new System.Drawing.Point(802, 12);
            this.pnlRojo.Name = "pnlRojo";
            this.pnlRojo.Size = new System.Drawing.Size(388, 53);
            this.pnlRojo.TabIndex = 2;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblError);
            this.gbDatos.Controls.Add(this.btnOtraConversion);
            this.gbDatos.Controls.Add(this.btnConversion);
            this.gbDatos.Controls.Add(this.txtCantidadDolares);
            this.gbDatos.Controls.Add(this.lblDolares);
            this.gbDatos.Controls.Add(this.lblPresentacion);
            this.gbDatos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbDatos.Location = new System.Drawing.Point(12, 82);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1178, 363);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(27, 275);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(58, 25);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            // 
            // btnOtraConversion
            // 
            this.btnOtraConversion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOtraConversion.Location = new System.Drawing.Point(739, 193);
            this.btnOtraConversion.Name = "btnOtraConversion";
            this.btnOtraConversion.Size = new System.Drawing.Size(399, 139);
            this.btnOtraConversion.TabIndex = 4;
            this.btnOtraConversion.Text = "Hacer otra conversion";
            this.btnOtraConversion.UseVisualStyleBackColor = true;
            // 
            // btnConversion
            // 
            this.btnConversion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConversion.Location = new System.Drawing.Point(739, 46);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(399, 141);
            this.btnConversion.TabIndex = 3;
            this.btnConversion.Text = "Hacer conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // txtCantidadDolares
            // 
            this.txtCantidadDolares.Location = new System.Drawing.Point(74, 178);
            this.txtCantidadDolares.Name = "txtCantidadDolares";
            this.txtCantidadDolares.Size = new System.Drawing.Size(511, 33);
            this.txtCantidadDolares.TabIndex = 2;
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(69, 150);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(282, 25);
            this.lblDolares.TabIndex = 1;
            this.lblDolares.Text = "Ingresa la cantidad de dolares:";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(27, 44);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(469, 25);
            this.lblPresentacion.TabIndex = 0;
            this.lblPresentacion.Text = "Este programa convierte dolares a pesos mexicanos";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.btnSalir);
            this.gbResultado.Controls.Add(this.txtResultado);
            this.gbResultado.Controls.Add(this.lblPesos);
            this.gbResultado.Controls.Add(this.lblResultado);
            this.gbResultado.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.gbResultado.Location = new System.Drawing.Point(12, 451);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(1178, 294);
            this.gbResultado.TabIndex = 4;
            this.gbResultado.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(915, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 139);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(425, 159);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(415, 35);
            this.txtResultado.TabIndex = 4;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(80, 159);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(318, 30);
            this.lblPesos.TabIndex = 3;
            this.lblPesos.Text = "Cantidad equivalente en pesos:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(39, 77);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(180, 30);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "La conversion es:";
            // 
            // fmrPesosADolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1202, 749);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.pnlRojo);
            this.Controls.Add(this.pnlBlanco);
            this.Controls.Add(this.pnlVerde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrPesosADolares";
            this.Text = "Conversion de dolares a pesos mexicanos";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerde;
        private System.Windows.Forms.Panel pnlBlanco;
        private System.Windows.Forms.Panel pnlRojo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnOtraConversion;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.TextBox txtCantidadDolares;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

