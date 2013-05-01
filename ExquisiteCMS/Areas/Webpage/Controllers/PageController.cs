using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExquisiteCMS.Areas.Webpage.Data.Entities;
using ExquisiteCMS.Areas.Webpage.Data.Repositories;
using ExquisiteCMS.Areas.Webpage.Data.Repositories.Interfaces;
using ExquisiteCMS.Data;

namespace ExquisiteCMS.Areas.Webpage.Controllers
{
    public class PageController : Controller
    {
        private IPageRepository pageRepository;

        public PageController()
        {
            this.pageRepository = new PageRepository(new CMSContext());
        }

        public ActionResult Index()
        {
            return View(this.pageRepository.GetPages());
        }

    }
}
