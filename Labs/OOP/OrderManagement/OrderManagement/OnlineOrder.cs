using System.Text;

namespace Pa201LabN4
{
    public class OnlineOrder : Order
    {
        public decimal orderDistance;

        public OnlineOrder(int id, string productName, int productCount, decimal productPrice, decimal orderDistance)
            : base(id, productName, productCount, productPrice)
        {
            this.orderDistance = orderDistance;
        }

        public OnlineOrder(int id, string productName, decimal productPrice, decimal orderDistance)
            : base(id, productName, productPrice)
        {
            this.orderDistance = orderDistance;
        }

        public decimal DeliveryProductPrice()
        {

            decimal deliveryPrice = 2 * (int)Math.Ceiling(orderDistance / 5);

            return deliveryPrice;
        }

        public decimal TotalPrice()
        {
            return DeliveryProductPrice() + GetOrderPrice(id);
        }

        public StringBuilder PrintOnlineOrder()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Order ID: {id}");
            sb.AppendLine($"Product Name: {productName}");
            sb.AppendLine($"Product Count: {productCount}");
            sb.AppendLine($"Product Price: {productPrice:C}");
            sb.AppendLine($"Order Distance: {orderDistance} km");
            sb.AppendLine($"Delivery Price: {DeliveryProductPrice()}");
            sb.AppendLine($"Total Price (with delivery): {TotalPrice():C}");
            return sb;
        }
    }
}