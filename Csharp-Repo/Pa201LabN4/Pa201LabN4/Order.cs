using System.Text;

namespace Pa201LabN4
{
    public class Order
    {
        public int id;
        public string productName;
        public int productCount;
        public decimal productPrice;

        public Order(int id, string productName, int productCount, decimal productPrice)
        {
            this.id = id;
            this.productName = productName;
            this.productCount = productCount;
            this.productPrice = productPrice;
        }

        public Order(int id, string productName, decimal productPrice) : this(id, productName, 1, productPrice)
        { }

        public decimal GetOrderPrice(int id)
        {
            return productPrice * productCount;
        }

        public int IncreaseProductCount(int n)
        {
            this.productCount += n;
            return this.productCount;
        }

        public int IncreaseProductCount()
        {
            this.productCount += 1;
            return this.productCount;
        }

        public StringBuilder PrintProduct()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Order ID: {id}");
            sb.AppendLine($"Product Name: {productName}");
            sb.AppendLine($"Product Count: {productCount}");
            sb.AppendLine($"Product Price: {productPrice:C}");
            sb.AppendLine($"Total Price: {GetOrderPrice(id):C}");
            return sb;
        }

        public decimal ChangePrice(decimal newPrice, out decimal diff)
        {
            diff = newPrice - productPrice;
            productPrice = newPrice;

            return productPrice;
        }
    }
}