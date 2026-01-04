using CqrsManagerMinimalAPI.Data;
using CqrsManagerMinimalAPI.Handlers.Create;
using CqrsManagerMinimalAPI.Handlers.Delete;
using CqrsManagerMinimalAPI.Handlers.FindAll;
using CqrsManagerMinimalAPI.Handlers.FindById;
using CqrsManagerMinimalAPI.Handlers.Update;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

#region Register services

//Reguister data cache
builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();

// Register Create
builder.Services.AddScoped<ICreateProductHandler, CreateProductHandler>();

//Register FindById
builder.Services.AddScoped<IFindProductByIdHandler, FindProductByIdHandler>();

//Register FindAll
builder.Services.AddScoped<IFindAllProductsHandler, FindAllProductsHandler>();

//Register Update
builder.Services.AddScoped<IUpdateProductHandler, UpdateProductHandler>();

//Register Delete
builder.Services.AddScoped<IDeleteProductHandler, DeleteProductHandler>();

#endregion

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddValidation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("/", () => "Teste minimal api.");

app.Run();


