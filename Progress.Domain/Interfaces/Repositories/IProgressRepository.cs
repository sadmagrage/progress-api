using Progress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Domain.Interfaces.Repositories
{
    public interface IProgressRepository
    {
        Task<List<ProgressEntity>> FindAll();
        Task<ProgressEntity> FindById(Guid id);
        Task Save(ProgressEntity progress);
        Task Update(ProgressEntity progress);
        Task Delete(Guid id);
    }
}
