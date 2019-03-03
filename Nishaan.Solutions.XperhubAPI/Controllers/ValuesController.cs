using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nishaan.Solutions.XperhubAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.Factory.StartNew(()=>
            { 
                return new OkObjectResult(new
                {
                    Message = "This is a WAHEGURU creation",
                    Id = 1,
                    Creator = "Waheguru"
                });
            });
        }
    }
}