export class ProjectModel {
    ProjectID: number;
    ProjectName: string;
    StartDate?: Date;
    EndDate?: Date;
    Priority: number;
    ManagerID: number;
    ManagerName: string;
    NoofTasks: number;
    NoofCompletedTasks: number;
}
