using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure.Identity.Data;

namespace ABC.Infrastructure
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        private readonly AppDBContext _context;

        public CurrencyRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

    }
}