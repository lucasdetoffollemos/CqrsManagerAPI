using System.ComponentModel.DataAnnotations;

namespace CqrsManagerMinimalAPI.Queries.Requests
{
    public class FindProductByIdRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
