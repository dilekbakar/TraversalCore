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

    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public SubAbout GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
           return _subAboutDal.GetList();   
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
