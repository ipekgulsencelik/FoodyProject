using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDAL _addressDAL;

        public AddressManager(IAddressDAL addressDAL)
        {
            _addressDAL = addressDAL;
        }

        public void TDelete(int id)
        {
            _addressDAL.Delete(id);
        }

        public List<Address> TGetAll()
        {
            return _addressDAL.GetAll();
        }

        public Address TGetByID(int id)
        {
            return _addressDAL.GetByID(id);
        }

        public void TInsert(Address entity)
        {
            _addressDAL.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressDAL.Update(entity);
        }
    }
}