using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public class Bike : Vehicle
    {

        private static int capacityofBike = 10;
        private int id;
        private String vehicleNo;
        public Bike(int id, String vehicleNo) : base(id, vehicleNo, capacityofBike)
        {
            //this.id = id;
           // this.vehicleNo = vehicleNo;           
        }
    }
}
