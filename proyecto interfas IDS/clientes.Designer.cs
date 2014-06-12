/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 02:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class clientes
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
			this.agregacliente = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.Salir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(102, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Nuevo Cliente";
			// 
			// agregacliente
			// 
			this.agregacliente.Location = new System.Drawing.Point(164, 189);
			this.agregacliente.Name = "agregacliente";
			this.agregacliente.Size = new System.Drawing.Size(75, 23);
			this.agregacliente.TabIndex = 21;
			this.agregacliente.Text = "Agregar";
			this.agregacliente.UseVisualStyleBackColor = true;
			this.agregacliente.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(66, 142);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(152, 20);
			this.txtNombre.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(66, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(66, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Código";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(66, 88);
			this.txtCodigo.MaxLength = 10;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(152, 20);
			this.txtCodigo.TabIndex = 17;
			// 
			// Salir
			// 
			this.Salir.Location = new System.Drawing.Point(44, 188);
			this.Salir.Name = "Salir";
			this.Salir.Size = new System.Drawing.Size(75, 23);
			this.Salir.TabIndex = 22;
			this.Salir.Text = "Salir";
			this.Salir.UseVisualStyleBackColor = true;
			this.Salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.Salir);
			this.Controls.Add(this.agregacliente);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.Name = "clientes";
			this.Text = "clientes";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Salir;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button agregacliente;
		private System.Windows.Forms.Label label3;
		
		void SalirClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
