 namespace PurchaseList
{
    public class Purchases
    {
        public static List<string> purchaseList = new();

        public interface IAdd
        {
            void Add(string purchase);
        }

        public class AddPurchase : Purchases.IAdd
        {
            public void Add(string purchase)
            {
                Purchases.purchaseList.Add(purchase);
            }
        }


        public static List<string> GetAllPurchases()
        {
            return purchaseList;
        }
    }

    
}
