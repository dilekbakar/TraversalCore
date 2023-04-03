using Microsoft.AspNetCore.Mvc;
using TraversalCore.Business.Concrete;
using TraversalCore.DataAccess.EntityFramework;

namespace TraversalCore.ViewComponents.Default
{
    public class _Testimonial:  ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
