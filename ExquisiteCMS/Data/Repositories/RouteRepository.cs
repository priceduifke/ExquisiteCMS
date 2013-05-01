using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Data.Repositories.Interfaces;

namespace ExquisiteCMS.Data.Repositories
{
    public class RouteRepository : IRouteRepository, IDisposable
    {
        private CMSContext context;

        public RouteRepository(CMSContext context)
        {
            this.context = context;
        }

        public IEnumerable<Route> GetRoutes()
        {
            return context.Routes.ToList();
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