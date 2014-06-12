/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 05/06/2014
 * Hora: 11:16 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of editaempleado.
	/// </summary>
	public partial class editaempleado : Form
	{
		public regempleados reg;
		public string id;
		public editaempleado(regempleados reg,string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.reg=reg;
			this.id=id;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
			{
			if(this.codigo.Text.Trim()!="" && this.nombre.Text.Trim()!=""){
				funciones fu=new funciones();
				fu.editarEmpleado(this.id,this.codigo.Text.Trim(), this.nombre.Text.Trim());
				this.reg.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}
		}
		
		
		void EditaempleadoLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			funciones fu = new funciones();
			registro=fu.obtenerPorId(this.id);
			this.codigo.Text =registro["codigo"].ToString();
			this.nombre.Text =registro["nombre"].ToString();
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
