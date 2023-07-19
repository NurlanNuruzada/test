using Fiorella.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Aplication.Abstraction.Repostiory
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity, new()
    {
        Task addAsync(T entity);
        Task addRangeAsync(ICollection<T> enitites);
        void updateAsync(T entity);
        void deleteAsync(T entity);
        Task RemoveAsync(ICollection<T> enitites);
        Task SaveChangesAsync();
    }
}
