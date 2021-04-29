namespace CarShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public uint Price { get; set; }
        public Car CarVal { get; set; }
        public Order OrderVal { get; set; }
    }
}