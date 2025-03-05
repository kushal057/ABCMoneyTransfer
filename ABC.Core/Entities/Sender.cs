using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Entities
{
    public class Sender
    {
        [Key]
        public int Id { get; set; }
        public int PersonalDetailId { get; set; }
        public virtual PersonalDetail PersonalDetails { get; set; }
    }

}
