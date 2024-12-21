using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System;
using hrpayrollwebapi.Data;

namespace hrpayrollwebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers()
				.AddJsonOptions(op =>
				{
					op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
				})
				;

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<ApplicationDbContext>(opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});



			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
				// app.UseDeveloperExceptionPage();
			}
			app.UseExceptionHandler("/error");

			app.MapGet("/error", () =>
			{
				return Results.Problem();
			});


			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
    }
}
