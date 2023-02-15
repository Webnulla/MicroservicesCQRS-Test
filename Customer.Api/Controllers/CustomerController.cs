using Customer.Api.Resources.Command.Create;
using Customer.Api.Resources.Command.Delete;
using Customer.Api.Resources.Command.Update;
using Customer.Api.Resources.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Api.Controllers
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

        [HttpGet]
        public async Task<IResult> GetAllCustomers()
        {
            try
            {
                var command = new GetAllCustomersQuery();
                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();

            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IResult> GetCustomerById(int id)
        {
            try
            {
                var command = new GetCustomerByIdQuery() {CustomerId = id};
                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IResult> CreateCustomer(Models.Customer customer)
        {
            try
            {
                var command = new CreateCustomerCommand()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                };

                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> UpdateCustomer(Models.Customer customer)
        {
            try
            {
                var command = new UpdateCustomerCommand()
                {
                    CustomerId = customer.CustomerId,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                };

                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IResult> DeleteCustomer(int id)
        {
            try
            {
                var command = new DeleteCustomerCommand() { CustomerId = id };
                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }
    }
}
