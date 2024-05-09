using System.ComponentModel.DataAnnotations;

namespace EShopAdminApplication.Models
{
    public class Concert
    {
        public Guid Id { get; set; }
        [Required]
        public string ConcertName { get; set; }
        [Required]
        public string ConcertDescription { get; set; }
        [Required]
        public string ConcertImage { get; set; }
        [Required]
        public double Rating { get; set; }
    }
}
