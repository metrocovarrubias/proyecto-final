/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 29/05/2014
 * Time: 01:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of registros.
	/// </summary>
	public partial class registros : Form
	{
		public MySqlCommand myCmdQuery;
		public MySqlDataAdapter myDataAdapter;
		public BindingSource myBindingSource;
		public MySqlCommandBuilder myCommandBuilder;
		public DataSet myDataSet;
		public MySqlConnection myConnection;
		public string myStringCon;
		public administrador adm;
		public registros(administrador adm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.adm=adm;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myDataSet=new DataSet();
			this.myStringCon=
				"Server=localhost;" +
				"Database=proyectofinal;" +
				"User ID=root;" +
				"Password=metro;" +
				"Pooling=false;";
			
			
		}
		
		void RegistrosLoad(object sender, EventArgs e)
		{
			//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM cliente";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"clientes");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="clientes";
			this.tablaclientes.DataSource=this.myBindingSource;
		}
		
		public void actualizarTabla(){
			try{
				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"clientes");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="clientes";
				this.tablaclientes.DataSource=this.myBindingSource;
				this.tablaclientes.Update();
				this.tablaclientes.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			clientes cli =new clientes(this);
			cli.Show();
		}
		
		
		
		
		
		void EliminarClick(object sender, EventArgs e)
		{
			if(this.tablaclientes.SelectedRows.Count>0){
				DataGridViewRow row = this.tablaclientes.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				string id = cell0.Value.ToString();
				string codigo = cell1.Value.ToString();
				string nombre = cell2.Value.ToString();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar Cliente con código " + codigo + "?", "Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == System.Windows.Forms.DialogResult.Yes){
				}
				funciones fu=new funciones();
				fu.eliminarCliente(id);
					//this.eliminarAlumno(id);
					this.actualizarTabla();
					MessageBox.Show("El Cliente con el código " + codigo + " fue eliminado con exito.");
				}
		}
		
		void EditarClick(object sender, EventArgs e)
		{
		
			if(this.tablaclientes.SelectedRows.Count>0){
				DataGridViewRow row = this.tablaclientes.SelectedRows[0];
				DataGridViewCell cell = row.Cells[0];
				string id = cell.Value.ToString();
				editacliente editac = new editacliente(this, id);
				editac.Show();
			
			}
		}
		
	/*	void Button3Click(object sender, EventArgs e)
		{
			this.Close()
		}*/
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
