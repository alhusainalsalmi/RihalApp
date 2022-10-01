using RihalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.DataAccess.DbDataSeeder
{
    internal sealed class ClassesTableData
    {
        public static readonly List<Class> ClassesData = new List<Class>()
        {
            new Class(){Id=1, Name="COMP103"},
            new Class(){Id=2, Name="COMP105"},
            new Class(){Id=3,Name="COMP110"}
        };
    }
}
