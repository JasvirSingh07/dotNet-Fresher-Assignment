using HotChocolate;

public class Mutation
{
    public async Task<Project> AddProject([Service] IMutationService mutationService, string projectName)
        => await mutationService.AddProject(projectName);

    public async Task<Project?> UpdateProject([Service] IMutationService mutationService, int id, string projectName)
        => await mutationService.UpdateProject(id, projectName);

    public async Task<bool> DeleteProject([Service] IMutationService mutationService, int id)
        => await mutationService.DeleteProject(id);

    public async Task<Student> AddStudent([Service] IMutationService mutationService, string name)
        => await mutationService.AddStudent(name);

    public async Task<Student?> UpdateStudent([Service] IMutationService mutationService, int id, string name)
        => await mutationService.UpdateStudent(id, name);

    public async Task<bool> DeleteStudent([Service] IMutationService mutationService, int id)
        => await mutationService.DeleteStudent(id);

    public async Task<bool> AssignStudentToProject([Service] IMutationService mutationService, int studentId, int projectId)
        => await mutationService.AssignStudentToProject(studentId, projectId);
} 