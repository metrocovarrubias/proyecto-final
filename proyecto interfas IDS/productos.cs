/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 02:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of productos.
	/// </summary>
	public partial class productos : Form
	{
		public inventario tario;
		public productos(inventario tario)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.tario=tario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""){
				funciones fu = new funciones();
				fu. Agregar(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
				this.tario.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El producto se agregó con exito ¿Desea agregar otro producto?", "Nuevo producto",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					this.txtCodigo.Clear();
					this.txtNombre.Clear();
					
		}
	}
}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}