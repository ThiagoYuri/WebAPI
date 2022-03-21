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
    public partial class Account
    {
        /// <summary>
        /// 
        /// </summary>
        [Key,Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(400)]
        [MinLength(10,ErrorMessage = "Precisa ter no minímo 10 caracteres")]
        public string Name { get; set; }

        [StringLength(400)]
        [MinLength(20, ErrorMessage = "Precisa ter no minímo 20 caracteres")]
        public string Email { get;  set; }

        [StringLength(400)]
        [MinLength(5, ErrorMessage = "Precisa ter no minímo 5 caracteres")]
        public string Password { get;  set; }
    
        public TypeAccount Type_Account { get; set; }
        
        public double Money { get;  set; }
        /// <summary>
        /// Navigations
        /// </summary>
        public virtual FileImage ImageAccount { get; set; }
        public virtual List<Request> RequestsList { get; set; }


    }
}
