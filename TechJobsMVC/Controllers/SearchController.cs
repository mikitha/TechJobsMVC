using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        // TODO #3: Create an action method to process a search request and render the updated search view. 

       public IActionResult Results(string searchType, string searchTerm)
        {
            if(searchType.Equals(" ") && searchTerm.Equals(" "))
            {

                //This code probs exists in the search controller
               // call FindAll()

                //store results in a "jobs" list

                //give it to the Search/Index via VIewBag
            }

            else
            {
                //send parameters to FindByColumnAndValue
                //store in a "jobs" list
                //pass to Search/Index via Viewbag
            }

        }
       
    }
}
