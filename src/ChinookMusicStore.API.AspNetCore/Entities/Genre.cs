using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChinookMusicStore.API.AspNetCore.Entities
{
    [Table("genres")]
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
