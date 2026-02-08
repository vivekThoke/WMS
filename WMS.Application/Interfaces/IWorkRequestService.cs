using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Application.DTOs;
using WMS.Domain.Entities;

namespace WMS.Application.Interfaces
{
    public interface IWorkRequestService
    {
        Task<WorkRequest> CreateAsync(CreateWorkRequestDto dto);
        Task<IEnumerable<WorkRequest>> GetAllAsync();
        Task ApproveAsync(Guid requestId);
    }
}
