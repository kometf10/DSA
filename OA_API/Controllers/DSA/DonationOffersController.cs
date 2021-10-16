using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.DataAccess;
using OA.Domin.DSA;
using OA.Services.DSA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA_API.Controllers.DSA
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "donations-control")]
    public class DonationOffersController : BaseController<DonationOffer>
    {
        private IDonationService DonationService;
        public DonationOffersController(AppDbContext context, IDonationService donationService) : base(context)
        {
            DonationService = donationService;
        }

        public async override Task<IActionResult> Create(DonationOffer entity)
        {
            return await Task.FromResult(BadRequest());
        }

        public async override Task<IActionResult> Update(DonationOffer donationOffer)
        {
 
            var result = DonationService.UpdateDonationOffer(donationOffer);

            return await Task.FromResult(Ok(result));
        }

    }
}
