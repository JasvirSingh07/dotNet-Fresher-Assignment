# StudentProjectGraphQL

A .NET 9 Web API using GraphQL (HotChocolate) and Entity Framework Core (SQLite) to manage students and their projects.

## Features
- Manage students and projects
- Assign students to projects (many-to-many relationship)
- GraphQL API with queries, mutations, filtering, sorting, and paging
- SQLite database for persistence

## Data Model
- **Student**: `Id`, `Name`, list of projects
- **Project**: `Id`, `ProjectName`, list of students
- **StudentProject**: Join entity for many-to-many relationship

## GraphQL API
### Queries
- `getProjects`: List all projects (with paging/filtering/sorting)
- `getStudents`: List all students (with paging/filtering/sorting)
- `getStudentsByProject(projectId)`: List students in a project
- `getProjectCountByStudent(studentId)`: Number of projects for a student

### Mutations
- `addProject(projectName)`: Add a new project
- `updateProject(id, projectName)`: Update a project
- `deleteProject(id)`: Delete a project
- `addStudent(name)`: Add a new student
- `updateStudent(id, name)`: Update a student
- `deleteStudent(id)`: Delete a student
- `assignStudentToProject(studentId, projectId)`: Assign a student to a project

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

### Setup
1. Clone the repository
2. Navigate to `StudentProjectGraphQL`
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Build the project:
   ```sh
   dotnet build
   ```
5. Run the project:
   ```sh
   dotnet run
   ```
6. The GraphQL endpoint will be available at `http://localhost:5128/graphql` (default)

### Example GraphQL Query
```
query {
  getStudents {
    items {
      id
      name
      studentProjects {
        project {
          id
          projectName
        }
      }
    }
  }
}
```

## Technology Stack
- .NET 9
- ASP.NET Core Web API
- HotChocolate GraphQL
- Entity Framework Core (SQLite)

## Project Structure
- `Models/` - Entity classes
- `Schema/` - GraphQL queries and mutations
- `Services/` - Business logic and data access
- `Data/` - Database context

