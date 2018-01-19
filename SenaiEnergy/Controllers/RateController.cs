using SenaiEnergy.BO;
using SenaiEnergy.Models.RateViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SenaiEnergy.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RateController : ApiController
    {
        private RateBO _rateBo;

        public RateController()
        {
            _rateBo = new RateBO();
        }

        [HttpPost]
        [Route("rates")]
        public async Task<IHttpActionResult> CreateRate(CreateRateViewModel model)
        {
            var result = await _rateBo.CreateRate(model.ToRate());
            if (result != null)
            {
                return Ok(new ViewRateViewModel(result));
            }
            return StatusCode((HttpStatusCode)422);
        }

        [HttpGet]
        [Route("rates")]
        public async Task<IHttpActionResult> ListAllRates()
        {
            var result = await _rateBo.ListAllRate();
            if (result != null)
            {
                return Ok(ViewRateViewModel.ToList(result));
            }
            return NotFound();
        }
    }
}