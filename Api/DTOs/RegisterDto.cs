using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password {get; set;}
    }
}