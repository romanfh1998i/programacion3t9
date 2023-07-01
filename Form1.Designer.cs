namespace Tarea9
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.nudPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(160, 245);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 32);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // nudPrecioProducto
            // 
            this.nudPrecioProducto.Location = new System.Drawing.Point(173, 157);
            this.nudPrecioProducto.Name = "nudPrecioProducto";
            this.nudPrecioProducto.Size = new System.Drawing.Size(125, 27);
            this.nudPrecioProducto.TabIndex = 2;
            this.nudPrecioProducto.Text = "0";
            this.nudPrecioProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudPrecioProducto_MouseClick);
            this.nudPrecioProducto.TextChanged += new System.EventHandler(this.nudPrecioProducto_TextChanged);
            this.nudPrecioProducto.Enter += new System.EventHandler(this.nudPrecioProducto_Enter);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(173, 97);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(125, 27);
            this.txtProducto.TabIndex = 3;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(40, 97);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(64, 20);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "Nombre";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(40, 164);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(50, 20);
            this.Precio.TabIndex = 5;
            this.Precio.Text = "Precio";
            this.Precio.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 372);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.nudPrecioProducto);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRegistrar;
        private TextBox nudPrecioProducto;
        private TextBox txtProducto;
        private Label nombre;
        private Label Precio;
    }
}