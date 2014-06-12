/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 06/06/2014
 * Hora: 12:01 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_interfas_IDS
{
	partial class editainventario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Guargar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.codigo = new System.Windows.Forms.TextBox();
			this.nombre = new System.Windows.Forms.TextBox();
			this.Salir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Guargar
			// 
			this.Guargar.Location = new System.Drawing.Point(123, 188);
			this.Guargar.Name = "Guargar";
			this.Guargar.Size = new System.Drawing.Size(104, 23);
			this.Guargar.TabIndex = 0;
			this.Guargar.Text = "Guardar Cambios";
			this.Guargar.UseVisualStyleBackColor = true;
			this.Guargar.Click += new System.EventHandler(this.GuargarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// codigo
			// 
			this.codigo.Location = new System.Drawing.Point(50, 51);
			this.codigo.Name = "codigo";
			this.codigo.Size = new System.Drawing.Size(177, 20);
			this.codigo.TabIndex = 3;
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(50, 140);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(177, 20);
			this.nombre.TabIndex = 4;
			// 
			// Salir
			// 
			this.Salir.Location = new System.Drawing.Point(28, 187);
			this.Salir.Name = "Salir";
			this.Salir.Size = new System.Drawing.Size(75, 23);
			this.Salir.TabIndex = 5;
			this.Salir.Text = "Salir";
			this.Salir.UseVisualStyleBackColor = true;
			this.Salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// editainventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 232);
			this.Controls.Add(this.Salir);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.codigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Guargar);
			this.Name = "editainventario";
			this.Text = "editainventario";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Salir;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.TextBox codigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Guargar;
	}
}
