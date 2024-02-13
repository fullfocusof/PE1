using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azimut
{
    public class Solution
    {
        double distance, azimut, REarth = 6372795;

        enum temp
        {
            None = -1,
            Any = -2
        }

        public Solution(Point p1, Point p2)
        {
            if (p1.Latitude == p1.Latitude && p2.Longitude == p2.Longitude)
            {
                throw new ArgumentOutOfRangeException(temp.None.ToString());
            }

            double dLong = Math.Max(p1.Longitude, p2.Longitude) - Math.Min(p1.Longitude, p2.Longitude);
            double azimutTemp = Math.Acos(Math.Sin(p1.Latitude) * Math.Sin(p2.Latitude) + Math.Cos(p1.Latitude) * Math.Cos(p2.Latitude) * Math.Cos(dLong));
            double distanceTemp = REarth * azimut;

            if (azimutTemp < 0 || azimutTemp > 360)
            {
                throw new ArgumentOutOfRangeException(temp.None.ToString());           
            }
        }

        public double Distance { get => distance; }

        public double Azimut { get => azimut; }     
    }
}
