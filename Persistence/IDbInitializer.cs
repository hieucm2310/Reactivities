using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}