using Progress.Application.DTO.Requests;
using Progress.Application.Interfaces;
using Progress.Domain.Entities;
using Progress.Domain.Exceptions;
using Progress.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Application.Services
{
    public class ProgressService : IProgressService
    {
        private readonly IProgressRepository _progressRepository;

        public ProgressService(IProgressRepository progressRepository)
        {
            _progressRepository = progressRepository;
        }

        public async Task<List<ProgressEntity>> FindAll()
        {
            var progress = await _progressRepository.FindAll();

            return progress;
        }

        public async Task<ProgressEntity> FindById(Guid id)
        {
            var progress = await _progressRepository.FindById(id);

            if (progress == null) throw new ProgressNotFoundException("Progress not found.");

            return progress;
        }

        public async Task Save(ProgressRequest progressRequest)
        {
            var progress = new ProgressEntity { Time = progressRequest.Time, Type = progressRequest.Type };

            await _progressRepository.Save(progress);
        }

        public async Task Update(Guid id, ProgressRequest progressRequest)
        {
            var progress = await _progressRepository.FindById(id);

            if (progress == null) throw new ProgressNotFoundException("Progress not found.");

            var newProgress = new ProgressEntity { Id = progress.Id, Time = progressRequest.Time, Type = progressRequest.Type };

            await _progressRepository.Update(newProgress);
        }

        public async Task Delete(Guid id)
        {
            var progress = await _progressRepository.FindById(id);

            if (progress == null) throw new ProgressNotFoundException("Progress not found.");

            await _progressRepository.Delete(id);
        }
    }
}
