using ABC.Core.Entities;
using ABC.Core.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Application.ViewModel
{
    public class MoneyTransferViewModel : IMoneyTransferViewModel
    {
        public MoneyTransferViewModel()
        {
            Sender = new SenderViewModel();
            Receiver = new ReceiverViewModel();
            PaymentDetail = new PaymentDetailViewModel();
        }
        public ISenderViewModel Sender { get; set; }
        public IReceiverViewModel Receiver { get; set; }
        public IPaymentDetailViewModel PaymentDetail { get; set; }

        public MoneyTransfer MapToEntity()
        {
            return new MoneyTransfer
            {
                Sender = new Sender
                {
                    PersonalDetails = new PersonalDetail
                    {
                        Address = Sender.Address,
                        FirstName = Sender.FirstName,
                        MiddleName = Sender.MiddleName,
                        LastName = Sender.LastName,
                        Country = Sender.Country
                    }
                },
                Receiver = new Receiver
                {
                    PersonalDetails = new PersonalDetail
                    {
                        Address = Receiver.Address,
                        FirstName = Receiver.FirstName,
                        MiddleName = Receiver.MiddleName,
                        LastName = Receiver.LastName,
                        Country = Receiver.Country
                    }
                },
                PaymentDetail = new PaymentDetail
                {
                    TransferAmountMYR = PaymentDetail.TransferAmount,
                    BankName = PaymentDetail.BankName,
                    ExchangeRate = PaymentDetail.ExchangeRate,
                    PayoutAmountNPR = PaymentDetail.PayoutAmount, 
                    AccountNumber = PaymentDetail.AccountNumber
                },
            };
        }
    }
}
