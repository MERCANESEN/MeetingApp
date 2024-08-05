var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//mvc addcontrollerwithviews mvc şablonu için kullanılan bir servis
//rest api için farklı bir servis 
//razor pages için farklı bir servis kullanılır


//{Controller=Home}/{action=Index}/id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute(

    name:"default",
    pattern:"{Controller=Home}/{action=Index}/{id?}"
);


app.Run();
