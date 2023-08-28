using System.ComponentModel.DataAnnotations;

namespace PractiseMVCproject3.Models
{
    public class Service
    {
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }

        public List<PricingService> PricingServices  { get; set; }
    }
}
