using MediatR;

namespace Customer.Api.Resources.Queries
{
    public class GetCustomerByIdQuery : IRequest<Models.Customer>
    {
        public int CustomerId { get; set; }
    }
}
