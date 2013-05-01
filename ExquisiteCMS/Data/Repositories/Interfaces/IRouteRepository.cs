using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExquisiteCMS.Data.Entities;

namespace ExquisiteCMS.Data.Repositories.Interfaces
{
    interface IRouteRepository : IDisposable
    {
        IEnumerable<Route> GetRoutes();
    }
}
