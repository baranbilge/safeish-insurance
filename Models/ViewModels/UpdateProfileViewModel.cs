using System.ComponentModel.DataAnnotations;

namespace Safeish.Models.ViewModels
{
    public class UpdateProfileViewModel
    {
        [Display(Name = "Telefon Numarası")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Alternatif Telefon")]
        public string? AlternativePhoneNumber { get; set; }

        [Display(Name = "Açık Adres")]
        public string? Address { get; set; }
    }
}
