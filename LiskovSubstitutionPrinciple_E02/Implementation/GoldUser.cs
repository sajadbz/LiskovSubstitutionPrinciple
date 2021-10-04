using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple_E02.Abstract;

namespace LiskovSubstitutionPrinciple_E02.Implementation
{
    public class GoldUser : User
    {
        public GoldUser(int id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * .1M;
        }
    }
}
