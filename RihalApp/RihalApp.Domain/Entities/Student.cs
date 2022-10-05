using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Entities
{
    [Table("students")]
    public class Student : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public int CountryId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Class Class { get; set; }
        public virtual Country Country { get; set; }

        
    }

}
