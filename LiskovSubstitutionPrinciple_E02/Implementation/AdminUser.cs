using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple_E02.Abstract;
using LiskovSubstitutionPrinciple_E02.Interface;

namespace LiskovSubstitutionPrinciple_E02.Implementation
{
    public class AdminUser : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public AdminUser(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary : {Salary}";
        }
    }
}
