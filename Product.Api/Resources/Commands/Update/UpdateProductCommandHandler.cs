using MediatR;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;

namespace Product.Api.Resources.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Models.Product>
    {
        private readonly ProductDbContext _context;

        public UpdateProductCommandHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == request.ProductId);

            if (product is null)
                return default;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;

            await _context.SaveChangesAsync();
            return product;
        }
    }
}
