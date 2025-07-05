public interface IMutationService
{
    Task<Project> AddProject(string projectName);
    Task<Project?> UpdateProject(int id, string projectName);
    Task<bool> DeleteProject(int id);
    Task<Student> AddStudent(string name);
    Task<Student?> UpdateStudent(int id, string name);
    Task<bool> DeleteStudent(int id);
    Task<bool> AssignStudentToProject(int studentId, int projectId);
} 