using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Entities
{
    public class BaseEntity
    {
        
        public DateTime CreationDate { get; set; }     
        public DateTime UpdatedDate { get; set; }
    }
}
