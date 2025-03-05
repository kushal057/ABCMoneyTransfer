using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure.Identity.Data;

namespace ABC.Infrastructure
{
    public class MoneyTransferRepository : Repository<MoneyTransfer>, IMoneyTransferRepository
    {
        private readonly AppDBContext _context;

        public MoneyTransferRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

    }
}