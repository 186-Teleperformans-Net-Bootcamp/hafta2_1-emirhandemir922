namespace Teleperformance._2.EntityDB
{
    public class School
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }  

    }
}
