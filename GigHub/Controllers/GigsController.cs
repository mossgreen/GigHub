using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub.Models;
using GigHub.ViewModels;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
            // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel); // this view is under views/gigs/create
        }
    }
}