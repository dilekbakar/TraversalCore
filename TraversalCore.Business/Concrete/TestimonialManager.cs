using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Business.Abstract;
using TraversalCore.DataAccess.Abstract;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();   
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
