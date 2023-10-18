using Npgsql;

String CadenaConexion = "Server=localhost;Port=5432;Database=gestorBibliotecaPersonal;User Id=postgres;Password=Mitobyy12.";
NpgsqlConnection conexion = new NpgsqlConnection(CadenaConexion);
conexion.Open();
//Se obtiene el estado de conexión para informarlo por consola
String estado = conexion.State.ToString();
if (estado.Equals("Open"))
{

    Console.WriteLine("[INFORMACIÓN-ConexionPostgresqlImplementacion-generarConexionPostgresql] Estado conexión: " + estado);

}

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
