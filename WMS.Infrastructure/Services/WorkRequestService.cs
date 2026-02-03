using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<WorkRequest> CreateAsync(WorkRequest request)
        {
            request.Id = Guid.NewGuid();
            request.CreatedAt = DateTime.UtcNow;
            request.status = RequestStatus.Pending;

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
