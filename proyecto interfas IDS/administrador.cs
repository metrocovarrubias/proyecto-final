/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 30/04/2014
 * Time: 11:04 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of administrador.
	/// </summary>
	public partial class administrador : Form
	{
		public administrador()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TabPage1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			registros re = new registros(this);
			re.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			inventario tario = new inventario(this);
			tario.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			proveedores pro = new proveedores(this);
			pro.Show();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			regempleados reg= new regempleados(this);
			reg.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
