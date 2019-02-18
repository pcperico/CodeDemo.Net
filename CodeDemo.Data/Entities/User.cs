using CodeDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Data.Entities
{
    [Table("User")]
    public class User:EntityBase
    {        
        public int PeopleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [ForeignKey("PeopleId")]
        public virtual People People { get; set; }
    }
}
