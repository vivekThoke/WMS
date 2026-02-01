using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Entities;

namespace WMS.Application.Interfaces
{
    public interface IWorkRequestService
    {
        Task<WorkRequest> CreateAsync(WorkRequest request);
        Task<IEnumerable<WorkRequest>> GetAllAsync();
    }
}
