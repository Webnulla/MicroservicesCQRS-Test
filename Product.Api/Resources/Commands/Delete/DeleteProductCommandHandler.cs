using MediatR;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;

namespace Product.Api.Resources.Commands.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Models.Product>
    {
        private readonly ProductDbContext _context;

        public DeleteProductCommandHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == request.ProductId);

            if (product is null)
                return default;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
