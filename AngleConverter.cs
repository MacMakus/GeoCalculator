using System;

namespace GeoCalculator
{
    /// <summary>
    /// คลาสสำหรับแปลงหน่วยมุมจากองศาเป็นเรเดียน
    /// </summary>
    public static class AngleConverter
    {
        /// <summary>
        /// แปลงมุมจากองศาเป็นเรเดียน
        /// </summary>
        /// <param name="angle">มุมในหน่วยองศา</param>
        /// <returns>มุมในหน่วยเรเดียน</returns>
        public static double ToRadians(double angle)
        {
            return angle * Math.PI / 180.0;
        }
    }
}
