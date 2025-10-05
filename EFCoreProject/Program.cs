using EFCoreProject.BusinessAccessLayer;
using EFCoreProject.DataAccessLayer;
using EFCoreProject.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CompnayDbContext>(options =>
{
    options.UseMySql(
       builder.Configuration.GetConnectionString("DbConnection"),
       ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DbConnection"))
   );
});
builder.Services.AddScoped<EmployeeDAL>();
builder.Services.AddScoped<EmployeeBAL>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
