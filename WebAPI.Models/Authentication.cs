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
    public partial class Authentication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime LocalDate { get; set; }

        [Required]
        public string UserAgent { get; set; }

        [Required]
        public string IpAdress { get; set; }

        public string Token { get; set; }

        public TypeToken TypeToken { get; set; }
        public bool IsValid { get; set; }

        [Required]
        public virtual Account _Account { get; set; }
    }
}
