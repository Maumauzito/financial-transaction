using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using TransacaoFinanceira.Appilcation.Mappers;
using TransacaoFinanceira.Appilcation.Service;
using TransacaoFinanceira.Appilcation.Service.Interfaces;
using TransacaoFinanceira.Infrastructure.Data;
using TransacaoFinanceira.Infrastructure.Repositories;
using TransacaoFinanceira.Infrastructure.Repositories.Interfaces;

namespace TransacaoFinanceira.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<TransacaoFinanceiraContex>(
                options => options.UseSqlite(Configuration.GetConnectionString("Default")));

            services.AddSingleton(m => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            }).CreateMapper());

            services.AddSwaggerGen(sd => sd.SwaggerDoc("v1", new OpenApiInfo { Title = "Transação Financeira", Version = "v1" }));

            services.AddScoped<ITransactionServices, TransactionServices>();
            services.AddScoped<IAccountServices, AccountServices>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddControllers()
                .AddJsonOptions( options => 
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                });
            services.AddCors();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(x => x.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod());

            app.MapControllers();
        }
    }
}
