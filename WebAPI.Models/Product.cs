using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Models
{
    [Table("Product")]
    public partial class Product
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(400)]
        [MinLength(10, ErrorMessage = "Precisa ter no minímo 10 caracteres")]
        public string Name { get; set; }
        [MinLength(1)]
        public float Price { get; set; }
        [MinLength(1)]
        public int TotalProduct { get;  set; }
        public Category Category { get; set; }

        public virtual Account Account { get; set; }   
        public virtual List<ProductImages> ProductImages { get; set; }
        public virtual List<RequestProducts> RequestProducts { get; set; }

    }

    [Table("ProductImages")]
    public partial class ProductImages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdProduct { get; set; }
        public int IdFileImage { get; set; }
        [Required]
        [ForeignKey(nameof(IdProduct))]
        public virtual Product Product { get; set; }
        [Required]
        [ForeignKey(nameof(IdFileImage))]
        public virtual FileImage FileImage { get; set; }


    }
}
