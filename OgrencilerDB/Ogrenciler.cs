using Teleperformance._2.Attributes;

namespace Teleperformance._2.OgrencilerDB
{
    [Table("ç, i, ş, ö, ğ, ü")]
    public class Ogrenciler
    {
        [Column("id", "int", true)]
        public int id { get; set; }
        [Column("name", "string", true)]
        public string name { get; set; }
    }
}
