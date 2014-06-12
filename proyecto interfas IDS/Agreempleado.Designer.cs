/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 05/06/2014
 * Time: 10:08 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class Agreempleado
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
			this.agregaEmpleado = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// agregaEmpleado
			// 
			this.agregaEmpleado.Location = new System.Drawing.Point(172, 199);
			this.agregaEmpleado.Name = "agregaEmpleado";
			this.agregaEmpleado.Size = new System.Drawing.Size(75, 23);
			this.agregaEmpleado.TabIndex = 27;
			this.agregaEmpleado.Text = "Agregar";
			this.agregaEmpleado.UseVisualStyleBackColor = true;
			this.agregaEmpleado.Click += new System.EventHandler(this.AgregaclienteClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(66, 161);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(152, 20);
			this.txtNombre.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(66, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 25;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(66, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "Código";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(66, 107);
			this.txtCodigo.MaxLength = 10;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(152, 20);
			this.txtCodigo.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(102, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 22;
			this.label1.Text = "Nuevo Empleado\r\n";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(45, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Agreempleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.agregaEmpleado);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.Name = "Agreempleado";
			this.Text = "Agreempleado";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button agregaEmpleado;
	}
}
