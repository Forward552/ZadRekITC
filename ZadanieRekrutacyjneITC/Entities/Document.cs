using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjneITC.Entities
{
    public class Document
    {
        public int ClientNumber { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }


    }
}
