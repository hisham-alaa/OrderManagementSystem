using Microsoft.EntityFrameworkCore;
using OMS.Repository;

namespace OMS.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region Add services to the DI Container..

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<OMSDbContext>(options =>
            {
                options.UseInMemoryDatabase("OMS.Database"); // Choose a meaningful name for your database
            });

            #endregion


            var app = builder.Build();


            #region (Middlewares) Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            #endregion


            app.Run();
        }
    }
}
