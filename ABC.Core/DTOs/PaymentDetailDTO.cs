using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.DTOs
{
    public class PaymentDetailDto
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal TransferAmountMYR { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal PayoutAmountNPR { get; set; }
    }
}
