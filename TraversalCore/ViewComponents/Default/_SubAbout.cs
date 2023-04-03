using Microsoft.AspNetCore.Mvc;
using TraversalCore.Business.Concrete;
using TraversalCore.DataAccess.EntityFramework;

namespace TraversalCore.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke() {

            var values = subAboutManager.TGetList();
            return View(values); 
        }

    }
}
