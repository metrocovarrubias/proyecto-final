/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 05/06/2014
 * Time: 10:08 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of Agreempleado.
	/// </summary>
	public partial class Agreempleado : Form
	{
		public regempleados reg;
		public Agreempleado(regempleados reg)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.reg=reg;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void AgregaclienteClick(object sender, EventArgs e)
		{
			
			if(this.txtCodigo.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""){
				funciones fu = new funciones();
				fu. AgregarEmpleado(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
				this.reg.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El Empleado se agregó con exito ¿Desea agregar otro Empleado?", "Nuevo Empleado",
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
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
