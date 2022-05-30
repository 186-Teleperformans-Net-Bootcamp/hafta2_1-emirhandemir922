namespace Teleperformance._2.EntityDB
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public Course course { get; set; }
        public School school { get; set; }
    }
}
