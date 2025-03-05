using ABC.Application.ViewModel;
using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Services;
using ABC.Core.Interfaces.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace ABC.Application.Services
{
    public class MoneyTransferService : IMoneyTransferService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MoneyTransferService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IMoneyTransferViewModel> SendMoney(IMoneyTransferViewModel model)
        {
            var entity = model.MapToEntity();

            var dbEntity = await _unitOfWork.SendMoney(entity);

            IMoneyTransferViewModel vm = new MoneyTransferViewModel
            {
                Sender = new SenderViewModel
                {
                    Address = dbEntity.Sender.PersonalDetails.Address,
                    FirstName = dbEntity.Sender.PersonalDetails.FirstName,
                    MiddleName = dbEntity.Sender.PersonalDetails.MiddleName,
                    LastName = dbEntity.Sender.PersonalDetails.LastName,
                    Country = dbEntity.Sender.PersonalDetails.Country
                },
                Receiver = new ReceiverViewModel
                {
                    Address = dbEntity.Receiver.PersonalDetails.Address,
                    FirstName = dbEntity.Receiver.PersonalDetails.FirstName,
                    MiddleName = dbEntity.Receiver.PersonalDetails.MiddleName,
                    LastName = dbEntity.Receiver.PersonalDetails.LastName,
                    Country = dbEntity.Receiver.PersonalDetails.Country
                },
                PaymentDetail = new PaymentDetailViewModel
                {
                    TransferAmount = dbEntity.PaymentDetail.TransferAmountMYR, 
                    BankName = dbEntity.PaymentDetail.BankName,
                    ExchangeRate = dbEntity.PaymentDetail.ExchangeRate,
                    PayoutAmount = dbEntity.PaymentDetail.PayoutAmountNPR, 
                    AccountNumber = dbEntity.PaymentDetail.AccountNumber
                }
            };
            return vm;
        }  
    }
}
