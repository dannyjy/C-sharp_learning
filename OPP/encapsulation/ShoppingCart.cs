namespace OPP.Encapsulation
{
    public class ShoppingCart
    {
        private List<decimal> _prices = new List<decimal>();

        public void AddItem(decimal price)
        {
            _prices.Add(price);
        }

        // Encapsulated Property: Read-only
        // There is no "set" accessor, so nobody can overwrite the total.
        public decimal TotalAmount
        {
            get
            {
                decimal total = 0;
                foreach (var p in _prices) total += p;
                return total;
            }
        }
    }
}