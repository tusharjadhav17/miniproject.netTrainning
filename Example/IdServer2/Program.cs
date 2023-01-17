using IdServer2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityServer()
   .AddInMemoryClients(IdentityConfiguration.Clients)
   .AddInMemoryIdentityResources(IdentityConfiguration.IdentityResources)
   .AddInMemoryApiResources(IdentityConfiguration.ApiResources)
   .AddInMemoryApiScopes(IdentityConfiguration.ApiScopes)
   .AddTestUsers(IdentityConfiguration.TestUsers)
   .AddDeveloperSigningCredential();

builder.Services.AddAuthentication("Bearer")
    .AddIdentityServerAuthentication("Bearer", options =>
    {
        options.ApiName = "myApi";
        options.Authority = "https://localhost:7051";
    });

var app = builder.Build();
    app.UseRouting();
    app.UseIdentityServer();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapGet("/", async context =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    });



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
