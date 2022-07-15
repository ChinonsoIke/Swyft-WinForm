using Swyft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.Core.Interfaces
{
    public interface IAccountService : IEntityService
    {
        void Create(string type);
        Account Get(int id);
    }
}
