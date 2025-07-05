public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<StudentProject> StudentProjects { get; set; } = new List<StudentProject>();
} 