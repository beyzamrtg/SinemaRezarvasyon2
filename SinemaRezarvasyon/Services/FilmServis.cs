using SinemaRezarvasyon.Data;
using SinemaRezarvasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezarvasyon.Services
{
    public class FilmServis
    {
        AppDbContext _dbContext = new AppDbContext();

        public List<Film> GetAll()
        {
            return _dbContext.Film.ToList();
        }

        public Film GetFilmDetailsBasedOnfilmId(int filmId)
        {
            return _dbContext.Film.FirstOrDefault(m => m.id == filmId);
        }
    }
}
