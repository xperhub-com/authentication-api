using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nishaan.Solutions.XperhubAPI.Data;
using Nishaan.Solutions.XperhubAPI.Helpers;
using Nishaan.Solutions.XperhubAPI.Models.Entities;
using Nishaan.Solutions.XperhubAPI.ViewModels;

namespace Nishaan.Solutions.XperhubAPI.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;

        public RolesController(ApplicationDbContext appDbContext, RoleManager<AppRole> roleManager, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _roleManager = roleManager;
            _mapper = mapper;
        }


        // POST api/roles
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRole = _mapper.Map<AppRole>(model);

            var result = await _roleManager.CreateAsync(userRole);

            if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

            //await _appDbContext.Customers.AddAsync(new Customer { IdentityId = userIdentity.Id, Location = model.Location });
            //await _appDbContext.SaveChangesAsync();

            return new OkObjectResult("Role created");
        }
    }
}