namespace ejercicioTelegrama
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.RichTextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbOrdinario = new System.Windows.Forms.RadioButton();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(603, 434);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(223, 116);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(79, 29);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(221, 182);
            this.txtTelegrama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(592, 192);
            this.txtTelegrama.TabIndex = 2;
            this.txtTelegrama.Text = "";
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(192, 512);
            this.lblCoste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(95, 29);
            this.lblCoste.TabIndex = 4;
            this.lblCoste.Text = "Coste: ";
            this.lblCoste.Click += new System.EventHandler(this.lblCoste_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(319, 517);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // rbOrdinario
            // 
            this.rbOrdinario.AutoSize = true;
            this.rbOrdinario.Location = new System.Drawing.Point(221, 406);
            this.rbOrdinario.Name = "rbOrdinario";
            this.rbOrdinario.Size = new System.Drawing.Size(83, 20);
            this.rbOrdinario.TabIndex = 6;
            this.rbOrdinario.TabStop = true;
            this.rbOrdinario.Text = "Ordinario";
            this.rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(311, 406);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(76, 20);
            this.rbUrgente.TabIndex = 7;
            this.rbUrgente.TabStop = true;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 747);
            this.Controls.Add(this.rbUrgente);
            this.Controls.Add(this.rbOrdinario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RichTextBox txtTelegrama;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbOrdinario;
        private System.Windows.Forms.RadioButton rbUrgente;
    }
}

