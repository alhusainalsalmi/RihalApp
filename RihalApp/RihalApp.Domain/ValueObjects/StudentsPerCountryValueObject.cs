using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.ValueObjects
{
    public sealed class StudentsPerCountryValueObject
    {
        public string CountryName { get; set; }
        public int NumberOfStudents { get; set; }
    }
}