 namespace PurchaseList
{
    public interface Purchases
    {
        void Add(string purchase);
        public List<string> GetAllPurchases();
    }

    public class PurchaseIO : Purchases
    {
        public List<string> Purchases = new();

        public void Add(string purchase)
        {
            Purchases.Add(purchase);
        }
        public List<string> GetAllPurchases()
        {
            return Purchases;
        }
    }
}
