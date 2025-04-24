using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
//AddTransient - cria uma nova instância a cada requisição
//addScoped - cria uma nova instância a cada requisição dentro do mesmo escopo
//AddSingleton
builder.Services.AddDbContext<EcommerceContext, EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();





app.MapControllers();

app.Run();

