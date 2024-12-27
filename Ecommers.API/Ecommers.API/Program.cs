using Ecommers.BL.ExtensionsForBl;
using Ecommers.DAL.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceRepostories();
builder.Services.AddServiceRepostoriesforBL();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
