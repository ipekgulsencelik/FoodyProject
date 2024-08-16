using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class AddressDAL : GenericRepository<Address>, IAddressDAL
    {
        public AddressDAL(FoodyContext context) : base(context)
        {
        }
    }
}