using DapperAsp.netCore.Context;
using DapperAsp.netCore.Contracts;
using DapperAsp.netCore.Repository;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();


builder.Services.AddControllers();


var app = builder.Build();






app.Run();
