

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


using front_back.Controllers;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<ClientController>();

builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{ID?}");


app.MapFallbackToFile("index.html"); ;

app.Run();


WebDriver driver = new ChromeDriver();

driver.Url = "http://localhost:3000";

IWebElement element = driver.FindElement(By.Name("Hello"));
element.Click();
