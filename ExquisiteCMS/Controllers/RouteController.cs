using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Data;
using ExquisiteCMS.Data.Repositories.Interfaces;
using ExquisiteCMS.Data.Repositories;

namespace ExquisiteCMS.Controllers
{
    public class RouteController : Controller
    {
        private IRouteRepository routeRepository;

        public RouteController()
        {
            this.routeRepository = new RouteRepository(new CMSContext());
        }

        // GET: /Route/

        public ActionResult Index()
        {
            return View(routeRepository.GetRoutes());
        }

        protected override void Dispose(bool disposing)
        {
            routeRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}