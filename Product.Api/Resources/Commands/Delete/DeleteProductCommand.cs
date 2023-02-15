using MediatR;

namespace Product.Api.Resources.Commands.Delete
{
    public class DeleteProductCommand : IRequest<Models.Product>
    {
        public int ProductId { get; set; }
    }
}
