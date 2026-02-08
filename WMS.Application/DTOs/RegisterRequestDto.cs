using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Application.DTOs
{
    public class RegisterRequestDto
    {
        public string email { get; set; } = null!;
        public string password { get; set; } = null!;
    }
}
