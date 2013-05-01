using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExquisiteCMS.Data;
using ExquisiteCMS.Areas.Webpage.Data.Entities;
using ExquisiteCMS.Areas.Webpage.Data.Repositories.Interfaces;

namespace ExquisiteCMS.Areas.Webpage.Data.Repositories
{
    public class PageRepository : IPageRepository, IDisposable
    {
        private CMSContext context;

        public PageRepository(CMSContext context)
        {
            this.context = context;
        }

        public IEnumerable<Page> GetPages()
        {
            return context.Pages.ToList();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}