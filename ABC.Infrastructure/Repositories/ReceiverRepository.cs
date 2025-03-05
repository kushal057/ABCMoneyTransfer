using ABC.Core.Entities;
using ABC.Core.Interfaces;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure.Identity.Data;

namespace ABC.Infrastructure
{
    public class ReceiverRepository : Repository<Receiver>, IReceiverRepository
    {
        private readonly AppDBContext _context;

        public ReceiverRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

    }
}