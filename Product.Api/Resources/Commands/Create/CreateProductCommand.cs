using MediatR;

namespace Product.Api.Resources.Commands.Create
{
    public class CreateProductCommand : IRequest<Models.Product>
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }
    }
}
