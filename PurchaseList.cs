namespace PurchaseList
{
    public interface Purchases
    {
        public static List<string> purchaseList = new();

        public void Add(string item);
        

        public static List<string> GetAllPurchases()
        {
            return purchaseList;
        }
    }

    public class AddPurchase : Purchases
    {
        public void Add(string item)
        {
            Purchases.purchaseList.Add(item);
        }
    }
}
