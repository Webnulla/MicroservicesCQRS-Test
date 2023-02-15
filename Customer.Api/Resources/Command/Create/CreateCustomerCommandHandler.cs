using Customer.Api.Data;
using MediatR;

namespace Customer.Api.Resources.Command.Create
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Models.Customer>
    {
        private readonly CustomerDbContext _context;

        public CreateCustomerCommandHandler(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<Models.Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Models.Customer
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }
    }
}
