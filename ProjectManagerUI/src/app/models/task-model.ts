export class TaskModel {
    ProjectID: number;
    ProjectName: string;
    TaskID: number;
    TaskName: string;
    ParentTaskID: number;
    ParentTaskName: string;
    Priority: number;
    StartDate?: Date;
    EndDate?: Date;
    UserID: number;
    UserName: string;
    Status: boolean;
}

export class ParentTaskModel {
    ParentTaskID: number;
    ParentTaskName: string;
}
