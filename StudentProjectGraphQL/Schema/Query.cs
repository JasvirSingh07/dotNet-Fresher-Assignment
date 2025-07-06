using HotChocolate;
using HotChocolate.Data;

public class Query
{
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Project> GetProjects([Service] IQueryService queryService)
        => queryService.GetProjects();


    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Student> GetStudents([Service] IQueryService queryService)
            => queryService.GetStudents();

    public IQueryable<Student> GetStudentsByProject([Service] IQueryService queryService, int projectId)
        => queryService.GetStudentsByProject(projectId);

    public int GetProjectCountByStudent([Service] IQueryService queryService, int studentId)
        => queryService.GetProjectCountByStudent(studentId);
}