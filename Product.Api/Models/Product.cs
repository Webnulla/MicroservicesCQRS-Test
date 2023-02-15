namespace Product.Api.Models
{
    public class Product
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
