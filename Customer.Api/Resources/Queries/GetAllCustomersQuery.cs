using MediatR;

namespace Customer.Api.Resources.Queries
{
    public class GetAllCustomersQuery : IRequest<IEnumerable<Models.Customer>>
    {
    }
}
