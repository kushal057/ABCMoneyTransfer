using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure.Identity.Data;

namespace ABC.Infrastructure
{
    public class SenderRepository : Repository<Sender>, ISenderRepository
    {
        private readonly AppDBContext _context;

        public SenderRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

    }
}