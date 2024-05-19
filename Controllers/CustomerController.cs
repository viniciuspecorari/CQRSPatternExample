using CQRSPatternEx.Domain.Commands.Handler;
using CQRSPatternEx.Domain.Commands.Requests;
using CQRSPatternEx.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPatternEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateCustomerResponse> Create([FromBody] CreateCustomerRequest request)
        {            
            return await _mediator.Send(request);
        }
    }
}
