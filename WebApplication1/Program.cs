using WebApplication1.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();

/*var jordanStotts = new PlayerBiosModel("Jordan Stoots");

PlayerBiosModel player = new PlayerBiosModel("John Smith", "@johnsmith", "johnsmith_ig", "johnsmith_fb", 25, "Software Engineer", "University of XYZ", 3, 5.2, 7);*/
