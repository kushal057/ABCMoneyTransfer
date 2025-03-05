using ABC.Core.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Application.ViewModel
{
    public class PaymentDetailViewModel : IPaymentDetailViewModel
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal TransferAmount { get; set; } 
        public decimal ExchangeRate { get; set; }
        public decimal PayoutAmount { get; set; } 
    }
}
