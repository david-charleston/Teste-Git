using System;
using System.Collections.Generic;
using System.Text;
using ExFixacaoEnumComposicao.Entities.Enums;

namespace ExFixacaoEnumComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();
        public Client Client { get; private set; }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) => OrderItems.Add(item);

        public void RemoveItem(OrderItem item) => OrderItems.Remove(item);

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public string ConvertMoney(double price)
        {
            return string.Format("{0:C2}", price);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine($"{item.Product.Name}, {ConvertMoney(item.Price)}, " +
                    $"Quantity: {item.Quantity}, SubTotal: {ConvertMoney(item.SubTotal())}");
            }
            sb.Append("Total: ");
            sb.AppendLine(ConvertMoney(Total()));

            return sb.ToString();
        }
    }
}
