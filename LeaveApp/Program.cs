using System;
namespace LeaveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave App works!");
            EmployeeList.AddEmployee(1, "Janak", 1, "Developer", 16000);
            EmployeeList.AddEmployee(2, "Tahseen", 1, "Developer", 16000);
            EmployeeList.AddEmployee(3, "Rushi", 1, "Developer", 16000);
            EmployeeList.AddEmployee(4, "Archie", 1, "Admin", 16000);
            EmployeeList.AddEmployee(5, "Shruti", 2, "HR", 16000);
            EmployeeList.AddEmployee(6, "Divyangi", 2, "HR", 16000);
            LeaveList.AddNewLeave(1, "casual", 14);
            LeaveList.AddNewLeave(2, "sick", 5);
            LeaveList.AddNewLeave(3, "restricted", 1);
            LeaveList.AddNewLeave(4, "paternity", 5);
            var empList = EmployeeList.GetEmployees();
            var employee1 = new Employees();
            employee1.ApplyForLeave(1, 4);
            employee1.ApplyForLeave(2, 1);
            employee1.ApplyForLeave(4, 1);
            foreach (var l in employee1.ViewLeaves())
            {
                Console.WriteLine("Employee id : {2}, Leave id : {0}, No.Of Days : {1}", l.leaveId, l.days, l.employeeId);
            }

        }
    }
}
