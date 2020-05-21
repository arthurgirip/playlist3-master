using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace playlist3.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        //[Column(TypeName ="nvchar(100)")]
        public string name { get; set; }

        //[Column(TypeName = "nvchar(100)")]
        public string Email { get; set; }

        //[Column(TypeName = "nvchar(100)")]
        public string Phone { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(UserId);
    }
}
