
namespace Grados_centigrados_a_fahrenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gradoscentigrados = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Centigrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Fahrenheit";
            // 
            // Gradoscentigrados
            // 
            this.Gradoscentigrados.Location = new System.Drawing.Point(169, 32);
            this.Gradoscentigrados.Name = "Gradoscentigrados";
            this.Gradoscentigrados.Size = new System.Drawing.Size(297, 27);
            this.Gradoscentigrados.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(169, 264);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(297, 27);
            this.Resultado.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Gradoscentigrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Convertir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Gradoscentigrados;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button button1;
    }
}

