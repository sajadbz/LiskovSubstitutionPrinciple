using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_E02.Interface
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
    }
}
