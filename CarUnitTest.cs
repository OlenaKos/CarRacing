using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CarRacing
{
	
	[TestFixture]
	class CarUnitTest
	{

		[Test]
		public void TestAdditionCar() {
			Track track = new Track();
			track.AddCar(new Car());

			Assert.AreEqual(1, Track.carsAmount);
	
		}
	}
}
