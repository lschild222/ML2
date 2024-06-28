using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ML2.Data;
namespace ML2;

public class Program {
    public static void Main(string[] args) {
        
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddDbContext<ML2Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ML2Context") ?? throw new InvalidOperationException("Connection string 'ML2Context' not found.")));

        builder.Services.AddCors();
        // Add services to the container.

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
