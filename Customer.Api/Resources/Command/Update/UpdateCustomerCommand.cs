using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Customer.Api.Resources.Command.Update
{
    public class UpdateCustomerCommand : IRequest<Models.Customer>
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
