using Microsoft.EntityFrameworkCore;
using webapi_tutorial;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
        object value = services.AddDatabaseDeveloperPageExceptionFilter();
        services.AddControllersWithViews();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<IMyDependency, MyDependency>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if(env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
        //https://docs.microsoft.com/ko-kr/aspnet/core/mvc/controllers/routing?view=aspnetcore-6.0#conventional-route-names
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
        });
        app.UseHttpsRedirection();
    }
}

//using Microsoft.EntityFrameworkCore;
//using webapi_tutorial;

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
//object value = builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//// Add services to the container.
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IMyDependency, MyDependency>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.MapDefaultControllerRoute();

//app.UseHttpsRedirection();

//app.Run();