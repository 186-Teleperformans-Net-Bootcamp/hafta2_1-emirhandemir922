namespace Teleperformance._2.StockManagement
{
    public class Smartphones:IProducts
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int memory { get; set; }
    }
}
