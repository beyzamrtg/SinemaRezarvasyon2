using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaRezarvasyon.Models
{
    public class Rezervasyon
    {
        public int id { get; set; }
        public string koltukNo { get; set; }
        public int seansId { get; set; }
    }
}
