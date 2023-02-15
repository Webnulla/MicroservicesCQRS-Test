using Customer.Api.Data;
using MediatR;

namespace Customer.Api.Resources.Command.Delete
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Models.Customer>
    {
        private readonly CustomerDbContext _context;

        public DeleteCustomerCommandHandler(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Customer> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerId == request.CustomerId);

            if (customer is null)
                return default;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }
    }
}
