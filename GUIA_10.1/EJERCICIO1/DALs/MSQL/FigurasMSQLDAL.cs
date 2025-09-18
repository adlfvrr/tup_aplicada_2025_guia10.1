using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO2.Models;
using Microsoft.Data.SqlClient;

namespace EJERCICIO2.DALs.MSQL
{
    public class FigurasMSQLDAL : IFigurasDAL
    {
                string stringDeConexion = "Data Source=172.16.3.39;Initial Catalog=Guia10_1_Ejercicio1_adolf_db;User ID=admindb;Password=admindb;Pooling=False;Connect Timeout=30;Encrypt=False;Authentication=SqlPassword;Application Name=vscode-mssql;Application Intent=ReadWrite;Command Timeout=30";
        
        async public Task<Figura> Add(Figura nuevo)
        {
            throw new NotImplementedException();
        }

        async public Task<List<Figura>> GetAll()
        {
            List<Figura> Figuras = new();
            
                string query = @"
SELECT f.Id, f.Tipo, f.Area, f.Ancho, f.Largo, f.Radio
FROM Figuras f
";
                using SqlConnection conexion = new SqlConnection(stringDeConexion);
                await conexion.OpenAsync();

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader dataReader = await cmd.ExecuteReaderAsync();
                Console.WriteLine($"{"Id",10} | {"Tipo",10} | {"Area",10} | {"Ancho",10} | {"Largo",10} | {"Radio",10}");

                while (await dataReader.ReadAsync())
                {
                    int id = Convert.ToInt32(dataReader["Id"]);
                    int Tipo = Convert.ToInt32(dataReader["Tipo"]);
                    double? area = dataReader["Area"] != DBNull.Value ? Convert.ToDouble(dataReader["Tipo"]) : null;
                    double? ancho = dataReader["Ancho"] != DBNull.Value ? Convert.ToDouble(dataReader["Ancho"]) : null;
                    double? largo = dataReader["Largo"] != DBNull.Value ? Convert.ToDouble(dataReader["Largo"]) : null;
                    double? radio = dataReader["Radio"] != DBNull.Value ? Convert.ToDouble(dataReader["Radio"]) : null;

                    Console.WriteLine($"{id,10} | {Tipo,10} | {area,10} | {ancho,10} | {largo,10} | {radio,10}");

                    if (Tipo == 1)
                {
                    Figuras.Add(new Rectangulo(ancho??0, largo??0, area??0));
                }
                }
            return Figuras;
        }

        async public Task<Figura> GetById(int idFigura)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> Remove(int idFigura)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> Save(Figura entidad)
        {
            throw new NotImplementedException();
        }
    }
}
