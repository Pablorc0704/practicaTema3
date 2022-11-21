
namespace PracticaGitHub._1
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(183, 128);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(186, 159);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(395, 112);
            this.txtTelegrama.TabIndex = 1;
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(186, 297);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(70, 17);
            this.cbUrgente.TabIndex = 2;
            this.cbUrgente.Text = "Urgente?";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(186, 350);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(34, 13);
            this.lblCoste.TabIndex = 3;
            this.lblCoste.Text = "Coste";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(484, 332);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(226, 347);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.cbUrgente);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

