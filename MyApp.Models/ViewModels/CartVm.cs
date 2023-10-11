namespace MyApp.Models.ViewModels
{
    public class CartVm
    {
        public IEnumerable<Cart> ListOfCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
