
using System;

namespace mysqlConnect
{ 
	class Program
	{
		public static void Main (string[] args)
			{   
				
				int op=0;
			
				do{
					
				Console.WriteLine("		Selecciona Una Opcion Que Desea Realizar :");
				Console.WriteLine("1 :	Mostrar profesores Registrados ");
				Console.WriteLine("2 :	Agregar Nuevo profesor ");
				//
				/*Console.WriteLine("3)	Editar Codigo del profesor");
				Console.WriteLine("4)	Editar ID del profesor");
*/				
Console.WriteLine("3  :	Editar codigo y nombre del profesor que desea ");
				//
				Console.WriteLine("6  :  Eliminar profesor Registrado ");
				Console.WriteLine("7  :	Salir");
				
			
			
			    op=Convert.ToInt16(Console.ReadLine());
			    Console.Clear();
				profesor profesores1 = new profesor();
				switch(op){
							
			    case 1: 
				Console.WriteLine("Profesores registrados:");
				Console.WriteLine("\n");
				
			
				profesores1.mostrarTodosp();
				
				Console.WriteLine("\n");
			
				break;
					
				
				case 2:
				Console.WriteLine("Agregar profesor");
				profesores1.insertarRegistroNuevop();
				Console.WriteLine("\n "  );
				Console.WriteLine("Datos registrados:");
				break;
				 
				 
			    case 5:
				Console.WriteLine("Editar Codigo profesor");
			    profesores1.editarCodigoRegistrop();
				Console.WriteLine("\n "  );
				
				break;
				
				
				case 4:
				Console.WriteLine("Editar ID profesor");
			    profesores1.editarIdRegistrop();
			    Console.WriteLine("\n "  );
			    break;
					
				
				case 3:
				
				Console.WriteLine("Editar Nombre profesor por id");
				profesores1.editarNombreRegistrop();
				Console.WriteLine("\n "  );
				break;
				
				
			    case 6:
				Console.WriteLine("Eliminar profesor");
				profesores1.eliminarRegistroPorIdp();
				Console.WriteLine("\n "  );
			    break;
			    
			  
				}
				
				}while(op !=7);
			
			
		
			//Console.Read();
		}
	}
}