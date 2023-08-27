using ElkoodTaskCA.API;
using ElkoodTaskCA.Application.Models;
using ElkoodTaskCA.Application.Repositories.BranchInfoRepository;
using ElkoodTaskCA.Application.Repositories.BranchTypeRepository;
using ElkoodTaskCA.Application.Repositories.CompanyInfoRepository;
using ElkoodTaskCA.Application.Repositories.DistributionOperationRepository;
using ElkoodTaskCA.Application.Repositories.ProductionOperationRepository;
using ElkoodTaskCA.Application.Repositories.ProductProducedRepository;
using ElkoodTaskCA.Application.Repositories.ProductsInfoRepository;
using ElkoodTaskCA.Application.Repositories.ProductTypeRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectiosString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddTransient<DataSeeder>();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectiosString)
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddScoped<IBranchTypesService, BranchTypesService>();
builder.Services.AddScoped<IBranchesInfoService, BranchesInfoService>();
builder.Services.AddScoped<IProductTypesService, ProductTypesService>();
builder.Services.AddScoped<IProductProducedService, ProductProducedService>();
builder.Services.AddScoped<ICompaniesInfoService, CompaniesInfoService>();
builder.Services.AddScoped<IDistributionOperationService, DistributionOperationService>();
builder.Services.AddScoped<IProductionOperationService, ProductionOperationsService>();
builder.Services.AddScoped<IProductsInfoService, ProductsInfoService>();


builder.Services.AddMediatR(typeof(Startup));
builder.Services.AddCors();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Elkood - Backend Task",
        Description = "Mini software system With API",
        //TermsOfService = new Uri("https://www.google.com"),
        Contact = new OpenApiContact
        {
            Name = "Zohir Boshi",
            Email = "zohirboshi@gmail.com"
            //Url = new Uri("https://www.google.com")
        },
        License = new OpenApiLicense
        {
            Name = "My license"
            //Url = new Uri("https://www.google.com")
        }
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description =
            "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\""
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();

app.MapControllers();
app.Run();


namespace ElkoodTaskCA.API
{
    public class Startup
    {
    }
}