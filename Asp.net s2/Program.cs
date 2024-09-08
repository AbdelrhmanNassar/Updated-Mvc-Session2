var builder = WebApplication.CreateBuilder(args);

#region Register Service To Di containter
    builder.Services.AddControllersWithViews();
#endregion

var app = builder.Build();//this is the kestral



//unable routing pipeline  inside the kestral
app.UseRouting();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
   name: "defalut",
   pattern: "{controller=Movie}/{action=GetMovie}/{id:int?}"
    );


app.Run();
