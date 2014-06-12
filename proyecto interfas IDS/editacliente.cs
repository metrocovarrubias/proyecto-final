/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 06/06/2014
 * Hora: 11:05 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of editacliente.
	/// </summary>
	public partial class editacliente : Form
	{
	    public registros re;
		public string id;
		public editacliente(registros re,string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.re=re;
			this.id=id;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void GuardarClick(object sender, EventArgs e)
		{
			if(this.codigo.Text.Trim()!="" && this.nombre.Text.Trim()!=""){
				funciones fu=new funciones();
				fu.editarCliente(this.id,this.codigo.Text.Trim(), this.nombre.Text.Trim());
				this.re.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			
		}
	}
		
		void EditaclienteLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			funciones fu = new funciones();
			registro=fu.obtenerPorIdCliente(this.id);
			this.codigo.Text =registro["codigo"].ToString();
			this.nombre.Text =registro["nombre"].ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
}
}
