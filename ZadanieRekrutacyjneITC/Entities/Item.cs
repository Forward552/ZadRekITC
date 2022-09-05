using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjneITC.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Count { get; set; }
        public decimal PriceN { get; set; }
        public decimal PriceB { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

    }
}
