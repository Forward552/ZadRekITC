using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZadanieRekrutacyjneITC.Entities
{
    public class Document
    {
        //[Key]
        public int Id { get; set; }
        public int ClientNumber { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal PriceN { get; set; }
        public decimal PriceB { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
