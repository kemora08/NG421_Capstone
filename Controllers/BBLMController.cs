using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BBLMController : ControllerBase
    {
       private ApplicationDbContext _context;
       public BBLMController(ApplicationDbContext context){
           _context = context;
       }
        [HttpGet]
        public IEnumerable<BillBoardMusicListMember> Get()
        {
           return _context.BillBoardMusicListMembers.ToArray();
        }
        [HttpPost]
        public BillBoardMusicListMember Post([FromBody] BillBoardMusicListMember Member)
        {
            _context.BillBoardMusicListMembers.Add(Member);
            _context.SaveChanges();
            return Member;
        }
    }
}
