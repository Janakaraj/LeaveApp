using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp
{
    public class Leaves
    {
        public int LeaveId { get; set; }
        public string LeaveName { get; set; }
        public int TotalDays { get; set; }
        public void AddLeave(int id, string name, int days)
        {
            this.LeaveId = id;
            this.LeaveName = name;
            this.TotalDays = days;
        }
    }
    public class LeaveList
    {
        public static List<Leaves> leaveList = new List<Leaves>();
        public static void AddNewLeave(int id, string name, int days)
        {
            var leave = new Leaves();
            leave.AddLeave(id,name,days);
            leaveList.Add(leave);
        }

    }
}
