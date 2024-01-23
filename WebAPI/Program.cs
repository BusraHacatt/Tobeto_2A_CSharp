using Business.DependencyResolvers;
using Core.CrossCuttingConcerns.Exceptions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddBusinessServices();






builder.Services.AddControllers();
 https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


<<<<<<< Updated upstream
// Configure the HTTP request pipeline...
=======
var app = builder.Build();
app.UseGlobalExceptionHandling();


>>>>>>> Stashed changes
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();