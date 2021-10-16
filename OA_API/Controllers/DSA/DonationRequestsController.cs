using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Domin.DSA;
using OA.Domin.RequestFeatures;
using OA.Domin.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_API.Controllers.DSA
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "donations-control")]
    public class DonationRequestsController : BaseController<DonationRequest>
    {
        public DonationRequestsController(AppDbContext context) : base(context)
        {

        }

        public async override Task<IActionResult> Create(DonationRequest entity)
        {
            return await Task.FromResult(BadRequest());
        }

       
    }
}
