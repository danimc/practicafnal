using MySql.Data.MySqlClient;
using System;
//cambiar el namespace por namespace mysqlConnect
	
namespace mysqlConnect
{ 

	public class profesor : MySQL
	{
		public profesor()
		{
		}
		
		//muestra los registros de la base de datos
		public void mostrarTodosp(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            Console.WriteLine("ID:" + id +
				                  "  Código:" + codigo + 
				                  "  Nombre:" + nombre);
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		
		public void insertarRegistroNuevop(){
			string  codigo, nombre;
			
			
			/*Console.WriteLine("Ingresa el ID :");
			id=Console.ReadLine();
			*/
			Console.WriteLine("Ingresa el Codigo :");
			codigo=Console.ReadLine();
			
			Console.WriteLine("Ingresa el Nombre :");
			nombre=Console.ReadLine();
			
			
			this.abrirConexion();
			string sql = "INSERT INTO `profesor` ( `codigo` , `nombre`) VALUES ('" + codigo + "', '" + nombre + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		//edita codigo por nombre
		public void editarCodigoRegistrop(){
			string codigo,nombre,nombre2;
			Console.WriteLine("Ingresa id del profesor a editar;");
			nombre=Console.ReadLine();
			Console.WriteLine("Ingresa Nuevo nombre del profesor;");
			nombre2=Console.ReadLine();
			if (nombre == null)
				return;
			Console.WriteLine("Ingresa el nuevo codigo:");
			codigo=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "UPDATE `profesor` SET `codigo`='" + codigo + "',`nombre`='" + nombre2 + "' WHERE (`nombre`='" + nombre + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		//edita id por nombre
		public void editarIdRegistrop(){
			string id,nombre;
			Console.WriteLine("Nombre del profesor:");
			nombre=Console.ReadLine();
			if (nombre == null)
				return;
			Console.WriteLine("Nuevo ID:");
			id=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "UPDATE `profesor` SET `id`='" + id + "' WHERE (`nombre`='" + nombre + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		
			
		//edita nombre por id
		public void editarNombreRegistrop(){
			string id,nombre,codigo;
			Console.WriteLine("Ingresa ID del profesor a editar;");
			id=Console.ReadLine();
			Console.WriteLine("ingresa el codigo nuevo:");
			codigo=Console.ReadLine();
			Console.WriteLine("Ingresa el nuevo nombre:");
			nombre=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "UPDATE `profesor` SET `codigo`='" + codigo + "',`nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		
		
		
		
		//elimina registro por id
		public void eliminarRegistroPorIdp(){
			string id;
			Console.WriteLine("Ingresa el ID del profesor a eliminar :");
			id=Console.ReadLine();
			
			this.abrirConexion();
			string sql = "DELETE FROM `profesor` WHERE (`id`='" + id + "')";
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
	           	"FROM profesor";
		}
		
		
		
	}
}
