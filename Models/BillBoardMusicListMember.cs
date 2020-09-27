using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Models
{
    public class BillBoardMusicListMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public bool IsActiveMember { get; set;}
        public DateTime Membersince { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
       }
}
