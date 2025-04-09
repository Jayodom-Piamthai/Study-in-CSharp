//entrypoint for the web
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>{
    c.SwaggerDoc("v1",new() {Title="api doc",Version ="v1"});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI( c => c.SwaggerEndpoint(
        "/swagger/v1/swagger.json",
        "v1"
    ));
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/test" , () => {
    return "test complete";
});

var bookList = new List<Book>{
    new Book{ID = 1,Title = "to pierce the sky" ,Author = "james sulivan", Price = 394},
    new Book{ID = 2,Title = "refracted lights" ,Author = "jay son", Price = 449},
    new Book{ID = 3,Title = "sun cursed paradise" ,Author = "scapsis", Price = 218},
};

app.MapGet("/book" , () => {
    return bookList;
});

app.MapGet("/book/{id}" , (int id) => {
    //bookFound variable turn into result of finding book with id inserted in param 
    var bookFound = bookList.Find (bookList => bookList.ID == id);
    if(bookFound == null){
        return Results.NotFound("we do not found the book you requested");
    }
    else{
        return Results.Ok(bookFound);
    }
});

// parameter example
app.MapGet("/param/{number}" , (int number) =>{
    return "the number you enter is" + number;
});

app.MapPost("/book/create" , (Book book) => {
    bookList.Add(book);
    return(bookList);
});

app.MapPut("/book/update/{id}" , (Book updatedBook , int id)=>{
    var bookFound = bookList.Find (bookList => bookList.ID == id);
    if(bookFound == null){
        return Results.NotFound("we do not found the book you requested");
    }
    bookFound.Title = updatedBook.Title;
    bookFound.Author = updatedBook.Author;
    // if results is used in any place in api,it must be use for every scenario possible inside
    return Results.Ok(bookList);
});

app.MapDelete("/book/remove/{id}" , (int id)=>{
    var bookFound = bookList.Find (bookList => bookList.ID == id);
    if(bookFound == null){
        return Results.NotFound("we do not found the book you requested");
    }
    bookList.Remove(bookFound);

    // if results is used in any place in api,it must be use for every scenario possible inside
    return Results.Ok(bookList);
});

app.Run();

class Book
{
    public int ID { get; set;}
    public string? Title { get; set;}
    public string? Author { get; set;}
    public int Price {get; set;}
}

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
