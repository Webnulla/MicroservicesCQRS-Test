using MediatR;
using Product.Api.Data;

namespace Product.Api.Resources.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Models.Product>
    {
        private readonly ProductDbContext _context;

        public CreateProductCommandHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Models.Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
