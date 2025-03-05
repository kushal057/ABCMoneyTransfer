using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Entities
{
    public class MoneyTransfer
    {
        [Key]
        public int Id { get; set; }
        public int SenderId { get; set; }
        public virtual Sender Sender { get; set; }
        public int ReceiverId { get; set; }
        public virtual Receiver Receiver { get; set; }
        public int PaymentDetailId { get; set; }
        public virtual PaymentDetail PaymentDetail { get; set; }
    }
}
