using ABC.Core.DTOs;
using ABC.Core.Entities;
using ABC.Core.Interfaces.Repository;
using ABC.Infrastructure.Identity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Infrastructure.Repositories
{
    public class RateRepository : Repository<Rate>, IRateRepository
    {
        private readonly AppDBContext _context;
        public RateRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
