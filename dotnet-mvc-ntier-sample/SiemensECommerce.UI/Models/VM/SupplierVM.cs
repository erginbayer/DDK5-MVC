using System.ComponentModel.DataAnnotations;

namespace SiemensECommerce.UI.Models.VM
{
    public class SupplierVM
    {
        [Required(ErrorMessage = "CompanyName alanı boş bırakılamaz")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "ContactName alanı boş bırakılamaz")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "ContactTitle alanı boş bırakılamaz")]
        public string ContactTitle { get; set; }
    }
}
