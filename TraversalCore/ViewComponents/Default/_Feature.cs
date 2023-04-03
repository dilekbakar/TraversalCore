using Microsoft.AspNetCore.Mvc;
using TraversalCore.Business.Concrete;
using TraversalCore.DataAccess.Concrete;
using TraversalCore.DataAccess.EntityFramework;

namespace TraversalCore.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
           var values = featureManager.TGetList();
         //  ViewBag.image1=featureManager.
             return View(values);
        }
    }
}
