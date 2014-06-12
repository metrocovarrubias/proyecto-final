/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 06/06/2014
 * Hora: 11:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace proyecto_interfas_IDS
{
	partial class editaprovedor
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.codigo = new System.Windows.Forms.TextBox();
			this.nombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Guardar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// codigo
			// 
			this.codigo.Location = new System.Drawing.Point(43, 95);
			this.codigo.Name = "codigo";
			this.codigo.Size = new System.Drawing.Size(195, 20);
			this.codigo.TabIndex = 3;
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(43, 154);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(195, 20);
			this.nombre.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(115, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Editar";
			// 
			// Guardar
			// 
			this.Guardar.Location = new System.Drawing.Point(157, 206);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(100, 23);
			this.Guardar.TabIndex = 8;
			this.Guardar.Text = "Guardar Cambios";
			this.Guardar.UseVisualStyleBackColor = true;
			this.Guardar.Click += new System.EventHandler(this.GuardarClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(43, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// editaprovedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Guardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.codigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "editaprovedor";
			this.Text = "editaprovedor";
			this.Load += new System.EventHandler(this.EditaprovedorLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Guardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.TextBox codigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
