﻿using framework;
using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.setUserId(1);
            user.setName("Shashi");
            user.setEmailId("shashi@gmail.com");

            Item item1 = new Item();
            item1.setName("item1");
            item1.setPrice(20);

            Item item2 = new Item();
            item2.setName("item2");
            item2.setPrice(40);

            List<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);

            PaymentDetails paymentDetails = new PaymentDetails();
            paymentDetails.setAmount(100);
            paymentDetails.setPaymentMode(PaymentMode.CREDIT_CARD);
            paymentDetails.setCardNumber("12345678");

            Location destination = new Location();
            destination.setLatitude(73.23);
            destination.setLongitude(132.34);

            Order order = new Order();
            order.setOrderId(1);
            order.setItems(items);
            order.setCurrentStatus(OrderStatus.PROCESSING);
            order.setDestination(destination);
            order.setPaymentDetails(paymentDetails);
            order.setTimeOfOrderDelivery(new DateTime());

            LogisticsSystem logisticsSystem = new LogisticsSystem();
            logisticsSystem.registerNewUser(user);
            logisticsSystem.takeAnOrder(order);
            logisticsSystem.processOrder(order);
            logisticsSystem.trackOrder(order.getOrderId());


            Console.ReadLine();
        }
    }
}
