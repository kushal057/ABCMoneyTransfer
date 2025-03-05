using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Entities
{
    public class PaymentDetail
    {
        [Key]
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal TransferAmountMYR { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal PayoutAmountNPR { get; set; }
    }
}
