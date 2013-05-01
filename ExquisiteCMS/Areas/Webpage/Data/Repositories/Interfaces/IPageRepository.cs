using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExquisiteCMS.Areas.Webpage.Data.Entities;

namespace ExquisiteCMS.Areas.Webpage.Data.Repositories.Interfaces
{
    interface IPageRepository : IDisposable
    {
        IEnumerable<Page> GetPages();
    }
}
