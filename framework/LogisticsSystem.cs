using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public class LogisticsSystem
    {

        private List<Order> orders;
        private List<Vehicle> vehicles;
        private List<User> users;

        public LogisticsSystem()
        {
            this.orders = new List<Order>();
            this.vehicles = new List<Vehicle>();
            this.users = new List<User>();
        }

        public void takeAnOrder(Order order)
        {
            Console.WriteLine("Adding an order to the system");
            orders.Add(order);
        }

        public void processOrder(Order order)
        {
            Console.WriteLine("Processing an order of the system");
        }

        public Location trackOrder(int orderId)
        {
            Console.WriteLine("Tracking an order of the system");
            Location location = null;
           // location = findLocationOfGivenOrder(); 
            return location;
        }

        public void cacelOrder(Order order)
        {
            Console.WriteLine("Going to cancell an order of the system");
        }

        public void registerNewUser(User user)
        {
            Console.WriteLine("Registering a new user to the system");
            users.Add(user);
        }

        public List<Order> getOrders()
        {
            return orders;
        }

        public void setOrders(List<Order> orders)
        {
            this.orders = orders;
        }

        public List<Vehicle> getVehicles()
        {
            return vehicles;
        }

        public void setVehicles(List<Vehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public List<User> getUsers()
        {
            return users;
        }

        public void setUsers(List<User> users)
        {
            this.users = users;
        }
    }
}
