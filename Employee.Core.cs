using System;

namespace EmployeeApp
{
    partial class Employee
    {
        // Field data.
        private string empName;

        #region Ctors
        // Note use of constructor chaining.
        public Employee() { }
        public Employee(string name, int id, float pay)
          : this(name, 0, id, pay)
        { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        #endregion

        #region Properties 
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties,
        // however there is no need to do so for this example.
        public int ID { get; set; }
        public float Pay { get; set; }
        public int Age { get; set; }

        public string SocialSecurityNumber { get; } = "";
        #endregion
    }
}
