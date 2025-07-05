public interface IQueryService
{
    IQueryable<Project> GetProjects();
    IQueryable<Student> GetStudents();
    IQueryable<Student> GetStudentsByProject(int projectId);
    int GetProjectCountByStudent(int studentId);
} 