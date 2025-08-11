using Microsoft.EntityFrameworkCore;
using Progress.Data.Context;
using Progress.Domain.Entities;
using Progress.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Data.Repositories
{
    public class ProgressRepository : IProgressRepository
    {
        private readonly ApplicationContext _context;

        public ProgressRepository(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<List<ProgressEntity>> FindAll() 
        {
            var progress = await _context.FindAsync<List<ProgressEntity>>();

            return progress;
        }

        public async Task<ProgressEntity> FindById(Guid id)
        {
            var progress = await _context.Progress.Where(progress => progress.Id.Equals(id)).FirstAsync();

            return progress;
        }

        public async Task Save(ProgressEntity progress)
        {
            await _context.Progress.AddAsync(progress);

            await _context.SaveChangesAsync();
        }

        public async Task Update(ProgressEntity progress)
        {
            await _context.Progress.AddAsync(progress);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            await _context.Progress.Where(progress => progress.Id.Equals(id)).ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }
    }
}
