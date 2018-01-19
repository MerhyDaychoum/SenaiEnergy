using SenaiEnergy.BO;
using SenaiEnergy.Models.EquimentViewModel;
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
    public class EquipmentController : ApiController
    {
        private EquipmentBO _equipmentBo;

        public EquipmentController()
        {
            _equipmentBo = new EquipmentBO();
        }

        [HttpPost]
        [Route("equipments")]
        public async Task<IHttpActionResult> CreateEquipment(CreateEquimentViewModel model)
        {
            var result = await _equipmentBo.CreateEquipment(model.ToEquipment());
            if (result != null)
            {
                return Ok(new ViewEquipmentViewModel(result));
            }
            return StatusCode((HttpStatusCode)422);
        }

        [HttpGet]
        [Route("equipments")]
        public async Task<IHttpActionResult> ListAllEquipments()
        {
            var result = await _equipmentBo.ListAllEquipment();
            if(result != null)
            {
                return Ok(ViewEquipmentViewModel.ToList(result));
            }
            return NotFound();
        }
    }
}