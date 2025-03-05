using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime PublishedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual ICollection<Currency> Currencies { get; set; }
    }
}
