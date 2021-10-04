using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple_E02.Interface;

namespace LiskovSubstitutionPrinciple_E02.Abstract
{
    public abstract class User : IUser, IUserBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        protected User(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public abstract decimal CalculateBonus();

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Bonus : {CalculateBonus()}";
        }
    }



}
