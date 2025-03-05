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

namespace ABC.Infrastructure
{
    public class PaymentDetailRepository : Repository<PaymentDetail>, IPaymentDetailRepository
    {
        private readonly AppDBContext _context;
        public PaymentDetailRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
