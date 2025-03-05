using ABC.Core.Interfaces;
using ABC.Infrastructure; 
using ABC.Infrastructure.Identity.Data;
using System;
using System.Threading.Tasks;
using ABC.Core.Interfaces.Repository;
using ABC.Core.Entities;

namespace ABC.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        private readonly IMoneyTransferRepository _moneyTransferRepository;
        private readonly ISenderRepository _senderRepository;
        private readonly IReceiverRepository _receiverRepository;

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
            _moneyTransferRepository = new MoneyTransferRepository(_context);
            _senderRepository = new SenderRepository(_context);
            _receiverRepository = new ReceiverRepository(_context);
        }

        public IMoneyTransferRepository MoneyTransferRepository => _moneyTransferRepository;
        public ISenderRepository SenderRepository => _senderRepository;
        public IReceiverRepository ReceiverRepository => _receiverRepository;

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<MoneyTransfer> SendMoney(MoneyTransfer entity)
        {
            var entry = _context.MoneyTransfer.Add(entity);
            await CompleteAsync();

            return entry.Entity;
        }
    }
}