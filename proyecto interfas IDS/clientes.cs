/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 02:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of clientes.
	/// </summary>
	public partial class clientes : Form
	{
		public registros re;
		public clientes( registros re)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.re=re;
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""){
				funciones fu = new funciones();
				fu. Agregarcliente(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
				this.re.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El producto se agregó con exito ¿Desea agregar otro cliente?", "Nuevo cliente",
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
	}
}