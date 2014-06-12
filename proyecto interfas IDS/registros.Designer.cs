/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 01:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class registros
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
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tablaclientes = new System.Windows.Forms.DataGridView();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Editar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(37, 271);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(86, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Salir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Clentes Registrados";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(304, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Agregar Cliente";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// tablaclientes
			// 
			this.tablaclientes.AllowUserToAddRows = false;
			this.tablaclientes.AllowUserToDeleteRows = false;
			this.tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaclientes.Location = new System.Drawing.Point(21, 34);
			this.tablaclientes.Name = "tablaclientes";
			this.tablaclientes.ReadOnly = true;
			this.tablaclientes.Size = new System.Drawing.Size(397, 207);
			this.tablaclientes.TabIndex = 8;
			// 
			// Eliminar
			// 
			this.Eliminar.Location = new System.Drawing.Point(271, 271);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(133, 23);
			this.Eliminar.TabIndex = 11;
			this.Eliminar.Text = "Eliminar Registros";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Editar
			// 
			this.Editar.Location = new System.Drawing.Point(162, 2);
			this.Editar.Name = "Editar";
			this.Editar.Size = new System.Drawing.Size(108, 23);
			this.Editar.TabIndex = 12;
			this.Editar.Text = "Editar Cliente";
			this.Editar.UseVisualStyleBackColor = true;
			this.Editar.Click += new System.EventHandler(this.EditarClick);
			// 
			// registros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 306);
			this.Controls.Add(this.Editar);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tablaclientes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Name = "registros";
			this.Text = "registros";
			this.Load += new System.EventHandler(this.RegistrosLoad);
			((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Editar;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.DataGridView tablaclientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		
		
	}
}
