using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azimut
{
    public class Point
    {
        double latitude, longitude;

        public Point(double latitudeT, double longitudeT)
        {
            Latitude = latitudeT;
            Longitude = longitudeT;
        }

        public double Latitude 
        { 
            get => latitude; 
            set
            {
                if (value < -90 || value > 90) throw new ArgumentOutOfRangeException();
                latitude = value;
            }
        }

        public double Longitude 
        { 
            get => longitude; 
            set
            {
                if (value < -180 || value > 180) throw new ArgumentOutOfRangeException();
                longitude = value;
            }
            
        }
    }
}
