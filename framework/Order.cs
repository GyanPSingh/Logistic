using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public class Order
    {
        private int orderId;
        private OrderPriority priority_of_order;
        private User sender;
        private Location destination;
        private PaymentDetails paymentDetails;
        private List<Item> items;
        private long totalWeight;
        private OrderStatus currentStatus;
        private DateTime timeOfOrderPlaced;
        private DateTime timeOfOrderDelivery;
        private Vehicle vehicleOfThisOrder;

        public int getOrderId()
        {
            return orderId;
        }

        public void setOrderId(int orderId)
        {
            this.orderId = orderId;
        }

        public OrderPriority getPriority_of_order()
        {
            return priority_of_order;
        }

        public void setPriority_of_order(OrderPriority priority_of_order)
        {
            this.priority_of_order = priority_of_order;
        }

        public User getSender()
        {
            return sender;
        }

        public void setSender(User sender)
        {
            this.sender = sender;
        }

        public Location getDestination()
        {
            return destination;
        }

        public void setDestination(Location destination)
        {
            this.destination = destination;
        }

        public PaymentDetails getPaymentDetails()
        {
            return paymentDetails;
        }

        public void setPaymentDetails(PaymentDetails paymentDetails)
        {
            this.paymentDetails = paymentDetails;
        }

        public List<Item> getItems()
        {
            return items;
        }

        public void setItems(List<Item> items)
        {
            this.items = items;
        }

        public long getTotalWeight()
        {
            return totalWeight;
        }

        public void setTotalWeight(long totalWeight)
        {
            this.totalWeight = totalWeight;
        }

        public OrderStatus getCurrentStatus()
        {
            return currentStatus;
        }

        public void setCurrentStatus(OrderStatus currentStatus)
        {
            this.currentStatus = currentStatus;
        }

        public DateTime getTimeOfOrderPlaced()
        {
            return timeOfOrderPlaced;
        }

        public void setTimeOfOrderPlaced(DateTime timeOfOrderPlaced)
        {
            this.timeOfOrderPlaced = timeOfOrderPlaced;
        }

        public DateTime getTimeOfOrderDelivery()
        {
            return timeOfOrderDelivery;
        }

        public void setTimeOfOrderDelivery(DateTime timeOfOrderDelivery)
        {
            this.timeOfOrderDelivery = timeOfOrderDelivery;
        }

        public Vehicle getVehicleOfThisOrder()
        {
            return vehicleOfThisOrder;
        }

        public void setVehicleOfThisOrder(Vehicle vehicleOfThisOrder)
        {
            this.vehicleOfThisOrder = vehicleOfThisOrder;
        }
    }
}
