using System.Threading.Tasks;
using Examen2.Domain.Core.CoreEntities;
namespace Examen2.Domain.Core.Repositories
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot :
    AggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}