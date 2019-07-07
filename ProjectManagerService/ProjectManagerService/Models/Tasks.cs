using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerService.Models
{
    public class Tasks
    {
        public int TaskID { get; set; }
        public int? ParentTaskID { get; set; }
        public int? ProjectID { get; set; }
        public string ParentTaskName { get; set; }
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
