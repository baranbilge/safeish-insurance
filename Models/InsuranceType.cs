using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Safeish.Models
{
    public class InsuranceType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }

        public virtual ICollection<InsurancePackage> Packages { get; set; }
    }
}
