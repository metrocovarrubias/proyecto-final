/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 31/05/2014
 * Time: 09:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace proyecto_interfas_IDS
{
	/// <summary>
	/// Description of funciones.
	/// </summary>
	public class funciones : MYSQL
	{
		
	    public string  id,codigo, nombre;
		public funciones()
		{
		}
		public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM empleado WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	//registro["id"] = myReader["id"].ToString();
	            registro["codigo"] = myReader["codigo"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		public Hashtable obtenerPorIdProvedor(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM proveedor WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	//registro["id"] = myReader["id"].ToString();
	            registro["codigo"] = myReader["codigo"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		
		public Hashtable obtenerPorIdCliente(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM cliente WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	//registro["id"] = myReader["id"].ToString();
	            registro["codigo"] = myReader["codigo"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		public Hashtable obtenerPorIdInventario(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM inventario WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	//registro["id"] = myReader["id"].ToString();
	            registro["codigo"] = myReader["codigo"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		
		
		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            Console.WriteLine("id: " + id +"\n"+" codigo: " + codigo +"\n"+" Nnmbre: " + nombre+"\n");
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
//para poner los datos en la base de datos		
public void Agregar(string codigo, string nombre){
	
this.abrirConexion();
string sql = "INSERT INTO inventario (codigo, nombre) VALUES ('" + codigo + "', '" + nombre + "')";
this.ejecutarComando(sql);
this.cerrarConexion();


}
public void Agregarcliente(string codigo, string nombre){
	
this.abrirConexion();
string sql = "INSERT INTO cliente (codigo, nombre) VALUES ('" + codigo + "', '" + nombre + "')";
this.ejecutarComando(sql);
this.cerrarConexion();


}
public void AgregarEmpleado(string codigo, string nombre){
	
this.abrirConexion();
string sql = "INSERT INTO empleado (codigo, nombre) VALUES ('" + codigo + "', '" + nombre + "')";
this.ejecutarComando(sql);
this.cerrarConexion();


}
public void Agregarproveedor(string codigo, string nombre){
	
this.abrirConexion();
string sql = "INSERT INTO proveedor (codigo, nombre) VALUES ('" + codigo + "', '" + nombre + "')";
this.ejecutarComando(sql);
this.cerrarConexion();
}
//para poner editar codigo
public void editarEmpleado(string id,string codigo,string nombre){
			this.abrirConexion();
			string sql = "UPDATE `empleado` SET `codigo`='" + codigo + "', `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
			
public void editarProvedor(string id,string codigo,string nombre){
			this.abrirConexion();
			string sql = "UPDATE `proveedor` SET `codigo`='" + codigo + "', `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
public void editarInventario(string id,string codigo,string nombre){
			this.abrirConexion();
			string sql = "UPDATE `inventario` SET `codigo`='" + codigo + "', `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
			
					
public void editarCliente(string id,string codigo,string nombre){
			this.abrirConexion();
			string sql = "UPDATE `cliente` SET `codigo`='" + codigo + "', `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
				
					
		public  void  eliminarRegistroPorid ( string id ) {
			this.abrirConexion ();
			string  sql  =  "DELETE FROM `inventario` WHERE (`ID`= '"  + id  +  "')" ;
			
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public  void  eliminarEmpleado ( string id ) {
			this.abrirConexion ();
			string  sql  =  "DELETE FROM `empleado` WHERE (`ID`= '"  + id  +  "')" ;
			
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public  void  eliminarCliente( string id ) {
			this.abrirConexion ();
			string  sql  =  "DELETE FROM `cliente` WHERE (`ID`= '"  + id  +  "')" ;
			
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public  void  eliminarproveedor ( string id ) {
			this.abrirConexion ();
			string  sql  =  "DELETE FROM `proveedor` WHERE (`ID`= '"  + id  +  "')" ;
			
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}

		private string querySelect(){
			return "SELECT * " +
	           	"FROM proyectofinal";
		}

	}
	}

