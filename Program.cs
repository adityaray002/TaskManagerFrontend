using MudBlazor.Services;
using TaskManager_Frontend.Components;
using TaskManager_Frontend.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMudServices();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddScoped<Employees>();
builder.Services.AddScoped<EmployeeResponse>();
builder.Services.AddScoped<Tags>();
builder.Services.AddScoped<TagResponse>();
builder.Services.AddScoped<TaskModel>();
builder.Services.AddScoped<TaskTag>();
builder.Services.AddScoped<TaskStatusss>();
builder.Services.AddScoped<EmployeeTasks>();
builder.Services.AddScoped<TaskStatuses>();

var app = builder.Build();

app.UseWebSockets();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
