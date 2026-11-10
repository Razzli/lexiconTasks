using Scalar.AspNetCore;

namespace WebAPIDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

            // Tillhör .NETs inbyggda OpenAPI-stöd. Om man vill använda
            // SwaggerUI så kan man använda Swashbuckle istället.

            // Måste vara med för Scalar
            builder.Services.AddOpenApi();

            // Om man vill använda Swashbuckle istället för .NETs inbyggda OpenAPI-stöd
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                // Hör till .NET:s inbyggda dokumentgenerering.
                // Måste vara med för Scalar
                app.MapOpenApi();

                app.UseSwagger();
                app.UseSwaggerUI();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
