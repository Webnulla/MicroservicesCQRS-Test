using Customer.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Customer.Api.Resources.Queries
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Models.Customer>>
    {
        private readonly CustomerDbContext _context;

        public GetAllCustomersQueryHandler(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken) => 
            await _context.Customers.ToListAsync();
        
    }
}
