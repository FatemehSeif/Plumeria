using System.ComponentModel.DataAnnotations;

namespace Admin.Endpoint.ViewModels.Catalogs
{
    public class CatalogTypeViewModel
    {
        public int Id { get; set; }
        [Display(Name ="نام دسته بندی")]
        [Required]
        [MaxLength(3,ErrorMessage ="حداکثر کارکتر باید 100 باشد")]
        public string Type { get; set; }
        public int? ParentCatalogTypeId { get; set; } 
    }
}
