namespace ML2.Model
{
    public class Orderline
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        public Orders? Orders { get; set; }
        public Item? Item { get; set; }
    }
}
