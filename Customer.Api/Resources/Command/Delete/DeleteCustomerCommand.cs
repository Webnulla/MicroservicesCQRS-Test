using MediatR;

namespace Customer.Api.Resources.Command.Delete
{
    public class DeleteCustomerCommand : IRequest<Models.Customer>
    {
        public int CustomerId { get; set; }
    }
}
