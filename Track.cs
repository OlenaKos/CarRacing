using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CarRacing
{
	class Track
	{
		public double Distance { set; get; }
		public static int carsAmount = 0;

		LinkedList<Car> cars;

		// public Add Car

		//public Get Time

		//StartRacing

		public Track()
		{
			cars = new LinkedList<Car>();
			Distance = 100;

		}

		public Track(double dist, int carsAmount)
		{
			
			Distance = dist;
			for (int i = 0; i < carsAmount; i++)
			{
				cars.AddLast(new Car());
			}
		}

		public void AddCar(Car car)
		{
			cars.AddLast(car);
			carsAmount++;
		}

		public void CalculateDistance(Object car)
		{
			double TempDistance = 0;
			Car tempCar = (Car)car;

			while (TempDistance <= Distance)
			{
				TempDistance += tempCar.Speed * 0.1;
				Thread.Sleep(100);

				Console.WriteLine($"Driver {tempCar.Name} on {tempCar.Model} went distance {TempDistance} from {Distance}");
			}


		}

		public void StartRacing()
		{
			foreach (Car car in cars)
			{
				ParameterizedThreadStart trd = new ParameterizedThreadStart(CalculateDistance);
				Thread threadCar = new Thread(trd);
				threadCar.Start(car);
			}

			SetTime();
		}

		public void SetTime()
		{
			foreach (var car in cars)
			{
				car.Time = Distance / car.Speed;
			}	
		}

		public void GetTime()
		{
			foreach (var car in cars)
			{
				Console.WriteLine($"Driver {car.Name} on car {car.Model} with speed {car.Speed} drive distance in time = {car.Time}");	
			}
		}

		public Car getWinner()
		{
			double bestTime = cars.Min(c => c.Time);
			Car bestCar  =  cars.Where(c => c.Time == bestTime).First();
			return bestCar;
		}


	}
}
