namespace Teleperformance._2.EntityDB
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public School School { get; set; }
        public Class Class { get; set; }

    }
}
