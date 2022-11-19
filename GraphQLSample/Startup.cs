using DataLayer;
using DataLayer.Contracts;

namespace GraphQLSample;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<EfDataContext>();
        services.AddScoped<PersonRepository, EFPersonRepository>();
        
        services
            .AddGraphQLServer()
            .AddQueryType<EFPersonRepository>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGraphQL();
        });
    }
}