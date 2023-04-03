using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DataAccess.Abstract;
using TraversalCore.DataAccess.Repository;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.DataAccess.EntityFramework
{
    public class EFDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
    }
}
