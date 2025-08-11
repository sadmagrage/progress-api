using Progress.Application.DTO.Requests;
using Progress.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Application.Interfaces
{
    public interface IProgressService
    {
        Task<List<ProgressEntity>> FindAll();
        Task<ProgressEntity> FindById(Guid id);
        Task Save(ProgressRequest progressRequest);
        Task Update(ProgressRequest progressRequest);
        Task Delete(Guid id);
    }
}
