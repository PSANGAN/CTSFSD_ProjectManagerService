﻿using System;

namespace ProjectManager.CommonEntities
{
    public class Projects
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Priority { get; set; }
        public int ManagerID { get; set; }
        public string ManagerName { get; set; }
        public int NoofTasks { get; set; }
        public int NoofCompletedTasks { get; set; }

    }
}
