using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public class Location
    {

        private Double longitude;
        private Double latitude;       

        public Double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public Double getLongitude()
        {
            return longitude;
        }

        public void setLongitude(Double longitude)
        {
            this.longitude = longitude;
        }

        public Double getLatitude()
        {
            return latitude;
        }

        public void setLatitude(Double latitude)
        {
            this.latitude = latitude;
        }
    }
}
