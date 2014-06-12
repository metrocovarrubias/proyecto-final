/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 06/06/2014
 * Hora: 11:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of editaprovedor.
	/// </summary>
	public partial class editaprovedor : Form
	{
		public proveedores pro;
		public string id;
		public editaprovedor(proveedores pro,string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.pro=pro;
			this.id=id;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void GuardarClick(object sender, EventArgs e)
		{
				if(this.codigo.Text.Trim()!="" && this.nombre.Text.Trim()!=""){
				funciones fu=new funciones();
				fu.editarProvedor(this.id,this.codigo.Text.Trim(), this.nombre.Text.Trim());
				this.pro.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			
		}
		}
		
		void EditaprovedorLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			funciones fu = new funciones();
			registro=fu.obtenerPorIdProvedor(this.id);
			this.codigo.Text =registro["codigo"].ToString();
			this.nombre.Text =registro["nombre"].ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
