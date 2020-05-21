using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace playlistgenerator.Models
{

    public class User
    {
        [Key]
        public int UserId { get; set; }
        //[Column(TypeName ="nvchar(100)")]
        public string name { get; set; }

        public string password { get; set; }

        //[Column(TypeName = "nvchar(100)")]
        public string Email { get; set; }

        //[Column(TypeName = "nvchar(100)")]
        public string Phone { get; set; }

        public bool admin { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(UserId);
    }
}
