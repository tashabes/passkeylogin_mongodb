using PassKey.Login.MongoDb.Blazor.Server.UI.IService;
using PassKey.Login.MongoDb.Blazor.Server.UI.Service;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICompaniesService, CompaniesService>();
builder.Services.AddSyncfusionBlazor();


var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cWGhBYVJ3WmFZfV1gdVdMZV1bRHRPIiBoS35RdUVrWXtfcnFURmJVVEVz");

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
