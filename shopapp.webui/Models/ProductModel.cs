using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Name", Prompt = "Enter product name")]
        [Required(ErrorMessage = "Name zorunlu bir alan.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "�r�n ismi 5-10 karakter aral���nda olmal�d�r.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunlu bir alan.")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Price zorunlu bir alan.")]
        [Range(1, 10000, ErrorMessage = "Price i�in 1-10000 aras�nda de�er girmelisiniz.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description zorunlu bir alan.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description 5-100 karakter aral���nda olmal�d�r.")]

        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl zorunlu bir alan.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}