using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJERCICIO2.Models;

namespace EJERCICIO2.DALs
{
    public interface IFigurasDAL
    {
        Task<List<Figura>> GetAll();
        Task<Figura> GetById(int idFigura);
        Task<Figura> Add(Figura nuevo);
        Task<bool> Save(Figura entidad);
        Task<bool> Remove(int idFigura);
    }
}
