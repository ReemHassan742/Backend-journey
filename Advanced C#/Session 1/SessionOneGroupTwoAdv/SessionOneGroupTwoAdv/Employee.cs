using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOneGroupTwoAdv
{
    internal class Employee : IComparable 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} :: {Id} :: {Salary}";
        }
        //EQUALS ==> Object member method
        //Caller
        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj; //Explicit casting [Unsafe]
            //Comapre Object state
            return (this.Id == employee?.Id) && (this.Name == employee?.Name) && (this.Salary == employee?.Salary);
        }

        public override int GetHashCode()
        {
            //Name = Mariam , Id =  10 , Salary = 1000
            //Name = Mariam , Salary =  10 , Id = 1000

            //Mariam.GetHashCode() + 10.GetHashCode() + 1000.GetHashCode()
            //091821083 + 10 + 1000

            return HashCode.Combine(this.Id, this.Name, this.Salary);
            //return this.Id.GetHashCode() + this.Salary.GetHashCode() + this.Name?.GetHashCode()??0;
        }
        //Compare based on Salary
        public int CompareTo(object? obj)
        {
            //Employee? employee = (Employee?)obj;//Unsafe
            //Is conditional operator 
            //return true , false
            //return true ==> 1] obj is Employee
                            //2] obj is from class inhiret from employee

            //if(obj is Employee employee) // obj is null , Any other type
            //{
            //    return this.Salary.CompareTo(employee?.Salary);
            //}
            //return 1;
            //As casting operator
            //Succeeded ==> 1] Obj is employee
                          //2] Obj is from class inhiret from employee

            Employee? employee = obj as Employee;
            return this.Salary.CompareTo(employee?.Salary);

        }









        //public static bool operator ==(Employee left, Employee right)
        //{
        //    //left.Name == right.Name && left.Salary == right.Salary && left.Id == right.Id
        //    return left.Equals(right) ;
        //    //return (left.Name == right.Name) && (left.Salary == right.Salary) && (left.Id == right.Id);
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    //left.Name != right.Name || left.Salary != right.Salary || left.Id != right.Id
        //    return !left.Equals(right) ;
        //    // return (left.Name != right.Name) || (left.Salary != right.Salary) || (left.Id != right.Id);
        //}
    }
}
