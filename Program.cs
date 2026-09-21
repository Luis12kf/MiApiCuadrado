var builder = WebApplication.CreateBuilder(args);

// 1. REGISTRAR SERVICIOS (van ANTES de builder.Build())
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Registrar el servicio de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// 2. CONFIGURAR EL PIPELINE (van DESPUÉS de builder.Build() y ANTES de app.Run())
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseRouting(); // Recomendado colocarlo antes de UseCors

// ACTIVAR EL MIDDLEWARE DE CORS AQUÍ (debe ir ANTES de UseAuthorization)
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

// 3. INICIAR LA APLICACIÓN (debe ir SIEMPRE al final de todo)
app.Run();
