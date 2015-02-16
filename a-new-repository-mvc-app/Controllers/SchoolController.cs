using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using a_new_repository_mvc_app.Repository;
using a_new_repository_mvc_app.DAL;
using a_new_repository_mvc_app.Models;

namespace a_new_repository_mvc_app.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/
        public ActionResult Index()
        {
            var schoolRepository = new GenericRepository(new SchoolContext());
            var students = schoolRepository.GetQuery<Student>();

           
            return View();
        }
	}
}