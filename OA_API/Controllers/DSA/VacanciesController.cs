using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Domin.DSA;

namespace OA_API.Controllers.DSA
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "donations-control")]
    public class VacanciesController : BaseController<Vacancy>
    {
        public VacanciesController(AppDbContext context) : base(context)
        {

        }
    }
}
