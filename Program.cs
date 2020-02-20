using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CarRacing
{
	class Program
	{
		static void Main(string[] args)
		{

			Track track = new Track();
			track.AddCar(new Car());
			track.AddCar(new Car("Serg", "Ferrari"));
			track.AddCar(new Car("Dima", "Porshe"));
			track.AddCar(new Car("Tanya", "Porshe"));


			track.StartRacing();


			Thread.Sleep(1000);
			track.GetTime();

			Car bestCar = track.getWinner();
			Console.WriteLine($"Best Car is {bestCar.Model} with driver{bestCar.Name}");

			Console.ReadLine();



		}
	}
}
