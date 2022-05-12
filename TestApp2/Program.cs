using Microsoft.EntityFrameworkCore;
using TestApp2.Data;

var builder = WebApplication.CreateBuilder(args);

//Adding db context sqlserver 
builder.Services.AddDbContext<TestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestContext")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
