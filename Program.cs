using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notes.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

string connection = builder.Configuration.GetConnectionString("NotesDBConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connection));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
