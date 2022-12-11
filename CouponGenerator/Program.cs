using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddXmlDataContractSerializerFormatters();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API",
    });
    // using System.Reflection;
    string? xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.yaml", "v1");
    //options.RoutePrefix = string.Empty;
    options.DisplayRequestDuration();
    options.EnableDeepLinking();
    options.DisplayOperationId();
});
app.UseReDoc(options =>
{
    options.RoutePrefix = "redoc";
    options.DocumentTitle = "API";
    options.SpecUrl("/swagger/v1/swagger.yaml");
    options.EnableUntrustedSpec();
    options.ScrollYOffset(10);
    options.RequiredPropsFirst();
    options.PathInMiddlePanel();
    options.NativeScrollbars();
    options.SortPropsAlphabetically();
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Coupon}/{action=Index}/{id?}");

app.Run();
