namespace Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TrapezoideSimple = new System.Windows.Forms.Button();
            this.TrapezoideMultiple = new System.Windows.Forms.Button();
            this.SimpsonSimpleUnTercio = new System.Windows.Forms.Button();
            this.SimpsonMultipleUnTercio = new System.Windows.Forms.Button();
            this.SimpsonTresOctavos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisis Numerico";
            // 
            // TrapezoideSimple
            // 
            this.TrapezoideSimple.Location = new System.Drawing.Point(48, 100);
            this.TrapezoideSimple.Name = "TrapezoideSimple";
            this.TrapezoideSimple.Size = new System.Drawing.Size(136, 32);
            this.TrapezoideSimple.TabIndex = 1;
            this.TrapezoideSimple.Text = "Trapezoide Simple";
            this.TrapezoideSimple.UseVisualStyleBackColor = true;
            this.TrapezoideSimple.Click += new System.EventHandler(this.TrapezoideSimple_Click);
            // 
            // TrapezoideMultiple
            // 
            this.TrapezoideMultiple.Location = new System.Drawing.Point(48, 138);
            this.TrapezoideMultiple.Name = "TrapezoideMultiple";
            this.TrapezoideMultiple.Size = new System.Drawing.Size(136, 32);
            this.TrapezoideMultiple.TabIndex = 2;
            this.TrapezoideMultiple.Text = "Trapezoide Multiple";
            this.TrapezoideMultiple.UseVisualStyleBackColor = true;
            this.TrapezoideMultiple.Click += new System.EventHandler(this.TrapezoideMultiple_Click);
            // 
            // SimpsonSimpleUnTercio
            // 
            this.SimpsonSimpleUnTercio.Location = new System.Drawing.Point(48, 176);
            this.SimpsonSimpleUnTercio.Name = "SimpsonSimpleUnTercio";
            this.SimpsonSimpleUnTercio.Size = new System.Drawing.Size(136, 32);
            this.SimpsonSimpleUnTercio.TabIndex = 3;
            this.SimpsonSimpleUnTercio.Text = "Simpson 1/3 Simple";
            this.SimpsonSimpleUnTercio.UseVisualStyleBackColor = true;
            this.SimpsonSimpleUnTercio.Click += new System.EventHandler(this.SimpsonSimpleUnTercio_Click);
            // 
            // SimpsonMultipleUnTercio
            // 
            this.SimpsonMultipleUnTercio.Location = new System.Drawing.Point(48, 214);
            this.SimpsonMultipleUnTercio.Name = "SimpsonMultipleUnTercio";
            this.SimpsonMultipleUnTercio.Size = new System.Drawing.Size(136, 32);
            this.SimpsonMultipleUnTercio.TabIndex = 4;
            this.SimpsonMultipleUnTercio.Text = "Simpson 1/3 Multiple";
            this.SimpsonMultipleUnTercio.UseVisualStyleBackColor = true;
            this.SimpsonMultipleUnTercio.Click += new System.EventHandler(this.SimpsonMultipleUnTercio_Click);
            // 
            // SimpsonTresOctavos
            // 
            this.SimpsonTresOctavos.Location = new System.Drawing.Point(48, 252);
            this.SimpsonTresOctavos.Name = "SimpsonTresOctavos";
            this.SimpsonTresOctavos.Size = new System.Drawing.Size(136, 32);
            this.SimpsonTresOctavos.TabIndex = 5;
            this.SimpsonTresOctavos.Text = "Simpson 3/8";
            this.SimpsonTresOctavos.UseVisualStyleBackColor = true;
            this.SimpsonTresOctavos.Click += new System.EventHandler(this.SimpsonTresOctavos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 324);
            this.Controls.Add(this.SimpsonTresOctavos);
            this.Controls.Add(this.SimpsonMultipleUnTercio);
            this.Controls.Add(this.SimpsonSimpleUnTercio);
            this.Controls.Add(this.TrapezoideMultiple);
            this.Controls.Add(this.TrapezoideSimple);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TrapezoideSimple;
        private System.Windows.Forms.Button TrapezoideMultiple;
        private System.Windows.Forms.Button SimpsonSimpleUnTercio;
        private System.Windows.Forms.Button SimpsonMultipleUnTercio;
        private System.Windows.Forms.Button SimpsonTresOctavos;
    }
}

