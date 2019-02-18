using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Data.Entities
{
    [Table("People")]
    public class People:EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
