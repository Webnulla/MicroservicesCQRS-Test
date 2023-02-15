using MediatR;
using Microsoft.EntityFrameworkCore;
using Product.Api.Data;

namespace Product.Api.Resources.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Models.Product>>
    {
        private readonly ProductDbContext _context;

        public GetAllProductsQueryHandler(ProductDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Models.Product>> Handle(GetAllProductsQuery request,
            CancellationToken cancellationToken) =>
            await _context.Products.ToListAsync();

    }
}
