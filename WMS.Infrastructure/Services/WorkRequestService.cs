using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WMS.Application.DTOs;
using WMS.Application.Interfaces;
using WMS.Domain.Entities;
using WMS.Domain.Enums;
using WMS.Infrastructure.Data;

namespace WMS.Infrastructure.Services
{
    public class WorkRequestService : IWorkRequestService
    {
        private readonly WmsDbContext _dbContext;

        public WorkRequestService(WmsDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<WorkRequest> CreateAsync(CreateWorkRequestDto dto)
        {
            var request = new WorkRequest
            {
                Id = Guid.NewGuid(),
                Title = dto.Title,
                Description = dto.Description,
                CreatedAt = DateTime.UtcNow,
                Status = RequestStatus.Pending
            };
            

            _dbContext.WorkRequests.Add(request);

            await _dbContext.SaveChangesAsync();

            return request;
        }

        public async Task<IEnumerable<WorkRequest>> GetAllAsync()
        {
            return await _dbContext.WorkRequests.AsNoTracking().ToListAsync();
        }

    }
}
