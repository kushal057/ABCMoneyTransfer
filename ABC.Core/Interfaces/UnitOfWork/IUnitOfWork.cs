using System;
using System.Threading.Tasks;
using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Repository;

namespace ABC.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMoneyTransferRepository MoneyTransferRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }
        ISenderRepository SenderRepository { get; }
        IReceiverRepository ReceiverRepository { get; }
        Task<int> CompleteAsync();
        Task<MoneyTransfer> SendMoney(MoneyTransfer entity);
    }
}