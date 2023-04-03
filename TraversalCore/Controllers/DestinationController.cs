using Microsoft.AspNetCore.Mvc;
using TraversalCore.Business.Concrete;
using TraversalCore.DataAccess.EntityFramework;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Controllers
{
    public class DestinationController : Controller             
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
