using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAfinal
{
    class Department

    {   
        public string depName { get; set; }

        public string managerName { get; set; }

        public List<Department> subDepartments { get; set; }

        public List<Employee> employees { get; set; }

        public static int countempoyee = 1;
        private static int countemployee;

        public Department(string depName, string manName)
        {
            this.depName = depName;
            this.managerName = manName;
            subDepartments = new List<Department>();
            employees = new List<Employee>();

        }
        static public Department buildSampleData()
        {
            {
                var root = new Department("Synergy", "Rhonda Smith"); // root/"Big Company"

                Department department1 = new Department("Finance", "Scott Dick");             
                root.subDepartments.Add(department1);
                Department department2 = new Department("IT", "Braith Lettice");
                root.subDepartments.Add(department2);
                Department department3 = new Department("Marketing", "Suzie Mort");
                root.subDepartments.Add(department3);
                Department department4 = new Department("HR", "Myranda Gabby");
                root.subDepartments.Add(department4);

                Department department1A = new Department("Budget", "Daniel Gray");
                department1.subDepartments.Add(department1A);
                Department department2A = new Department("Programming", "Quincy Cornell");
                department2.subDepartments.Add(department2A);
                Department department3A = new Department("Advertising", "Rosemarie Vinnie");
                department3.subDepartments.Add(department3A);
                Department department4A = new Department("Recruiting", "Millicent Leo");
                department4.subDepartments.Add(department4A);


                Department department1A1 = new Department("Establishment", "Hannah Kae");
                department1A.subDepartments.Add(department1A1);
                Department department2A2 = new Department("Q&A", "Fox Bronte");
                department2A.subDepartments.Add(department2A2);
                Department department3A3 = new Department("Market research", "Jaxtyn Jaki");
                department3A.subDepartments.Add(department3A3);
                Department department4A4 = new Department("Employee benefits", "Midge Antony");
                department4A.subDepartments.Add(department4A4);
                        
                Department department1A1A = new Department("Banking", "Emmie Margo");
                department1A1.subDepartments.Add(department1A1A);
                Department department2A2A = new Department("Project Managing", "Joandra Rosamund");
                department2A2.subDepartments.Add(department2A2A);
                Department department3A3A = new Department("Consumer Research", "Tyrrell Oswin");
                department3A3.subDepartments.Add(department3A3A);
                Department department4A4A = new Department("Health and relations", "Mozelle Linford");
                department4A4.subDepartments.Add(department4A4A);

                Employee emplyoeeA = new Employee("Tatiana Shanna", 1);
                department1.employees.Add(emplyoeeA);
                Employee emplyoeeB = new Employee("Mathilda Rosaleen", 2);
                department1A.employees.Add(emplyoeeB);
                Employee emplyoeeC = new Employee("Jérôme Ingram", 3);
                department1A1.employees.Add(emplyoeeC);
                Employee emplyoeeD = new Employee("Emily Chrysanta", 4);
                department1A1A.employees.Add(emplyoeeD);

                Employee emplyoeeE = new Employee("Stephany Sabine", 5);
                department2.employees.Add(emplyoeeE);
                Employee emplyoeeF = new Employee("Carl Digby", 6);
                department2A.employees.Add(emplyoeeF);
                Employee emplyoeeG = new Employee("Avery Scholastique", 7);
                department2A2.employees.Add(emplyoeeG);
                Employee emplyoeeI = new Employee("Reanna Idonea", 8);
                department2A2A.employees.Add(emplyoeeI);

                Employee emplyoeeH = new Employee("Candide Clémence", 9);
                department3.employees.Add(emplyoeeH);
                Employee emplyoeeK = new Employee("Vonda Thaddeus", 10);
                department3A.employees.Add(emplyoeeK);
                Employee emplyoeeO = new Employee("Memphis Harris", 11);
                department3A3.employees.Add(emplyoeeO);
                Employee emplyoeeL = new Employee("Apolline Arin", 12);
                department3A3A.employees.Add(emplyoeeL); ;


                Employee emplyoeeP = new Employee("Reed Tyrell", 13);
                department4.employees.Add(emplyoeeP);
                Employee emplyoeeT = new Employee("Tye Tracies", 14);
                department4A.employees.Add(emplyoeeT);
                Employee emplyoeeW = new Employee("Evie Summer", 15);
                department4A4.employees.Add(emplyoeeW);
                Employee emplyoeeZ = new Employee("Tilda Celia", 16);
                department4A4A.employees.Add(emplyoeeZ); ;

                return root;


            }       
        }

        public static void Display(Department root)
        {
            foreach (var department in root.subDepartments)
            {

                Console.WriteLine(department.depName);
                Display(department);

            }
        }


        internal static Department findDepartment(Department root, string name)
        {
            if (root.depName.Equals(name)) return root;

            foreach (var child in root.subDepartments)
            {
                if (child.depName.Equals(name)) return child;

                var department = findDepartment(child, name);
                if (department != null) return department;
            }

            return null;
        }


        public static void addDepartment(Department root, string name)
        {
            var input = findDepartment(root, name);
            Console.WriteLine("Please enter department name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Please enter the manager credentials: ");
            string manName = Console.ReadLine();
            input.subDepartments.Add(new Department(depName, manName));
            Console.WriteLine("Department added");
        }


        public static void RemoveDepartment(Department root, string depName)
        {
            var userDep = findDepartment(root, depName);
            Console.WriteLine("Please enter the name of the department you want to remove:");
            string nameInput = Console.ReadLine();
            foreach (var department in userDep.subDepartments)
            {
                if (department.depName.Equals(nameInput))
                {
                    userDep.subDepartments.Remove(department);
                    Console.WriteLine("Department removed successfully");
                    break;
                }
            }

        }


        public static void moveDep(Department root, string depName)
        {
            var userDep = findDepartment(root, depName);
            Console.WriteLine("Please enter the name of the subdepartment you want to move");
            string nameInput = Console.ReadLine();
            foreach (var department in userDep.subDepartments)
            {
                if (department.depName.Equals(nameInput))
                {
                    var storedDep = department;
                    userDep.subDepartments.Remove(department);
                    Console.WriteLine("Please enter the name of the department where you want to move the selected one");
                    depName = Console.ReadLine();
                    var destination = findDepartment(root, depName);
                    destination.subDepartments.Add(storedDep);
                    Console.WriteLine("Department Moved successfully");
                    break;
                }
            }
        }


        public static void printEmployee(Department root, int layer)
        {
            Console.WriteLine((root.subDepartments.Any() ? " - " : " - ") + root.depName + " "+ "Employees:" + string.Join(", ", root.employees.Select(e => e.fullName)) + " " + string.Join(", ", root.employees.Select(e => e.ID)));

            foreach (var child in root.subDepartments)
            {
                printEmployee(child, layer);
            }
        }



        public static void addEmployee(Department root, string depName)
        {
            var input = findDepartment(root, depName);
            Console.WriteLine("Please enter the name of the employee you want to add");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Please enter ID of the employee you want to add");
            int numberInput = int.Parse(Console.ReadLine());
            input.employees.Add(new Employee(nameInput, numberInput));
            Console.WriteLine("Employee added successfully");
        }


        public static void MoveEmployee(Department root, string depName)
        {
            var wantedDep = findDepartment(root, depName);
            Console.WriteLine("Please enter the name of the employee you want to move");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Please enter ID of the employee you want to move");
            int IDInput = int.Parse(Console.ReadLine());
            foreach (var employee in wantedDep.employees)
            {
                if (employee.fullName.Equals(nameInput) && employee.ID.Equals(IDInput)) 
                {
                    var stored = employee;
                    wantedDep.employees.Remove(employee);
                    Console.WriteLine("Where to you want to move the selected employee?");
                    depName = Console.ReadLine();
                    var destination = findDepartment(root, depName);
                    destination.employees.Add(stored);
                    Console.WriteLine("Employee moved successfully");
                    break;
                }
            }
        }

        public static void RemoveEmployee(Department root, string depName)
        {
            var wantedDep = findDepartment(root, depName);
            Console.WriteLine("Please enter the name of the employee you want to remove:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Please enter ID of the employee you want to remove");
            int IDInput = int.Parse(Console.ReadLine());
            foreach (var employee in wantedDep.employees)
            {
                if (employee.fullName.Equals(nameInput) && employee.ID.Equals(IDInput))
                {
                    wantedDep.employees.Remove(employee);
                    Console.WriteLine("Employee removed successfully");
                    break;
                }   
            }
        }


        public static int CountAllEmployees(Department root)
        {
            foreach (var department in root.subDepartments)
            {
                countempoyee += department.employees.Count();
                CountAllEmployees(department);
            }

            return countemployee + root.employees.Count;
        }

        public override string ToString() => $"Department: {depName}" + $"\nManager Name: {managerName}";
        

    }


}


