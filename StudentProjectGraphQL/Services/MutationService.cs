public class MutationService : IMutationService
{
    private readonly AppDbContext _dbContext;

    public MutationService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Project> AddProject(string projectName)
    {
        var project = new Project { ProjectName = projectName };
        _dbContext.Projects.Add(project);
        await _dbContext.SaveChangesAsync();
        return project;
    }

    public async Task<Project?> UpdateProject(int id, string projectName)
    {
        var project = await _dbContext.Projects.FindAsync(id);
        if (project == null) return null;
        project.ProjectName = projectName;
        await _dbContext.SaveChangesAsync();
        return project;
    }

    public async Task<bool> DeleteProject(int id)
    {
        var project = await _dbContext.Projects.FindAsync(id);
        if (project == null) return false;
        _dbContext.Projects.Remove(project);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<Student> AddStudent(string name)
    {
        var student = new Student { Name = name };
        _dbContext.Students.Add(student);
        await _dbContext.SaveChangesAsync();
        return student;
    }

    public async Task<Student?> UpdateStudent(int id, string name)
    {
        var student = await _dbContext.Students.FindAsync(id);
        if (student == null) return null;
        student.Name = name;
        await _dbContext.SaveChangesAsync();
        return student;
    }

    public async Task<bool> DeleteStudent(int id)
    {
        var student = await _dbContext.Students.FindAsync(id);
        if (student == null) return false;
        _dbContext.Students.Remove(student);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> AssignStudentToProject(int studentId, int projectId)
    {
        if (!_dbContext.Students.Any(s => s.Id == studentId) || !_dbContext.Projects.Any(p => p.Id == projectId))
            return false;
        if (_dbContext.StudentProjects.Any(sp => sp.StudentId == studentId && sp.ProjectId == projectId))
            return false;
        _dbContext.StudentProjects.Add(new StudentProject { StudentId = studentId, ProjectId = projectId });
        await _dbContext.SaveChangesAsync();
        return true;
    }
} 