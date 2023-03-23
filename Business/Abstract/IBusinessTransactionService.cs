using Core.Service;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBusinessTransactionService : IServiceRepository<BusinessTransaction>
    {
    }
}
