﻿using NUnit.Framework;
using ProjectManager.InterfaceLayer;
using ProjectManagerService.Controllers;
using System;
using System.Collections.ObjectModel;
using System.Web.Http.Results;
using ProjectMangerModel = ProjectManagerService.Models;

namespace ProjectManagerService.Tests.UnitTest
{
    [TestFixture]
    public class ProjectControllersTest
    {

        private IProjectBL projectBL;
        private ProjectsController projectsController;

        [SetUp]
        public void TestSetUp()
        {
            projectBL = new MockProjectBL();
            projectsController = new ProjectsController(projectBL);
        }

        [TearDown]
        public void TestTearDown()
        {
            projectBL = null;
            projectsController = null;
        }

        [Test]
        public void GetProjectsTest()
        {
            var response = projectsController.GetProjects();
            var responseResult = response as OkNegotiatedContentResult<Collection<ProjectMangerModel.Projects>>;
            Assert.IsNotNull(responseResult);
            Assert.IsNotNull(responseResult.Content);
            foreach (var project in responseResult.Content)
            {
                Assert.IsNotNull(project.ProjectID);
                Assert.IsNotNull(project.ProjectName);
                Assert.IsNotNull(project.Priority);
            }
        }

        [Test]
        public void AddProjectTest_Success()
        {
            // Arrange
            ProjectMangerModel.Projects model = new ProjectMangerModel.Projects
            {
                ProjectID = 4,
                ProjectName = "Project 4",
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1)
            };

            // Act
            var response = projectsController.AddProject(model);

            // Assert
            Assert.IsTrue(response is OkResult);
        }

        [Test]
        public void AddProjectTest_Error()
        {
            // Arrange
            var projectController = new ProjectsController(null);

            ProjectMangerModel.Projects model = new ProjectMangerModel.Projects
            {
                ProjectID = 4,
                ProjectName = "Project 4",
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(1)
            };

            // Act
            var response = projectController.AddProject(model);

            // Assert
            Assert.IsTrue(response is InternalServerErrorResult);
        }

        [Test]
        public void UpdateProjectTest_Success()
        {
            // Arrange
            ProjectMangerModel.Projects model = new ProjectMangerModel.Projects
            {
                ProjectID = 1,
                ProjectName = "Project 1",
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(2)
            };

            // Act
            var response = projectsController.UpdateProject(model);

            // Assert
            Assert.IsTrue(response is OkResult);
        }

        [Test]
        public void UpdateProjectTest_Error()
        {
            // Arrange
            var projectController = new ProjectsController(null);

            ProjectMangerModel.Projects model = new ProjectMangerModel.Projects
            {
                ProjectID = 1,
                ProjectName = "Project 1",
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddDays(2)
            };

            // Act
            var response = projectController.UpdateProject(model);

            // Assert
            Assert.IsTrue(response is InternalServerErrorResult);
        }

        [Test]
        public void SuspendProjectTest_Success()
        {
            // Act
            var response = projectsController.SuspendProject(1);

            // Assert
            Assert.IsTrue(response is OkResult);
        }

        [Test]
        public void SuspendProjectTest_Error()
        {
            // Arrange
            var projectController = new ProjectsController(null);

            // Act
            var response = projectController.SuspendProject(1);

            // Assert
            Assert.IsTrue(response is InternalServerErrorResult);
        }
    }
}
