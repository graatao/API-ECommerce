using API_ECommerce.Context;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<EcommerceContext, EcommerceContext>();
var app = builder.Build();





app.MapControllers();

app.Run();

