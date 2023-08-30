using System.Text;
using ElkoodTaskCA.Domain.Entities.User;
using ElkoodTaskCA.Domain.Repositories;
using ElkoodTaskCA.Persistence.Context;
using ElkoodTaskCA.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectiosString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddTransient<DataSeeder>();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContext<ElkoodTaskCADbContext>(options =>
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

// ADD MediatR
builder.Services.AddMediatR(        
    ElkoodTaskCA.Domain.AssemblyReference.Assembly,
    ElkoodTaskCA.Application.AssemblyReference.Assembly,
    ElkoodTaskCA.API.AssemblyReference.Assembly,
    ElkoodTaskCA.Persistence.AssemblyReference.Assembly,
    ElkoodTaskCA.Contracts.AssemblyReference.Assembly
    );

// ADD Identity
builder.Services
    .AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ElkoodTaskCADbContext>()
    .AddDefaultTokenProviders();


// Configure Identit
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 5;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.SignIn.RequireConfirmedEmail = false;
});


builder.Services.AddCors();

builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(s => s.FullName!.Replace("+", "."));
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
            "JWT Authorization header using the Bearer scheme."
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

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(optoins =>
    {
        optoins.SaveToken = true;
        optoins.RequireHttpsMetadata = false;
        optoins.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
            ValidAudience = builder.Configuration["JWT:ValidAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
        };
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