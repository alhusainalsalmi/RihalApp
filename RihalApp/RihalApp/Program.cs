
using RihalApp.Data;
using RihalApp.DataAccess.DbContext;
using RihalApp.Registrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.RihalServicesRegistration();
builder.Services.RihalRepositoriesRegistration();
builder.Services.AddDbContext<RihalAppDbContext>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    RihalAppDatabaseInitializor.InitializeDatabase(scope);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
