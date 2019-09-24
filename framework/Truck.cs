using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public class Truck : Vehicle
    {

        private static int capacityofTruck = 100;
        private int id;
        private String vehicleNo;
        public Truck(int id, String vehicleNo) : base(id, vehicleNo, capacityofTruck)
        {

        }
    }
}
