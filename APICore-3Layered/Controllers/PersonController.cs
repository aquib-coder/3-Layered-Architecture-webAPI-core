using DAL.Repository.Person;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore_3Layered.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonBLL _IPersonBLL;
        public PersonController(IPersonBLL _IpersonBLL)
        {
            _IPersonBLL = _IpersonBLL;
        }
        public IActionResult Index()
        {
            return Ok(_IPersonBLL.display());
        }
    }
}
