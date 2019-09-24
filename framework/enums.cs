using System;
using System.Collections.Generic;
using System.Text;

namespace framework
{
    public enum VehicleStatus
    {
        FREE,
        BUSY,
        NOT_WORKING
    }
    public enum OrderPriority
    {
        LOW,
        MEDIUM,
        HIGH
    }
    public enum OrderStatus
    {
        DELIVERED,
        PROCESSING,
        CANCELLED
    }
    public enum PaymentMode
    {

        NET_BANKING,
        CREDIT_CARD,
        DEBIT_CARD
    }
    public enum PaymentStatus
    {
        PAID,
        UNPAID
    }
}
