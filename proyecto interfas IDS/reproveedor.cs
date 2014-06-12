/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 01/06/2014
 * Time: 07:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of proveedor.
	/// </summary>
	public partial class reproveedor : Form
	{
		public proveedores pro;
		public reproveedor(proveedores pro)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.pro=pro;
		}
		
		void AgregaclienteClick(object sender, EventArgs e)
		{
				if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""){
				funciones fu = new funciones();
				fu. Agregarproveedor(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
				this.pro.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El producto se agregó con exito ¿Desea agregar otro proveedor?", "Nuevo proveedor",
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
