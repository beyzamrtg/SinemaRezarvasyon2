using SinemaRezarvasyon.Data;
using SinemaRezarvasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SinemaRezarvasyon.Services
{
   public class SeansServis
    {
        AppDbContext _dbContext = new AppDbContext();

        public List<Seans> GetAll()
        {
            return _dbContext.Seans.ToList();
        }
        public List<Seans> FilmleriSeansaGoreListele(string filmAdi)
        {
            var seanslar = _dbContext.Seans
                                     .Join(_dbContext.Film,
                                           seans => seans.filmId,
                                           film => film.id,
                                           (seans, film) => new { Seans = seans, FilmAdi = film.filmAdi })
                                     .Where(x => x.FilmAdi == filmAdi)
                                     .Select(x => x.Seans)
                                     .ToList();

            return seanslar;
        }
        public Seans GetSeansDetailsBasedOnseansId(int seansId)
        {
            return _dbContext.Seans.FirstOrDefault(s => s.id == seansId);
        }
    }

}
