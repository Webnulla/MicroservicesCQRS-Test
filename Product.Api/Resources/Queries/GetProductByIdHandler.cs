using MediatR;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;

namespace Product.Api.Resources.Queries
{
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Models.Product>
    {
        private readonly ProductDbContext _context;

        public GetProductByIdHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Product> Handle(GetProductById request, CancellationToken cancellationToken) =>
            await _context.Products.FirstOrDefaultAsync(x => x.ProductId == request.ProductId, cancellationToken);

    }
}
