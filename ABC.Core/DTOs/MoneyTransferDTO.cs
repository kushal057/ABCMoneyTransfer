using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.DTOs
{
    public class MoneyTransferDTO
    {
        public int Id { get; set; }
        public SenderDto Sender { get; set; }
        public ReceiverDto Receiver { get; set; }
        public PaymentDetailDto PaymentDetail { get; set; }
    }
}
