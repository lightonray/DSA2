using System;
using System.Collections.Generic;

namespace DSAfinal
{
    class Program
    {

        static void Main(string[] args)

        {

            var root = Department.buildSampleData();
            
            bool finished = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine();
                Console.WriteLine("Tape 1 to DISPLAY the Company departments");
                Console.WriteLine("Tape 2 to FIND a Department");
                Console.WriteLine("Tape 3 to ADD a Department");
                Console.WriteLine("Tape 4 to REMOVE a Department");
                Console.WriteLine("Tape 5 to MOVE a Department");
                Console.WriteLine("Tape 6 to DISPLAY all the employees");
                Console.WriteLine("Tape 7 to ADD a emplyoee");
                Console.WriteLine("Tape 8 to MOVE a emplyoee");
                Console.WriteLine("Tape 9 to REMOVE a emplyoee");
                Console.WriteLine("Tape 9 to REMOVE a emplyoee");
                Console.WriteLine("Tape 10 to CALCULATE the number of emplyoees");
                Console.WriteLine("Tap 0 to EXIT The programm");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine();

                int answer;
                answer = Convert.ToInt32(Console.ReadLine());

                while (answer != 1 && answer != 2 && answer != 4 && answer != 5 && answer != 6 && answer != 7 && answer != 8 && answer != 9 && answer != 10 && answer != 0)
                {
                    Console.Write("This option does not exist. Choose an existing one: ");
                    answer = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                switch (answer)
                {
                    case 1:
                        Department.Display(root);
                        break;
                    case 2:
                        {
                                Console.WriteLine("Please enter the name of the department you want to find");
                                var userInput = Console.ReadLine();
                                Console.WriteLine(Department.findDepartment(root, userInput).ToString());   
                                Console.WriteLine("Please enter the correct value of input");                         
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Please enter the name of the department where you want to add the new sub deparment:");
                            var departmentName = Console.ReadLine();
                            Department.addDepartment(root, departmentName);
                            }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Please enter the name of the departmen you want to remove the sub department");
                            var depName = Console.ReadLine();
                            Department.RemoveDepartment(root, depName);
                        }

                        break;

                    case 5:
                        {
                            Console.WriteLine("Please enter the name of the Department you want to access");
                            var depName = Console.ReadLine();
                            Department.moveDep(root, depName);
                        }
                        break;

                    case 6:
                        {
                            Department.printEmployee(root, 0);
                        }
                        break;

                    case 7:
                        {
                            Console.WriteLine("Please enter the name of the Department where you want to add the new employee");
                            var depName = Console.ReadLine();
                            Department.addEmployee(root,depName);
                        }

                        break;

                    case 8:
                        {
                            Console.WriteLine("Please add the name of the Department where you want to pick the employee");
                            var depName = Console.ReadLine();
                            Department.MoveEmployee(root, depName);
 
                        }
                        break;

                    case 9:
                        {
                            Console.WriteLine("Please add the name of the Department where you want to pick the employee");
                            var depName = Console.ReadLine();
                            Department.MoveEmployee(root, depName);
                        }
                        break;

                    case 10:
                        {

                            Console.WriteLine(Department.CountAllEmployees(root));
                        }
                        break;

                    case 0:
                        {

                            finished = true;
                        }
                        break;
                }
            } while (!finished);
        }
    }
}
