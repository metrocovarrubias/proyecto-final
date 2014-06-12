/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 04/06/2014
 * Time: 01:09 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class regempleados
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
			this.Agregar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.editar = new System.Windows.Forms.Button();
			this.eliminar = new System.Windows.Forms.Button();
			this.regempleado = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.regempleado)).BeginInit();
			this.SuspendLayout();
			// 
			// Agregar
			// 
			this.Agregar.Location = new System.Drawing.Point(13, 27);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(116, 23);
			this.Agregar.TabIndex = 0;
			this.Agregar.Text = "Agregar Empleados";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.AgregarClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(34, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// editar
			// 
			this.editar.Location = new System.Drawing.Point(146, 27);
			this.editar.Name = "editar";
			this.editar.Size = new System.Drawing.Size(108, 23);
			this.editar.TabIndex = 2;
			this.editar.Text = "Editar";
			this.editar.UseVisualStyleBackColor = true;
			this.editar.Click += new System.EventHandler(this.EditarClick);
			// 
			// eliminar
			// 
			this.eliminar.Location = new System.Drawing.Point(146, 216);
			this.eliminar.Name = "eliminar";
			this.eliminar.Size = new System.Drawing.Size(108, 23);
			this.eliminar.TabIndex = 3;
			this.eliminar.Text = "Eliminar Regristro";
			this.eliminar.UseVisualStyleBackColor = true;
			this.eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// regempleado
			// 
			this.regempleado.AllowUserToAddRows = false;
			this.regempleado.AllowUserToDeleteRows = false;
			this.regempleado.Location = new System.Drawing.Point(12, 56);
			this.regempleado.Name = "regempleado";
			this.regempleado.ReadOnly = true;
			this.regempleado.Size = new System.Drawing.Size(240, 150);
			this.regempleado.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Empleados Existentes";
			// 
			// regempleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.regempleado);
			this.Controls.Add(this.eliminar);
			this.Controls.Add(this.editar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Agregar);
			this.Name = "regempleados";
			this.Text = "regempleados";
			this.Load += new System.EventHandler(this.RegempleadosLoad);
			((System.ComponentModel.ISupportInitialize)(this.regempleado)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView regempleado;
		private System.Windows.Forms.Button eliminar;
		private System.Windows.Forms.Button editar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Agregar;
		
		void ReempleadoCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
	}
}
