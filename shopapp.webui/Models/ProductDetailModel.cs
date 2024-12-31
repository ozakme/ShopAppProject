using shopapp.entity;
using System.Collections.Generic;

namespace shopapp.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
