using ABC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Interfaces.ViewModel
{
    public interface IMoneyTransferViewModel
    {
        ISenderViewModel Sender { get; set; }
        IReceiverViewModel Receiver { get; set; }
        IPaymentDetailViewModel PaymentDetail { get; set; }
        MoneyTransfer MapToEntity();
    }
}
