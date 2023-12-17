using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.C_LiskovSubstitution
{
    /// <summary>
    /// Base Class Object can Represent any Children Classes Without any errors
    /// </summary>
    public class LiskovSubstitution
    {

        public LiskovSubstitution()
        {
            Post post;

            post = new Post();
            post = new SimplePost();
            post = new LinkPost();
            post = new MentionPost();


            List<IEmployee> employees=new List<IEmployee>();

            employees.Add(new AdministrationEmployee(1, "Admin1"));
            employees.Add(new AdministrationEmployee(2, "Admin2"));
            employees.Add(new RegularEmployee(3, "HR"));
            employees.Add(new RegularEmployee(4, "Support"));
            employees.Add(new RegularEmployee(5, "IT"));

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        #region Post Example


        public class Post
        {
            public string Name { get; set; }

            public virtual string CreatePost()
            {
                return "Base Post";
            }
        }

        public class SimplePost:Post
        {
            public override string CreatePost()
            {
                return "Simple Post";
            }
        }

        public class LinkPost : Post
        {
            public override string CreatePost()
            {
                return "Link Post";
            }
        }

        public class MentionPost : Post
        {
            public override string CreatePost()
            {
                return "Mention Post";
            }
        }

        #endregion

        #region Employee Example

        public interface IEmployee
        {

            int Id { get; set; }
            string Name { get; set; }

            decimal GetMinSalary();

        }

        public class Employee : IEmployee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Employee(int id,string name)
            {
                Id = id;
                Name = name;
            }

            public virtual decimal GetMinSalary()
            {
                return 0;
            }

            public override string ToString()
            {
                return $"Id={Id},Name={Name},MinSalary={GetMinSalary()}";
            }
        }

        public class AdministrationEmployee:Employee
        {
            public AdministrationEmployee(int id,string name):base(id,name)
            {
                
            }

            public override decimal GetMinSalary()
            {
                return 5000;
            }
        }

        public class RegularEmployee:Employee
        {
            public RegularEmployee(int id, string name) : base(id, name)
            {

            }
            public override decimal GetMinSalary()
            {
                return 2000;
            }
        }

        #endregion
    }
}
