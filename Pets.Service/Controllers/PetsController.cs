using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pets.Common;
using Pets.Service.Models;

namespace Pets.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetProvider _provider;

        public PetsController(IPetProvider provider)
        {
            _provider = provider;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return _provider.GetPets();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            return _provider.GetPets().FirstOrDefault(p => p.Id == id);
        }

    }
}
