using Core.Service;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressBookService : IServiceRepository<AddressBook>
    {
    }
}
