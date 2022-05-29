namespace Teleperformance._2.EntityDB
{
    public class Class
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
