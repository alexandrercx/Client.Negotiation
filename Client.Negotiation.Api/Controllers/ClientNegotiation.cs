using Client.Negotiation.Application.Interfaces;
using Client.Negotiation.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Client.Negotiation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientNegotiation : ControllerBase
    {

        private readonly ILogger<ClientNegotiation> _logger;
        private readonly IProductClientApp _financialProductApp;

        public ClientNegotiation(ILogger<ClientNegotiation> logger, IProductClientApp financialProductApp)
        {
            _logger = logger;
            _financialProductApp = financialProductApp;
        }

        [HttpPost]
        [Route("ToBuy")]
        [ProducesResponseType((int)HttpStatusCode.OK,Type = typeof(FinancialProductOutputModel))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult ToBuy([Required][FromBody] AddProductClientInputModel productFinancialModel)
        {
            try
            {
                var response = _financialProductApp.AddProductClient(productFinancialModel);
                return Ok(response);
            }catch(FormatException fe)
            {
                return StatusCode((int)HttpStatusCode.BadRequest,fe.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500,"Internal Error");
            }
           
        }

        [HttpPost]
        [Route("ToSell")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult ToSel([Required][FromBody] AddProductClientInputModel productFinancialModel)
        {
            try
            {
                
                return Ok("Success");
            }
            catch (FormatException fe)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, fe.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Error");
            }

        }
    }
}
