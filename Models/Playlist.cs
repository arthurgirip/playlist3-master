using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace playlistgenerator.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }
        public List<Song> songs { get; set; }
        public string genre { get; set; }
        //public string duration { get; set; }
    }
}
