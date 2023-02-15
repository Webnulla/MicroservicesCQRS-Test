using MediatR;

namespace Product.Api.Resources.Queries
{
    public class GetProductById : IRequest<Models.Product>
    {
        public int ProductId { get; set; }
    }
}
