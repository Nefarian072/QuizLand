using Microsoft.EntityFrameworkCore;
using QuizLand.DataLayer.Base;
using QuizLand.DataLayer.Base.Interfaces;
using QuizLand.Infrastructure;

namespace QuizLand.WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<QuizLandDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Mark).Assembly));
        builder.Services.AddAutoMapper(typeof(Program));
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
    }
}
