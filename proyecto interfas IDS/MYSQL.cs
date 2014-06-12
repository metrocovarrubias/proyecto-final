/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 31/05/2014
 * Time: 09:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of MYSQL.
	/// </summary>
	public class MYSQL
	{
		public MySqlConnection myConnection;
		public MYSQL()
		{
		}
		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=proyectofinal;" +
	          	"User ID=root;" +
	          	"Password=metro;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}

}
