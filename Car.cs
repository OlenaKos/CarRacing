using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CarRacing
{
	class Car
	{

		public string Name {get; set;}
		public string Model { get; set; }
		public double Speed { get; set; }
		public double Time { get; set; }

		public Car()
		{
			Random rnd = new Random();
			Name = "Olena";
			Model = "Tesla";
			Thread.Sleep(100);
			Speed = rnd.Next(120, 181);
		}

		public Car(string name, string model)
		{
			Random rnd = new Random();
			Name = name;
			Model = model;
			Thread.Sleep(100);
			Speed = rnd.Next(120, 181);


		}


	}
}
