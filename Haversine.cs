using System;

namespace GeoCalculator
{
    /// <summary>
    /// คลาสสำหรับคำนวณระยะทางระหว่างสองจุดบนโลก
    /// โดยใช้สูตร Haversine
    /// </summary>
    public class Haversine
    {
        private const double EarthRadiusKm = 6371.0; // รัศมีโลกในหน่วยกิโลเมตร

        /// <summary>
        /// คำนวณระยะทางระหว่างพิกัดสองจุดบนโลก
        /// </summary>
        /// <param name="destinationLatitude">ละติจูดของจุดปลายทาง (องศา)</param>
        /// <param name="destinationLongitude">ลองจิจูดของจุดปลายทาง (องศา)</param>
        /// <param name="userLatitude">ละติจูดของจุดเริ่มต้น (องศา)</param>
        /// <param name="userLongitude">ลองจิจูดของจุดเริ่มต้น (องศา)</param>
        /// <returns>ระยะทางระหว่างสองจุดในหน่วยกิโลเมตร</returns>
        public double CalculateDistance(double destinationLatitude, double destinationLongitude, double userLatitude, double userLongitude)
        {
            double lat1 = AngleConverter.ToRadians(userLatitude);
            double lon1 = AngleConverter.ToRadians(userLongitude);
            double lat2 = AngleConverter.ToRadians(destinationLatitude);
            double lon2 = AngleConverter.ToRadians(destinationLongitude);

            double dLat = lat2 - lat1;
            double dLon = lon2 - lon1;

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Pow(Math.Sin(dLon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm * c;
        }
    }
}