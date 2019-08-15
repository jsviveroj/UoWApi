using DomainContracts.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product : Entity
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
