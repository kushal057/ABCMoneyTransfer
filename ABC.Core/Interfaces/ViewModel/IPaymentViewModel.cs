using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Interfaces.ViewModel
{
    public interface IPaymentDetailViewModel
    {
        string BankName { get; set; }
        string AccountNumber { get; set; }
        decimal TransferAmount { get; set; } 
        decimal ExchangeRate { get; set; }
        decimal PayoutAmount { get; set; } 
    }
}
