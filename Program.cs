using Etech.Dal;
using Etech.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/usuario", (DataContext context, Usuario usuario) => {
    UsuarioDAL usuarioDAL = new UsuarioDAL(context);
    usuarioDAL.cria(usuario);
    return Results.Ok(usuario);
});

app.MapGet("/usuario/all", (DataContext context) => {
    UsuarioDAL usuarioDAL = new UsuarioDAL(context);
    return Results.Ok(usuarioDAL.listaUsuarios());
});

app.Run();