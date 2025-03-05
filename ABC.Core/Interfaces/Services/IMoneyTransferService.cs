using ABC.Core.DTOs;
using ABC.Core.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Interfaces.Services
{
    public interface IMoneyTransferService
    {
        Task<IMoneyTransferViewModel> SendMoney(IMoneyTransferViewModel model);
    }
}
