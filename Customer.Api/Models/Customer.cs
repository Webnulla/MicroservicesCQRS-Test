using System.ComponentModel.DataAnnotations;

namespace Customer.Api.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Phone { get; set; }
    }
}
