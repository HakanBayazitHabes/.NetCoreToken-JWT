using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.UnitOfWork
{
    public interface IUnitofWork
    {
        
        Task CommitAsync();

        void Commit();
    }
}
