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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
