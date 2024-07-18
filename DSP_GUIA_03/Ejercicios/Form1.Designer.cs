namespace Ejercicios
{
    partial class Ordenar
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstDesorden = new System.Windows.Forms.ListBox();
            this.lstOrden = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(40, 56);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(86, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Ingresar numero:";
            this.lblnumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Location = new System.Drawing.Point(324, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Gold;
            this.btnOrdenar.Location = new System.Drawing.Point(324, 91);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(144, 53);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(114, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstDesorden
            // 
            this.lstDesorden.FormattingEnabled = true;
            this.lstDesorden.Location = new System.Drawing.Point(43, 199);
            this.lstDesorden.Name = "lstDesorden";
            this.lstDesorden.Size = new System.Drawing.Size(131, 121);
            this.lstDesorden.TabIndex = 4;
            // 
            // lstOrden
            // 
            this.lstOrden.FormattingEnabled = true;
            this.lstOrden.Location = new System.Drawing.Point(283, 199);
            this.lstOrden.Name = "lstOrden";
            this.lstOrden.Size = new System.Drawing.Size(131, 121);
            this.lstOrden.TabIndex = 5;
            // 
            // Ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 407);
            this.Controls.Add(this.lstOrden);
            this.Controls.Add(this.lstDesorden);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblnumero);
            this.Name = "Ordenar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ordenar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstDesorden;
        private System.Windows.Forms.ListBox lstOrden;
    }
}

