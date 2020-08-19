using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveApp
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public double Salary { get; set; }
        public void AddEmployeeDetails(int eid, string ename, int did, string dname, double salary)
        {
            this.EmployeeId = eid;
            this.EmployeeName = ename;
            this.DepartmentId = did;
            this.DepartmentName = dname;
            this.Salary = salary;
        }
        public void ApplyForLeave(int lid, int days)
        {
            AppliedLeaveList.ApplyLeave(this.EmployeeId,lid,days);
        }
        public List<AppliedLeave> ViewLeaves()
        {
            return AppliedLeaveList.ViewYourLeaves(this.EmployeeId);
        }
    }
    class EmployeeList
    {
        static List<Employees> employeeList = new List<Employees>();
    public static void AddEmployee(int eid, string ename, int did, string dname, double salary)
        {
            Employees employee = new Employees();
            employee.AddEmployeeDetails(eid, ename, did, dname, salary);
            employeeList.Add(employee);
        }
        public static List<Employees> GetEmployees()
        {
            return employeeList;
        }
        public static Employees GetEmployee(int eid)
        {
            var employee = employeeList.Where(x => x.EmployeeId == eid).First();
            return employee;
        }
    }
}
