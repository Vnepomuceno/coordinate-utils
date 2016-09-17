using System;
namespace CoordinateUtils
{
	public class CoordinateUtils
	{
		public static double distanceBetweenCoordinates(Coordinate coordinate1, Coordinate coordinate2)
		{
			double circumference = 40075.0; // Earth's circumference at the equator in km
			double distance = 0.0;
			double latitude1Rad = convertToRadians(coordinate1.latitude);
			double latititude2Rad = convertToRadians(coordinate2.latitude);
			double longitude1Rad = convertToRadians(coordinate1.longitude);
			double longitude2Rad = convertToRadians(coordinate2.longitude);
			double logitudeDiff = Math.Abs(longitude1Rad - longitude2Rad);
			if (logitudeDiff > Math.PI)
			{
				logitudeDiff = 2.0 * Math.PI - logitudeDiff;
			}
			double angleCalculation =
				Math.Acos(
				  Math.Sin(latititude2Rad) * Math.Sin(latitude1Rad) +
				  Math.Cos(latititude2Rad) * Math.Cos(latitude1Rad) * Math.Cos(logitudeDiff));
			distance = circumference * angleCalculation / (2.0 * Math.PI);
			return distance;
		}

		public static double convertToRadians(double angle)
		{
			return (Math.PI / 180) * angle;
		}
	}
}
