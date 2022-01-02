using System;

namespace c_sharp_odev_constructor
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee employee1 = new Employee();
            employee1.firstName = "John";
            employee1.lastName = "Doe";
            employee1.number = 10001;
            employee1.department = "IT";

            employee1.PrintEmployeeInformation();


            Console.WriteLine("");

            Employee employee2 = new Employee();
            employee2.firstName = "Bilbo";
            employee2.lastName = "Baggins";
            employee2.number = 123456;
            employee2.department = "HR";

            employee2.PrintEmployeeInformation();


            Console.WriteLine("");


            Employee employee3 = new Employee("Frodo", "Baggins", 2000, "Support");
            employee3.PrintEmployeeInformation();

            Console.WriteLine("");

            Employee employee4 = new Employee("Elrond", "Rivendell");
            employee4.PrintEmployeeInformation();















        }
    }





    class Employee
    {
        public string firstName;
        public string lastName;
        public int number;
        public string department;

        public Employee(string firstName, string lastName, int number, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.number = number;
            this.department = department;

        }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }



        public void PrintEmployeeInformation()
        {
 
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Department: {0}", department);
        }

    }






}
