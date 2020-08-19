using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveApp
{
    public class AppliedLeave
    {
        public int employeeId { get; set; }
        public int leaveId { get; set; }
        public int days { get; set; }
        public string status { get; set; }
        public void TakeLeave(int eid, int lid, int days, string status="pending")
        {
            this.employeeId = eid;
            this.leaveId = lid;
            this.days = days;
            this.status = status;
        }
    }
    public static class AppliedLeaveList
    {
        public static List<AppliedLeave> appliedLeaveList = new List<AppliedLeave>();
        public static void ApplyLeave(int eid, int lid, int days)
        {
           var newLeave = new AppliedLeave();
            newLeave.TakeLeave(eid, lid, days);
            appliedLeaveList.Add(newLeave);
        }
        public static List<AppliedLeave> ViewYourLeaves(int eid)
        {
            var YourLeave = appliedLeaveList.Where(x => x.employeeId == eid).ToList();
            return YourLeave;
        }
    }
}
