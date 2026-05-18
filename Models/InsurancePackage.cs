using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safeish.Models
{
    public class InsurancePackage
    {
        public int Id { get; set; }

        [Required]
        public int InsuranceTypeId { get; set; }

        [ForeignKey("InsuranceTypeId")]
        public virtual InsuranceType InsuranceType { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CoverageAmount { get; set; }

        public string Features { get; set; }

        public virtual ICollection<UserPolicy> Policies { get; set; }
    }
}
