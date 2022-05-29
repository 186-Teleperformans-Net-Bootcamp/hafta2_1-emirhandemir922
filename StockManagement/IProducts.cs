namespace Teleperformance._2.StockManagement
{
    public interface IProducts
    {
        int id { get; set; }
        string name { get; set; }
        decimal price { get; set; }
        int stock { get; set; }

        public int calculateStock (int id) //dependency
        {
            //do something with stock
            return 0;
        }
    }
}
