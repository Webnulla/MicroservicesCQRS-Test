using Customer.Api.Data;
using MediatR;

namespace Customer.Api.Resources.Command.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Models.Customer>
    {
        private readonly CustomerDbContext _context;

        public UpdateCustomerCommandHandler(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerId == request.CustomerId);

            if (customer is null)
                return default;

            customer.Name = request.Name;
            customer.Email = request.Email;
            customer.Phone = request.Phone;

            await _context.SaveChangesAsync();

            return customer;
        }
    }
}
