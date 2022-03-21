using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models.Enum;

namespace WebAPI.Models
{
    [Table("Request")]
    public partial class Request
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public StatusRequest Status { get;  set; }

        //Navigation
        public virtual Account Account { get; set; }
        public virtual List<RequestProducts> RequestProducts { get; set; }

        //Method
        public void Pay()
        {
            if(Account.Money >= RequestTotalPrice())
            {
                Account.Money = Account.Money - RequestTotalPrice();
            }
            else
            {
                throw new Exception("Dinheiro do client insuficiente para realizar essa compra");
            }
        }

        public double RequestTotalPrice()=> RequestProducts.Sum(x => (x.TotalProducts * x.Product.Price));
        

        

    }
    [Table("RequestProducts")]
    public partial class RequestProducts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TotalProducts { get; set; }

        //Navigation
        public int IdProduct { get; set; }
        public int IdRequest { get; set; }
        [Required]
        [ForeignKey(nameof(IdProduct))]
        public virtual Product Product { get; set; }
        [Required]
        [ForeignKey(nameof(IdRequest))]
        public virtual Request Request { get; set; }

    }

}
