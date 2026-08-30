using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DapperPrueba.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudiantesController : ControllerBase
{
    private readonly string _connectionString = "Server=INF519Estudiantes.mssql.somee.com;Database=INF519Estudiantes;User Id=luisFerreira_SQLLogin_3;Password=ljjb3fc7a4;TrustServerCertificate=True;";

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                // Convertir la fecha a un formato ISO estándar (YYYY-MM-DD)
                var sql = @"
                    SELECT 
                        Id,
                        Matricula,
                        Cedula,
                        Nombre,
                        Apellido,
                        CONVERT(DATE, Fecha_Nacimiento) as Fecha_Nacimiento,
                        Fecha_Ingreso,
                        Ocupacion,
                        Nacionalidad,
                        Telefono,
                        Email,
                        Direccion,
                        Carrera
                    FROM tblEstudiante";
                
                var estudiantes = connection.Query<Estudiante>(sql).ToList();
                return Ok(estudiantes);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al conectar con SQL: {ex.Message}");
        }
    }
}

public class Estudiante
{
    public int Id { get; set; }
    public string? Matricula { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateTime? Fecha_Nacimiento { get; set; }
    public DateTime Fecha_Ingreso { get; set; }
    public string? Ocupacion { get; set; }
    public string? Nacionalidad { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }
    public string? Direccion { get; set; }
    public string? Carrera { get; set; }
}
