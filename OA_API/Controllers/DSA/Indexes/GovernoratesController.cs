using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_API.Controllers.DSA.Indexes
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "indexes-control")]
    public class GovernoratesController : BaseController<Governorate>
    {

        public GovernoratesController(AppDbContext context) : base(context)
        {

        }

    }
}
