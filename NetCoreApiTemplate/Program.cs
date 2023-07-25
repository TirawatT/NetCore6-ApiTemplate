using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace NetCoreApiTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Oracle database , setup TNS
            string tnsAdminPath = builder.Configuration.GetValue<string>("Path:TNSAdmin");
            OracleConfiguration.TnsAdmin = tnsAdminPath;

            //var dataSources = Configuration.GetSection("OracleDataSource").Get<List<OracleDataSource>>();
            //foreach (var item in dataSources)
            //{
            //    OracleConfiguration.OracleDataSources.Add(item.TnsName, item.Source);
            //}
            // Add DataContext

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
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