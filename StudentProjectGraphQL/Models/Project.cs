public class Project
{
    public int Id { get; set; }
    public string ProjectName { get; set; } = null!;
    public ICollection<StudentProject> StudentProjects { get; set; } = new List<StudentProject>();
} 