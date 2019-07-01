using NSubstitute;
using ProjectManager.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjectManagerService.Tests.UnitTest
{
    public class MockProjectManager
    {
        public ProjectManagerEntities MockDataSetList()
        {
            var dataProjects = new List<Project>()
            {
                new Project
                {
                    ProjectID=1,
                    ProjectName="Project 1",
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1)
                },
                new Project
                {
                    ProjectID=2,
                    ProjectName="Project 2",
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1)
                },
                new Project
                {
                    ProjectID=3,
                    ProjectName="Project 3",
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1)
                }
        }.AsQueryable();

            DbSet<Project> mocksetProjects = Substitute.For<DbSet<Project>,IQueryable<Project>>();
            ((IQueryable<Project>)mocksetProjects).Provider.Returns(dataProjects.Provider);
            ((IQueryable<Project>)mocksetProjects).Expression.Returns(dataProjects.Expression);
            ((IQueryable<Project>)mocksetProjects).ElementType.Returns(dataProjects.ElementType);
            ((IQueryable<Project>)mocksetProjects).GetEnumerator().Returns(dataProjects.GetEnumerator());

            var dataUsers = new List<User>()
            {
                new User
                {
                    UserID=1,
                    ProjectID=1,
                    FirstName="Sathya",
                    LastName="Natarajan",
                    EmployeeID="433461"
                },
                new User
                {
                    UserID=2,
                    ProjectID=1,
                    FirstName="Murali",
                    LastName="S",
                    EmployeeID="433465"
                },
                new User
                {
                    UserID=3,
                    ProjectID=2,
                    FirstName="Hari",
                    LastName="M",
                    EmployeeID="433469"
                }
        }.AsQueryable();

            DbSet<User> mocksetUsers = Substitute.For<DbSet<User>, IQueryable<User>>();
            ((IQueryable<User>)mocksetUsers).Provider.Returns(dataUsers.Provider);
            ((IQueryable<User>)mocksetUsers).Expression.Returns(dataUsers.Expression);
            ((IQueryable<User>)mocksetUsers).ElementType.Returns(dataUsers.ElementType);
            ((IQueryable<User>)mocksetUsers).GetEnumerator().Returns(dataUsers.GetEnumerator());

            var dataTasks = new List<ProjectManager.DataAccessLayer.Task>()
            {
                new ProjectManager.DataAccessLayer.Task
                {
                    TaskID=1,
                    TaskName="Task 1",
                    ProjectID=1,
                    Priority=10,
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1)
                },
                new ProjectManager.DataAccessLayer.Task
                {
                    TaskID=2,
                    TaskName="Task 2",
                    ProjectID=1,
                    Priority=20,
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1),
                    Status=true
                },
                new ProjectManager.DataAccessLayer.Task
                {
                   TaskID=3,
                    TaskName="Task 3",
                    ProjectID=2,
                    Priority=10,
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1)
                },
                new ProjectManager.DataAccessLayer.Task
                {
                   TaskID=4,
                    TaskName="Task 4",
                    ProjectID=2,
                    Priority=20,
                    StartDate=DateTime.Now.Date,
                    EndDate=DateTime.Now.Date.AddDays(1),
                    Status=true
                }
        }.AsQueryable();


            DbSet<ProjectManager.DataAccessLayer.Task> mocksetTasks = Substitute.For<DbSet<ProjectManager.DataAccessLayer.Task>, IQueryable<ProjectManager.DataAccessLayer.Task>>();

            ((IQueryable<ProjectManager.DataAccessLayer.Task>)mocksetTasks).Provider.Returns(dataTasks.Provider);
            ((IQueryable<ProjectManager.DataAccessLayer.Task>)mocksetTasks).Expression.Returns(dataTasks.Expression);
            ((IQueryable<ProjectManager.DataAccessLayer.Task>)mocksetTasks).ElementType.Returns(dataTasks.ElementType);
            ((IQueryable<ProjectManager.DataAccessLayer.Task>)mocksetTasks).GetEnumerator().Returns(dataTasks.GetEnumerator());

            var dataPTasks = new List<ParentTask>()
            {
                new ParentTask
                {
                    ParentTaskID=1,
                    ParentTaskName="Parent Task 1"
                },
                new ParentTask
                {
                    ParentTaskID=2,
                    ParentTaskName="Parent Task 2"
                }
        }.AsQueryable();

            DbSet<ParentTask> mocksetPTasks = Substitute.For<DbSet<ParentTask>, IQueryable<ParentTask>>();
            ((IQueryable<ParentTask>)mocksetPTasks).Provider.Returns(dataPTasks.Provider);
            ((IQueryable<ParentTask>)mocksetPTasks).Expression.Returns(dataPTasks.Expression);
            ((IQueryable<ParentTask>)mocksetPTasks).ElementType.Returns(dataPTasks.ElementType);
            ((IQueryable<ParentTask>)mocksetPTasks).GetEnumerator().Returns(dataPTasks.GetEnumerator());

            ProjectManagerEntities mockContext = Substitute.For<ProjectManagerEntities>();
            mockContext.Projects.Returns(mocksetProjects);
            mockContext.Users.Returns(mocksetUsers);
            mockContext.Tasks.Returns(mocksetTasks);
            mockContext.ParentTasks.Returns(mocksetPTasks);

            return mockContext;
        }

    }
}
