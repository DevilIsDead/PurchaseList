namespace PurchaseList
{
    public class Purchases
    {
        private static List<string> purchaseList = new();

        public static void AddPurchase(string item) => purchaseList.Add(item);

        public static List<string> GetAllPurchases() => purchaseList;
    }

}