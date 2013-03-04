using System;

namespace Agenda
{
	 public class Agenda
	{
		private string nombre;
		private string apellido;
		private int telefono;

		public Agenda(){
		}


		public static void Main (string[] args)
		{
			Agenda agenda = new Agenda ();
			Console.WriteLine ("Dame tu nombre");
			agenda.nombre=Console.ReadLine ();
			Console.WriteLine ("Dame tu Apellido");
			agenda.apellido=Console.ReadLine ();
			Console.WriteLine ("Dame tu telefono");
			agenda.telefono = int.Parse(Console.ReadLine() ) ;

			Console.WriteLine("Tus datos son: "+agenda.nombre +agenda.apellido +agenda.telefono);
			Console.ReadLine();
		}
	}
}
