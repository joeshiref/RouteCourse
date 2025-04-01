using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}")
//     .WithStaticAssets();

app.MapGet("/", async (HttpContext context) => {
    await context.Response.WriteAsync("Hello World from root endpoint!");
});

app.MapGet("/test",async (HttpContext context) => {
    await context.Response.WriteAsync("Hello World from test endpoint!");
});



// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller}/{action}/{id?}",
//     defaults: new { controller = "Movies", action = "Index" },
//     constraints: new { id = new IntRouteConstraint() } );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

    

app.Run();
