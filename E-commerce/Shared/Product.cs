using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  E_commerce.Shared
{
    public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; } = "https://via.placeholder.com/300*300" ;
    public bool isPublic { get; set; }  
    public bool isDeleted { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public List<ProductVariant> Variants { get; set; }= new List<ProductVariant>();
   
    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateUpdated { get; set; }  
        public int Views { get; set; }

}
}
