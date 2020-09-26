using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Models
{
    public class BillBoardMusicList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Title {get; set; }
        public string song { get; set; }
        public string duration { get; set; }
        public int Genre { get; set; }
        public bool IsActiveMember { get; set;}
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
       
    }
}
