using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_NET_PRAC.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWT_NET_PRAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        

    }
}