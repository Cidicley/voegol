using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangersController : ControllerBase
    {
        private readonly IPassangerService _passangerService;

        public PassangersController()
        {
        }
    }
}