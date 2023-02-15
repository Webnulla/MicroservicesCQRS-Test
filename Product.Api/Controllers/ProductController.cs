using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product.Api.Resources.Commands.Create;
using Product.Api.Resources.Commands.Delete;
using Product.Api.Resources.Commands.Update;
using Product.Api.Resources.Queries;


namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IResult> GetAllProducts()
        {
            try
            {
                var command = new GetAllProductsQuery();
                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IResult> GetProductById(int id)
        {
            try
            {
                var command = new GetProductById() { ProductId = id };
                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IResult> CreateProduct(Models.Product product)
        {
            try
            {
                var command = new CreateProductCommand()
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
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
        public async Task<IResult> UpdateProduct(Models.Product product)
        {
            try
            {
                var command = new UpdateProductCommand()
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                };

                var response = await _mediator.Send(command);

                return response is not null ? Results.Ok(response) : Results.NotFound();
            }
            catch (Exception e)
            {
                return Results.BadRequest(e.Message);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            try
            {
                var command = new DeleteProductCommand() { ProductId = id };
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
