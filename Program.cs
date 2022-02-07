using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
try
{
    SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
    sqlbuilder.DataSource = "kisaanproserver.database.windows.net";
    sqlbuilder.UserID = "kisaanpro";
    sqlbuilder.Password = "kisaaanpro@123";
    sqlbuilder.InitialCatalog = "Kisaan Pro";

    using (SqlConnection connection = new SqlConnection(sqlbuilder.ConnectionString))
    {
        Console.WriteLine("\nQuery data example:");
        Console.WriteLine("=========================================\n");

        String sql = "SELECT * FROM [dbo].[Database]";

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}", reader.GetInt32(0).ToString(), reader.GetString(1));
                }
            }
        }
    }
}
catch(SqlException e)
{
    Console.WriteLine(e.ToString());
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
