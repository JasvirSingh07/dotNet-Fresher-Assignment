using Microsoft.EntityFrameworkCore;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Data;

var builder = WebApplication.CreateBuilder(args);

// Register AppDbContext with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=studentsprojects.db"));

// Register Services
builder.Services.AddScoped<IQueryService, QueryService>();
builder.Services.AddScoped<IMutationService, MutationService>();

// Register GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL("/graphql");

app.Run();
