public class QueryService : IQueryService
{
    private readonly AppDbContext _dbContext;

    public QueryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Project> GetProjects()
    {
        return _dbContext.Projects;
    }

    public IQueryable<Student> GetStudents()
    {
        return _dbContext.Students;
    }

    public IQueryable<Student> GetStudentsByProject(int projectId)
    {
        return _dbContext.StudentProjects
            .Where(sp => sp.ProjectId == projectId)
            .Select(sp => sp.Student);
    }

    public int GetProjectCountByStudent(int studentId)
    {
        return _dbContext.StudentProjects.Count(sp => sp.StudentId == studentId);
    }
} 