using System;

namespace ProjectManager.CommonEntities
{
    public class Tasks
    {
        public int TaskID { get; set; }
        public int? ParentTaskID { get; set; }
        public int? ProjectID { get; set; }
        public string ParentTask { get; set; }
        public string Project { get; set; }
        public string TaskName { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }

    }
}
