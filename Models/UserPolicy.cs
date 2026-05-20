using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safeish.Models
{
    public class UserPolicy
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int? InsurancePackageId { get; set; }

        [ForeignKey("InsurancePackageId")]
        public virtual InsurancePackage InsurancePackage { get; set; }

        public string PackageName { get; set; }

        public string Status { get; set; } = "Görüşme bekleniyor";

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
        public bool IsActive { get; set; }
    }
}
