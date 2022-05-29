namespace Teleperformance._2.EntityDB
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }  
        public virtual ICollection<Student> Students { get; set; }
    }
}
