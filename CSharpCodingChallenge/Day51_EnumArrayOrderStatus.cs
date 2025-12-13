using System;

namespace CSharpCodingChallenge
{
    // Enum definition
    enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    internal class Day51_EnumArrayOrderStatus
    {
        public void AnalyzeOrderStatus()
        {
            // Enum array
            OrderStatus[] orders =
            {
                OrderStatus.Pending,
                OrderStatus.Shipped,
                OrderStatus.Delivered,
                OrderStatus.Pending,
                OrderStatus.Cancelled,
                OrderStatus.Delivered,
                OrderStatus.Shipped,
                OrderStatus.Pending
            };

            int pendingCount = 0;
            int shippedCount = 0;
            int deliveredCount = 0;
            int cancelledCount = 0;

            foreach (OrderStatus status in orders)
            {
                switch (status)
                {
                    case OrderStatus.Pending:
                        pendingCount++;
                        break;
                    case OrderStatus.Shipped:
                        shippedCount++;
                        break;
                    case OrderStatus.Delivered:
                        deliveredCount++;
                        break;
                    case OrderStatus.Cancelled:
                        cancelledCount++;
                        break;
                }
            }

            Console.WriteLine("Order Status Summary:");
            Console.WriteLine("Pending: " + pendingCount);
            Console.WriteLine("Shipped: " + shippedCount);
            Console.WriteLine("Delivered: " + deliveredCount);
            Console.WriteLine("Cancelled: " + cancelledCount);
        }
    }
}
