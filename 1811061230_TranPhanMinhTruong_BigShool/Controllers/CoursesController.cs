using _1811061230_TranPhanMinhTruong_BigShool.Models;
using _1811061230_TranPhanMinhTruong_BigShool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811061230_TranPhanMinhTruong_BigShool.Controllers
{
    
    public class CoursesController : Controller
    { 
        private readonly ApplicationDbContext _dbContext;
    public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);

            
        }
    }
}