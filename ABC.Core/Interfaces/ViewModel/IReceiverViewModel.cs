using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Interfaces.ViewModel
{
    public interface IReceiverViewModel
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string Country { get; set; }
    }
}
