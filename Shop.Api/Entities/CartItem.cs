namespace Shop.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //Navigation Properties
        public int CartId { get; set; }
        public int ProductId { get; set; }
    }
}
