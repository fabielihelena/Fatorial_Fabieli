namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Interativa = new System.Windows.Forms.Button();
            this.numeros = new System.Windows.Forms.TextBox();
            this.recursiva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Interativa
            // 
            this.Interativa.Location = new System.Drawing.Point(40, 73);
            this.Interativa.Name = "Interativa";
            this.Interativa.Size = new System.Drawing.Size(75, 23);
            this.Interativa.TabIndex = 0;
            this.Interativa.Text = "Iterativa";
            this.Interativa.UseVisualStyleBackColor = true;
            this.Interativa.Click += new System.EventHandler(this.Interativa_Click);
            // 
            // numeros
            // 
            this.numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros.Location = new System.Drawing.Point(12, 41);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(216, 26);
            this.numeros.TabIndex = 1;
            // 
            // recursiva
            // 
            this.recursiva.Location = new System.Drawing.Point(121, 73);
            this.recursiva.Name = "recursiva";
            this.recursiva.Size = new System.Drawing.Size(75, 23);
            this.recursiva.TabIndex = 2;
            this.recursiva.Text = "Recursiva";
            this.recursiva.UseVisualStyleBackColor = true;
            this.recursiva.Click += new System.EventHandler(this.Recursiva_click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.MinimumSize = new System.Drawing.Size(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recursiva);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.Interativa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fatorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Interativa;
        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.Button recursiva;
        private System.Windows.Forms.Label label1;
    }
}

