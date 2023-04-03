using Microsoft.AspNetCore.Mvc;
using TraversalCore.Business.Concrete;
using TraversalCore.DataAccess.EntityFramework;

namespace TraversalCore.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values); 
        }
    }
}
