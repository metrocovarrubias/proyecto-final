
/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 02:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class proveedores
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
			this.tablaprovedor = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.agregar = new System.Windows.Forms.Button();
			this.eliminar = new System.Windows.Forms.Button();
			this.edita = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tablaprovedor)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(66, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Existencia de Producto";
			// 
			// tablaprovedor
			// 
			this.tablaprovedor.AllowUserToAddRows = false;
			this.tablaprovedor.AllowUserToDeleteRows = false;
			this.tablaprovedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaprovedor.Location = new System.Drawing.Point(12, 71);
			this.tablaprovedor.Name = "tablaprovedor";
			this.tablaprovedor.ReadOnly = true;
			this.tablaprovedor.Size = new System.Drawing.Size(240, 150);
			this.tablaprovedor.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// agregar
			// 
			this.agregar.Location = new System.Drawing.Point(13, 36);
			this.agregar.Name = "agregar";
			this.agregar.Size = new System.Drawing.Size(114, 23);
			this.agregar.TabIndex = 3;
			this.agregar.Text = "Agregar Proveedor";
			this.agregar.UseVisualStyleBackColor = true;
			this.agregar.Click += new System.EventHandler(this.agregarClick);
			// 
			// eliminar
			// 
			this.eliminar.Location = new System.Drawing.Point(147, 226);
			this.eliminar.Name = "eliminar";
			this.eliminar.Size = new System.Drawing.Size(105, 23);
			this.eliminar.TabIndex = 4;
			this.eliminar.Text = "Eliminar Proveedor";
			this.eliminar.UseVisualStyleBackColor = true;
			this.eliminar.Click += new System.EventHandler(this.eliminarClick);
			// 
			// edita
			// 
			this.edita.Location = new System.Drawing.Point(147, 36);
			this.edita.Name = "edita";
			this.edita.Size = new System.Drawing.Size(105, 23);
			this.edita.TabIndex = 5;
			this.edita.Text = "Editar Provedor";
			this.edita.UseVisualStyleBackColor = true;
			this.edita.Click += new System.EventHandler(this.EditaClick);
			// 
			// proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.edita);
			this.Controls.Add(this.eliminar);
			this.Controls.Add(this.agregar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tablaprovedor);
			this.Controls.Add(this.label1);
			this.Name = "proveedores";
			this.Text = "proveedores";
			this.Load += new System.EventHandler(this.proveedoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.tablaprovedor)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button edita;
		private System.Windows.Forms.Button eliminar;
		private System.Windows.Forms.Button agregar;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView tablaprovedor;
		private System.Windows.Forms.Label label1;
	}
}
