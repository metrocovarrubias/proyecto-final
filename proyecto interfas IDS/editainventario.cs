/*
 * Creado por SharpDevelop.
 * Usuario: mario
 * Fecha: 06/06/2014
 * Hora: 12:01 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of editainventario.
	/// </summary>
	public partial class editainventario : Form
	{
		public inventario tario;
		public string id;
		public editainventario(inventario tario, string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.tario=tario;
			this.id=id;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void GuargarClick(object sender, EventArgs e)
		{
			if(this.codigo.Text.Trim()!="" && this.nombre.Text.Trim()!=""){
				funciones fu=new funciones();
				fu.editarInventario(this.id,this.codigo.Text.Trim(), this.nombre.Text.Trim());
				this.tario.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
