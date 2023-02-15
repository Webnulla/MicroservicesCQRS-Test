using MediatR;

namespace Product.Api.Resources.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Models.Product>>
    {
    }
}
