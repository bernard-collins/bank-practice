﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };



            return View(viewModel);
        }

        //These are not advised when Passing data to Views
        //ViewData["Movie"] = movie;
        //ViewBag.Movie = movie;

        //var viewResult = new ViewResult();
        //viewResult.ViewData.Model;

        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    return View(movie);
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}


        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageInde={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}