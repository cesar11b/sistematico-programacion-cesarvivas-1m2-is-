namespace Sistematico1m2_is
{
    partial class FmrActivo
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
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.rtbMostrarInicial = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(42, 396);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.BtnNuevoProducto_Click);
            // 
            // rtbMostrarInicial
            // 
            this.rtbMostrarInicial.Location = new System.Drawing.Point(16, 57);
            this.rtbMostrarInicial.Name = "rtbMostrarInicial";
            this.rtbMostrarInicial.Size = new System.Drawing.Size(745, 333);
            this.rtbMostrarInicial.TabIndex = 4;
            this.rtbMostrarInicial.Text = "";
            this.rtbMostrarInicial.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // FmrActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMostrarInicial);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "FmrActivo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.RichTextBox rtbMostrarInicial;
    }
}

