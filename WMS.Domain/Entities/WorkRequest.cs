using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Enums;

namespace WMS.Domain.Entities
{
    public class WorkRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedByUserId { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public RequestStatus Status { get; set; }
    }
}
