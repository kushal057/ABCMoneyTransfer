using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Core.Enums;

namespace ABC.Core.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public int Iso3 { get; set; }
        public string Name { get; set; }
        public decimal? Buy { get; set; }
        public decimal? Sell { get; set; }
        public int RateId { get; set; }
        public virtual Rate Rate { get; set; }
    }
}
