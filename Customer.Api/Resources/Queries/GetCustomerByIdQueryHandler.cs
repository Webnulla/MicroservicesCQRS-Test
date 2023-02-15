using Customer.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Customer.Api.Resources.Queries
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Models.Customer>
    {
        private readonly CustomerDbContext _context;

        public GetCustomerByIdQueryHandler(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken) =>
            await _context.Customers.FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId, cancellationToken);
    }
}
