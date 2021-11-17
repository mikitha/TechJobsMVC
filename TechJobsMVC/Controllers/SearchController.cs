using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVC.Data;
using TechJobsMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Job> jobs = new List<Job>();
            ViewBag.jobs = jobs;
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        // TODO #3: Create an action method to process a search request and render the updated search view. 

        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.ColumnChoices;
            List<Job> jobs;
            if (searchType.Equals("all"))
            {

                jobs = JobData.FindByValue(searchTerm);
                ViewBag.title = "All Jobs";
                ViewBag.jobs = jobs;
                //store results in a "jobs" list
                return View("Index");

                //give it to the Search/Index via VIewBag
            }

            else
            {
                jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                ViewBag.title = "Jobs with " + searchType + ": " + searchTerm;
                ViewBag.jobs = jobs;
                return View("Index");

                //send parameters to FindByColumnAndValue
                //store in a "jobs" list
                //pass to Search/Index via Viewbag
            }

        }


    }
}
