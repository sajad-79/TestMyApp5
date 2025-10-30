using TestMyApp5.Middelweres;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(u =>
{
    u.SwaggerDoc("Version Beta", new OpenApiInfo()
    {
        Title = "تایتل تستی برای توسعه",
        Version = "ورژن بتا",
        Description = "توضیح تستی راجب ای پی ای",
        Contact = new OpenApiContact()
        {
            Name = "سجادم",
            Email = "dva512si@gmail.com",
            Url = new Uri("https://sajad79.ir")
        }
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseMiddleware<AuthMidelwere>();
app.UseMiddleware<LogMiddelwere>();


app.UseAuthorization();

app.MapControllers();

app.Run();
