using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Customer.Api.Resources.Command.Create
{
    public class CreateCustomerCommand : IRequest<Models.Customer>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
