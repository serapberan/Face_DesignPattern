using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kredi
    {
        public int Id { get; set; }
        public string EvKredisi { get; set; }
        public string ArabaKredisi { get; set; }
        public string IhtiyacKredisi { get; set; }
        public bool Durum { get; set; }
    }
}
