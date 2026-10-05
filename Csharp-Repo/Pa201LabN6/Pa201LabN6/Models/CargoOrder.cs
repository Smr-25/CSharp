using System;
using System.Threading;
using Pa201LabN6.Enums;

namespace Pa201LabN6.Models
{
    internal class CargoOrder
    {

        private static int _id;

        public int Id { get; }

        public int CustomerId { get; set; }

        public int CourierId { get; set; }

        public decimal TotalAmount { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Created;

        public DateTime CreatedAt { get; init; }

        public CargoOrder(int customerId, int courierId, decimal totalAmount)
        {
            _id++;
            Id = _id;
            CustomerId = customerId;
            CourierId = courierId;
            TotalAmount = totalAmount;
            CreatedAt = DateTime.Now;
        }

        public void UpdateStatus(OrderStatus orderStatus)
        {
            if (orderStatus == OrderStatus.Cancelled || orderStatus == OrderStatus.Created)
            {

            }
            Status = orderStatus;
        }
        public override string ToString()
        {
            return $"CargoOrder {{ Id = {Id}, CustomerId = {CustomerId}, CourierId = {CourierId}, TotalAmount = {TotalAmount} , Status = {Status}}}";
        }
    }
}
