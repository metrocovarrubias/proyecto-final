/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/04/2014
 * Time: 11:48 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_interfas_IDS
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Entrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.usuario = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// Entrar
			// 
			this.Entrar.Location = new System.Drawing.Point(180, 236);
			this.Entrar.Name = "Entrar";
			this.Entrar.Size = new System.Drawing.Size(75, 23);
			this.Entrar.TabIndex = 0;
			this.Entrar.Text = "Entrar ";
			this.Entrar.UseVisualStyleBackColor = true;
			this.Entrar.Click += new System.EventHandler(this.EntrarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(180, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = " Usuario";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(180, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "contraseñia";
			// 
			// usuario
			// 
			this.usuario.Location = new System.Drawing.Point(180, 44);
			this.usuario.Multiline = true;
			this.usuario.Name = "usuario";
			this.usuario.Size = new System.Drawing.Size(83, 20);
			this.usuario.TabIndex = 3;
			this.usuario.Click += new System.EventHandler(this.UsuarioClick);
			this.usuario.TextChanged += new System.EventHandler(this.UsuarioTextChanged);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(180, 157);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(83, 20);
			this.password.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(315, 294);
			this.Controls.Add(this.password);
			this.Controls.Add(this.usuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Entrar);
			this.Name = "MainForm";
			this.Text = "fraiche esencies";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox password;
		private System.Windows.Forms.TextBox usuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Entrar;
		
		void UsuarioClick(object sender, System.EventArgs e)
		{
			
		}
		
		void EntrarClick(object sender, System.EventArgs e)
		{
			if(this.usuario.Text=="adm" && this.password.Text=="123"){
				administrador ad= new administrador();
				ad.Show();
				this.Hide();
				}
			else if(this.usuario.Text=="mario" && this.password.Text=="metro"){
				usuarios us= new usuarios();
				us.Show();
				this.Hide();
				}
			
			else {
				System.Windows.Forms.MessageBox.Show("usuario incorrecto");
			}
			
	}
		
		void UsuarioTextChanged(object sender, System.EventArgs e)
		{
			
		}
  }
}