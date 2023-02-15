using MediatR;

namespace Product.Api.Resources.Commands.Update
{
    public class UpdateProductCommand : IRequest<Models.Product>
    {
        public int ProductId { get; set; }

        /// <summary>
        /// Название продукта
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Описание продукта
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Цена продукта
        /// </summary>
        public decimal Price { get; set; }
    }
}
