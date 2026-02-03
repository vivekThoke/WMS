using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Application.DTOs
{
    public class CreateWorkRequestDto
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
