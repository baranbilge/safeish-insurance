using System.ComponentModel.DataAnnotations;

namespace Safeish.Models.ViewModels
{
    public class GetQuoteViewModel
    {
        public int PackageId { get; set; }

        [Required(ErrorMessage = "Adınızı girmeniz zorunludur.")]
        [Display(Name = "Adınız")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadınızı girmeniz zorunludur.")]
        [Display(Name = "Soyadınız")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-posta adresinizi girmeniz zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta Adresiniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numaranızı girmeniz zorunludur.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        [Display(Name = "Telefon Numaranız")]
        public string PhoneNumber { get; set; }
    }
}
