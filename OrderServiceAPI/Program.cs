using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderServiceAPI.DAL;
using OrderServiceAPI.DAL.Interfaces;
using OrderServiceAPI.DAL.Repositories;
using OrderServiceAPI.Domain.Entity;
using OrderServiceAPI.Service.Emplementations;
using OrderServiceAPI.Service.Interfaces;

namespace OrderServiceAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();

			//Регистрируем зависимости и сервисы
			builder.Services.AddScoped<IOrderRepository<Order>, OrderRepository>();
			builder.Services.AddScoped<IOrderService, OrderService>();

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));




			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}