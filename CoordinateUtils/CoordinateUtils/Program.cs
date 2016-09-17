using System;

namespace DistanceBetweenCoordinates
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Coordinate lisbonCoordinate = new Coordinate(38.7222524, -9.139336599999979);
			Coordinate portoCoordinate = new Coordinate(41.1579438, -8.629105299999992);
			Coordinate bragaCoordinate = new Coordinate(41.5454714, -8.42650709999998);
			Coordinate louresCoordinate = new Coordinate(38.831549, -9.174109499999986);

			Console.WriteLine("Distance between Lisbon " + lisbonCoordinate.toString() + " and Porto " + portoCoordinate.toString()
			                  + ": " + CoordinateUtils.distanceBetweenCoordinates(lisbonCoordinate, portoCoordinate) + " km");
			Console.WriteLine("Distance between Lisbon " + lisbonCoordinate.toString() + " and Braga " + bragaCoordinate.toString()
			                  + ": " + CoordinateUtils.distanceBetweenCoordinates(lisbonCoordinate, bragaCoordinate) + " km");
			Console.WriteLine("Distance between Lisbon " + lisbonCoordinate.toString() + " and Loures " + louresCoordinate.toString()
			                  + ": " + CoordinateUtils.distanceBetweenCoordinates(lisbonCoordinate, louresCoordinate) + " km");
		}
	}
}
