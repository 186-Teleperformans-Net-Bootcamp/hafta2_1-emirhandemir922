namespace Teleperformance._2.EntityDB
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string profession { get; set; }
        public ICollection<Student> Students { get; set; }
        public Class Class { get; set; }
    }
}
