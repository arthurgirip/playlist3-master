using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace playlistgenerator.Models
{
    
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
